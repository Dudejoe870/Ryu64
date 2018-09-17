﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ryu64.MIPS
{
    public partial class InstInterp
    {
        public static void BNE(OpcodeTable.OpcodeDesc Desc)
        {
            if (Registers.R4300.Reg[Desc.op1] != Registers.R4300.Reg[Desc.op2]) Registers.R4300.PC += (ulong)(Desc.Imm * 4);
            Registers.R4300.PC += 4;
        }
    }
}