using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Codes
{
    internal class Vehicles
    {
        public int Horsepower { get; set; }
    }

    internal class Car : Vehicles
    {
        public string Make { get; set; }

    }

    internal class Audi : Car
    {
        public string Model { get; set; }
    }
}

