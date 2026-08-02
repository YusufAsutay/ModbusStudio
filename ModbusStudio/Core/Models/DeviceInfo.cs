using System;
using System.Collections.Generic;
using System.Text;

namespace ModbusStudio.Core.Models;

public class DeviceInfo
{
    public string IpAddress { get; set; } = "127.0.0.1";

    public int Port { get; set; } = 502;

    public byte SlaveId { get; set; } = 1;

    public override string ToString()
    {
        return $"{IpAddress}:{Port} (Slave:{SlaveId})";
    }
}