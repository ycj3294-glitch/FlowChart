using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.PLC
{// plc 여러개일 때 설정
    public static class PlcConfigs
    {
        public static readonly List<PlcConfig> Items = new List<PlcConfig>
        {
            new PlcConfig
            {
                Name = "Dosing",
                IpAddress = "192.168.18.8",
                Port = 5002
            },

            new PlcConfig
            {
                Name = "Mixing",
                IpAddress = "192.168.0.11",
                Port = 5002
            }
        };
    }
}

