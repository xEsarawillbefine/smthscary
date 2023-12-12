using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal sealed class Minsk : City, IFirstInterface
    {
        private struct MinskInfo
        {
            public string Name;
            public int Population;
            public int Money;
        }

        private MinskInfo minskDetails;

        public Minsk()
        {
            minskDetails = new MinskInfo
            {
                Name = "Minsk",
                Population = 10000,
                Money = 10
            };
        }

        public override int Population()
        {
            Console.WriteLine(minskDetails.Population);
            return minskDetails.Population;
        }

        public override int Money()
        {
            Console.WriteLine("Теперь будем зарабатывать деньги");
            Console.WriteLine(minskDetails.Name);
            return minskDetails.Money;
        }

        public override string ToString()
        {
            Console.WriteLine($"{GetType()}: Name = {minskDetails.Name}, Population = {Population()}, Money = {Money()}");
            return $"{GetType()}: Name = {minskDetails.Name}, Population = {Population()}, Money = {Money()}";
        }

    }
}
