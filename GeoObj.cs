using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class GeograficObject
    {
        public string Name { get; set; }
        public int Area { get; set; }

        public override string ToString()
        {
            Console.WriteLine($"{GetType()}: Name = {Name}, Area = {Area}");
            return $"{GetType()}: Name = {Name}, Area = {Area}";
        }

    }
}
