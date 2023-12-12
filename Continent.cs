using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class Continent : Land
    {
        public int CountOfCountries { set; get; }


        public override string ToString()
        {
            Console.WriteLine($"{GetType()}: Climate = {Climate}, Количество стран = {CountOfCountries}");
            return $"{GetType()}: Climate = {Climate}, Количество стран = {CountOfCountries}";
        }
    }
}
