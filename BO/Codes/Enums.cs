using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BO.Codes
{
    public enum CourseCategory
    {
        [Description("Grundliggende Programmering")]
        Grundliggende_Programmering,
        [Description("Objektorienteret Programmering")]
        Objektorienteret_Programmering,
        [Description("Web Server")]
        Web_Server,
        [Description("Database Server")]
        Database_Server,
        [Description("WAN Netværk")]
        WAN_Netværk,
        [Description("LAN Netværk")]
        LAN_Netværk
    }

    public enum SchoolingCategory
    {
        Programmeringslinje,
        Supporterlinje,
        Infrastrukturlinje
    }
}
