using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    public class Water
    {
        public string TypeOfWater { set; get; }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            Console.WriteLine("Молодец, ты перегрузил GetHashCode");
            return base.GetHashCode();
        }

        public override string ToString()
        {
            Console.WriteLine($"{GetType()}: Type of water = {TypeOfWater}, GetHashCode = {GetHashCode()}");
            return $"{GetType()}: Type of water = {TypeOfWater}, GetHashCode = {GetHashCode()}";
        }
    }
}
