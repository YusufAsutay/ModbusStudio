using System;
using System.Collections.Generic;
using System.Text;

namespace ModbusStudio.Core.Interfaces;

public interface ILoggerService
{
    void Log(string message);
}