using System;
using System.Collections.Generic;
using System.Text;

namespace ModbusStudio.Core.Models;

public class RegisterCollection
{
    public bool[] Coils { get; } = new bool[1000];

    public bool[] DiscreteInputs { get; } = new bool[1000];

    public ushort[] HoldingRegisters { get; } = new ushort[1000];

    public ushort[] InputRegisters { get; } = new ushort[1000];
}