using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMDevices
{
    public enum BatteryTypes
    {
        Unknown,
        [Description("Li-Ion")]
        LiIon,
        NiMH,
        NiCd
    }
}
