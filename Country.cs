using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class Country : Continent, IFirstInterface
    {
        public string Capital { set; get; }
        public string ContinentName { set; get; } 
        public int Population()
        {
            return 10000;
        }
        public override string ToString()
        {
            return $"{GetType()}: Name = {Name}, Climate = {Climate}, Capital = {Capital}, Population = {Population()}";
        }
    }
}
