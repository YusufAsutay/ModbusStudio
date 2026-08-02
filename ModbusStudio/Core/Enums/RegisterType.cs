using System;
using System.Collections.Generic;
using System.Text;

namespace ModbusStudio.Core.Enums;

public enum RegisterType
{
    Coil = 1,
    DiscreteInput = 2,
    HoldingRegister = 3,
    InputRegister = 4
}