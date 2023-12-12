using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class Land : GeograficObject
    {
        public string Climate { get; set; }
        public override string ToString()
        {
            Console.WriteLine($"{GetType()}: Climate = {Climate}");
            return $"{GetType()}: Climate = {Climate}";
        }
    }
}
