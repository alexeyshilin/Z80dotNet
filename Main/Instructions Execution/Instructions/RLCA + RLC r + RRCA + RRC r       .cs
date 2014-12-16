﻿
// AUTOGENERATED CODE
//
// Do not make changes directly to this (.cs) file.
// Change "RLCA + RLC r + RRCA + RRC r       .tt" instead.

namespace Konamiman.Z80dotNet
{
    public partial class Z80InstructionExecutor
    {
		/// <summary>
        /// The RLC A instruction
        /// </summary>
        byte RLC_A()
        {
            FetchFinished();

            var oldValue = Registers.A;
	        var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Registers.CF = oldValue.GetBit(7);
            Registers.A = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RLC B instruction
        /// </summary>
        byte RLC_B()
        {
            FetchFinished();

            var oldValue = Registers.B;
	        var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Registers.CF = oldValue.GetBit(7);
            Registers.B = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RLC C instruction
        /// </summary>
        byte RLC_C()
        {
            FetchFinished();

            var oldValue = Registers.C;
	        var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Registers.CF = oldValue.GetBit(7);
            Registers.C = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RLC D instruction
        /// </summary>
        byte RLC_D()
        {
            FetchFinished();

            var oldValue = Registers.D;
	        var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Registers.CF = oldValue.GetBit(7);
            Registers.D = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RLC E instruction
        /// </summary>
        byte RLC_E()
        {
            FetchFinished();

            var oldValue = Registers.E;
	        var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Registers.CF = oldValue.GetBit(7);
            Registers.E = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RLC H instruction
        /// </summary>
        byte RLC_H()
        {
            FetchFinished();

            var oldValue = Registers.H;
	        var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Registers.CF = oldValue.GetBit(7);
            Registers.H = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RLC L instruction
        /// </summary>
        byte RLC_L()
        {
            FetchFinished();

            var oldValue = Registers.L;
	        var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Registers.CF = oldValue.GetBit(7);
            Registers.L = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RLC (HL) instruction
        /// </summary>
        byte RLC_aHL()
        {
            FetchFinished();

			var address = Registers.HL.ToUShort();
			var oldValue = ProcessorAgent.ReadFromMemory(address);
            var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Registers.CF = oldValue.GetBit(7);
			ProcessorAgent.WriteToMemory(address, newValue);
    
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 15;
        }

		/// <summary>
        /// The RLCA instruction
        /// </summary>
        byte RLCA()
        {
            FetchFinished();

            var oldValue = Registers.A;
	        var newValue = (byte)((oldValue << 1) | (oldValue >> 7));
            Registers.CF = oldValue.GetBit(7);
            Registers.A = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            return 4;
        }

		/// <summary>
        /// The RRC A instruction
        /// </summary>
        byte RRC_A()
        {
            FetchFinished();

            var oldValue = Registers.A;
	        var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
		    Registers.CF = oldValue.GetBit(0);
            Registers.A = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RRC B instruction
        /// </summary>
        byte RRC_B()
        {
            FetchFinished();

            var oldValue = Registers.B;
	        var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
		    Registers.CF = oldValue.GetBit(0);
            Registers.B = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RRC C instruction
        /// </summary>
        byte RRC_C()
        {
            FetchFinished();

            var oldValue = Registers.C;
	        var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
		    Registers.CF = oldValue.GetBit(0);
            Registers.C = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RRC D instruction
        /// </summary>
        byte RRC_D()
        {
            FetchFinished();

            var oldValue = Registers.D;
	        var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
		    Registers.CF = oldValue.GetBit(0);
            Registers.D = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RRC E instruction
        /// </summary>
        byte RRC_E()
        {
            FetchFinished();

            var oldValue = Registers.E;
	        var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
		    Registers.CF = oldValue.GetBit(0);
            Registers.E = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RRC H instruction
        /// </summary>
        byte RRC_H()
        {
            FetchFinished();

            var oldValue = Registers.H;
	        var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
		    Registers.CF = oldValue.GetBit(0);
            Registers.H = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RRC L instruction
        /// </summary>
        byte RRC_L()
        {
            FetchFinished();

            var oldValue = Registers.L;
	        var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
		    Registers.CF = oldValue.GetBit(0);
            Registers.L = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RRC (HL) instruction
        /// </summary>
        byte RRC_aHL()
        {
            FetchFinished();

			var address = Registers.HL.ToUShort();
			var oldValue = ProcessorAgent.ReadFromMemory(address);
            var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
		    Registers.CF = oldValue.GetBit(0);
			ProcessorAgent.WriteToMemory(address, newValue);
    
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 15;
        }

		/// <summary>
        /// The RRCA instruction
        /// </summary>
        byte RRCA()
        {
            FetchFinished();

            var oldValue = Registers.A;
	        var newValue = (byte)((oldValue >> 1) | (oldValue << 7));
		    Registers.CF = oldValue.GetBit(0);
            Registers.A = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            return 4;
        }

		/// <summary>
        /// The RL A instruction
        /// </summary>
        byte RL_A()
        {
            FetchFinished();

            var oldValue = Registers.A;
	        var newValue = (byte)((oldValue << 1) | (byte)Registers.CF);
		    Registers.CF = oldValue.GetBit(7);
            Registers.A = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RL B instruction
        /// </summary>
        byte RL_B()
        {
            FetchFinished();

            var oldValue = Registers.B;
	        var newValue = (byte)((oldValue << 1) | (byte)Registers.CF);
		    Registers.CF = oldValue.GetBit(7);
            Registers.B = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RL C instruction
        /// </summary>
        byte RL_C()
        {
            FetchFinished();

            var oldValue = Registers.C;
	        var newValue = (byte)((oldValue << 1) | (byte)Registers.CF);
		    Registers.CF = oldValue.GetBit(7);
            Registers.C = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RL D instruction
        /// </summary>
        byte RL_D()
        {
            FetchFinished();

            var oldValue = Registers.D;
	        var newValue = (byte)((oldValue << 1) | (byte)Registers.CF);
		    Registers.CF = oldValue.GetBit(7);
            Registers.D = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RL E instruction
        /// </summary>
        byte RL_E()
        {
            FetchFinished();

            var oldValue = Registers.E;
	        var newValue = (byte)((oldValue << 1) | (byte)Registers.CF);
		    Registers.CF = oldValue.GetBit(7);
            Registers.E = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RL H instruction
        /// </summary>
        byte RL_H()
        {
            FetchFinished();

            var oldValue = Registers.H;
	        var newValue = (byte)((oldValue << 1) | (byte)Registers.CF);
		    Registers.CF = oldValue.GetBit(7);
            Registers.H = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RL L instruction
        /// </summary>
        byte RL_L()
        {
            FetchFinished();

            var oldValue = Registers.L;
	        var newValue = (byte)((oldValue << 1) | (byte)Registers.CF);
		    Registers.CF = oldValue.GetBit(7);
            Registers.L = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 8;
        }

		/// <summary>
        /// The RL (HL) instruction
        /// </summary>
        byte RL_aHL()
        {
            FetchFinished();

			var address = Registers.HL.ToUShort();
			var oldValue = ProcessorAgent.ReadFromMemory(address);
            var newValue = (byte)((oldValue << 1) | (byte)Registers.CF);
		    Registers.CF = oldValue.GetBit(7);
			ProcessorAgent.WriteToMemory(address, newValue);
    
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
			Registers.PF = Parity[newValue];

			return 15;
        }

		/// <summary>
        /// The RLA instruction
        /// </summary>
        byte RLA()
        {
            FetchFinished();

            var oldValue = Registers.A;
	        var newValue = (byte)((oldValue << 1) | (byte)Registers.CF);
		    Registers.CF = oldValue.GetBit(7);
            Registers.A = newValue;
	
            Registers.HF = 0;
            Registers.NF = 0;
            SetFlags3and5From(newValue);
            return 4;
        }

	}
}
