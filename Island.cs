using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class Island : Continent
    {
        public string OceanAround { set; get; }
        public override string ToString()
        {
            return $"{GetType()}: Climate = {Climate}, Количество стран = {CountOfCountries}, Ocean around = {OceanAround}, Name: {Name}";
        }
    }
}
