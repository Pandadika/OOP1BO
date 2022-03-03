using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Codes.Models
{
    internal class TECPerson : IComparable<TECPerson>
    {
        public SchoolingCategory schoolingCategory { get; set; }
        public string? fullname { get; set; }

        int IComparable<TECPerson>.CompareTo(TECPerson? other)
        {
            return fullname.CompareTo(other.fullname);
        }
    }
}
