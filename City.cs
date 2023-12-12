using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal abstract class City : Country
    {
        public virtual int Money()
        {
            int money = 10;
            Console.WriteLine("Количество денег за месяц");
            return money;
        }
        public virtual int Population()
        {
            int pop = 190;
            Console.WriteLine(pop);
            return pop;
        }

        public override string ToString()
        {
            Console.WriteLine($"{GetType()}: Climate = {Climate}, Name = {Name}, Population = {Population()}, Money = {Money()}");
            return $"{GetType()}: Climate = {Climate}, Name = {Name}, Population = {Population()}, Money = {Money()}";
        }
    }
}
