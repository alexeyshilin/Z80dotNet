﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konamiman.NestorMSX.Hardware;
using Konamiman.Z80dotNet;

namespace Konamiman.NestorMSX.Host
{
    public class MsxEmulator
    {
        private Z80Processor z80;
        private Tms9918 vdp;
        private SlotsSystem slots;

        public MsxEmulator()
        {
            z80 = new Z80Processor();
            z80.ClockSynchronizer = null;

            slots = new SlotsSystem();
            slots.SetSlotContents(0, new PlainRom(File.ReadAllBytes("v20bios.rom")));
            slots.SetSlotContents(3, new PlainMemory(65536));
            //slots.SlotSelectionRegisterWritten += (sender, args) => Console.WriteLine("--- Slots: {0:X} " + args.Value);
            z80.Memory = slots;

            vdp = new Tms9918(new ConsoleDisplayRenderer());
            z80.RegisterInterruptSource(vdp);

            z80.MemoryAccess += Z80OnMemoryAccess;
        }

        public void Run()
        {
            z80.Start();
        }

        private void Z80OnMemoryAccess(object sender, MemoryAccessEventArgs args)
        {
            if(args.EventType == MemoryAccessEventType.BeforePortRead)
                HandlePortRead(args);
            else if(args.EventType == MemoryAccessEventType.BeforePortWrite)
                HandlePortWrite(args);
        }

        private void HandlePortWrite(MemoryAccessEventArgs args)
        {
            switch(args.Address) {
                case 0xA8:
                    slots.WriteToSlotSelectionRegister(args.Value);
                    break;
                case 0x98:
                    vdp.WriteToPort(0, args.Value);
                    break;
                case 0x99:
                    vdp.WriteToPort(1, args.Value);
                    break;
            }
        }

        private void HandlePortRead(MemoryAccessEventArgs args)
        {
            args.CancelMemoryAccess = true;
            switch(args.Address) {
                case 0xA8:
                    args.Value = slots.ReadSlotSelectionRegister();
                    break;
                case 0x98:
                    args.Value = vdp.ReadFromPort(0);
                    break;
                case 0x99:
                    args.Value = vdp.ReadFromPort(1);
                    break;
                default:
                    args.Value = 0xFF;
                    break;
            }
            
        }
    }
}
