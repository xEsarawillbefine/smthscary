using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    partial class Sea : Water
    {
        public int Area { set; get; }
        public string Name { set; get; }

        public override string ToString()
        {
            return $"{GetType()}: Type of water = {TypeOfWater}, Area = {Area}, Name = {Name}, Capacity = {Capacity}";
        }
    }
}
