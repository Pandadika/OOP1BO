using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Codes
{
    // QUIZ SECTION 1/5
    /*
    internal class Vehicle
    {
        public int Horsepower { get; set; }
    }

    internal class Car : Vehicle
    {
        public string Make { get; set; }

    }

    internal class Audi : Car
    {
        public string Model { get; set; }
    }
    */

    // QUIZ SECTION 2/5
    /*
    internal class Car
    {
       public string Model { get; set; }
       public string Make { get; set; }
       public int Horsepower { get; set; }
    }
    internal class Vehicle
    {
        public List<Car> Cars { get; set; }
    }
    */

    //QUIZ SECTION 4/5
    /*
    internal class Vehicle
    {
        public int Horsepower { get; set; }
    }

    internal class Car : Vehicle
    {
        public string Make { get; set; }
        public virtual double WeightTax() 
        {
            return Make.Length;
        }

    }

    internal class Audi : Car
    {
        public string? Model { get; set; }
        public override double WeightTax()
        {
            return base.WeightTax()+Model.Length;
        }

    }
    */

    // QUIZ SECTION 5
    /*
    internal class Bil
    {

    }

    internal class Audi : Bil
    {
        public string Model
        {
            get; set;
        }
        public string SetSyn(DateTime now, DateTime årgang)
        {
            return DateTime.Now.ToString();
        }
        public string SetSyn(DateTime sidstSynet)
        {
            return DateTime.Now.ToString();
        }
        public void Overload()
        {
        }
    }
    */
}

