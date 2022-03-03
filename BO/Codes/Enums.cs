using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BO.Codes
{
    public enum CourseCategory
    {
        [Description("Database Server")]
        Database_Server,
        [Description("Grundliggende Programmering")]
        Grundliggende_Programmering,
        [Description("LAN Netværk")]
        LAN_Netværk,
        [Description("Objektorienteret Programmering")]
        Objektorienteret_Programmering,
        [Description("WAN Netværk")]
        WAN_Netværk,
        [Description("Web Server")]
        Web_Server
    }

    public enum SchoolingCategory
    {
        Programmeringslinje,
        Supporterlinje,
        Infrastrukturlinje
    }
}
