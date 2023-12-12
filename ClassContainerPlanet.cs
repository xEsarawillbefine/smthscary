using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
/*


Задание: Определить класс-Контейнер (указан в вариантах жирным шрифтом)
для хранения разных типов объектов (в пределах иерархии) в виде
списка или массива (использовать абстрактный тип данных). Классконтейнер должен содержать методы get и set для управления
списком/массивом, методы для добавления и удаления объектов в
список/массив, метод для вывода списка на консоль.

Вариант:
Создать Планету Земля. Найти все государства на заданном
континенте, подсчитать количество морей, вывести
острова по алфавиту




*/
namespace LR4
{
    internal class ClassContainerPlanet
    {

        private List<Country> countries;
        private List<Sea> seas;
        private List<Island> islands;
        public ClassContainerPlanet()
        {
            countries = new List<Country>();
            seas = new List<Sea>();
            islands = new List<Island>();
        }

        public List<Country> SearchCountriesByContinent(string continent)
        {
            var countriesInContinent = countries.Where(a => a.ContinentName.Equals(continent)).ToList();

            foreach (var country in countriesInContinent)
            {
                Console.WriteLine($"Country: {country.Name}, Capital: {country.Capital}, Continent: {country.ContinentName}");
            }
            return countries.Where(c => c.ContinentName.Equals(continent)).ToList();
        }
        public int CountOfSeas()
        {
            int count = seas.Count();
            Console.WriteLine(count);
            return count;
        }
        public void IslandsInAlphabet()
        {
            islands.Sort((isl1, isl2) => string.Compare(isl1.Name, isl2.Name));
            foreach(var el in islands)
            {
                Console.WriteLine(el);
            }
        }
        
        public void AddCountry(Country country)
        {
            countries.Add(country);
            

        }
        public void RemoveCountry(Country country)
        { 
            countries.Remove(country);
        }
        public void AddSea(Sea sea)
        {
            seas.Add(sea);


        }
        public void RemoveSea(Sea sea)
        {
            seas.Remove(sea);
        }
        public void AddIsland(Island island)
        {
            islands.Add(island);


        }
        public void RemoveIsland(Island island)
        {
            islands.Remove(island);
        }
        public void ShowInfo()
        {
            Console.WriteLine("Страны:");
            foreach (var el in countries)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine("Моря:");
            foreach (var el in seas)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine("Острова:");
            foreach (var el in islands)
            {
                Console.WriteLine(el);
            }
        }

    }
}
