using System;
using System.Collections.Generic;
using System.Text;

using ModbusStudio.Core.Interfaces;

namespace ModbusStudio.Services.Logging;

public class LoggerService : ILoggerService
{
    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {message}");
    }
}