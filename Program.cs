

using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace LR4
{
    public partial class Sea : Water
    {
        public int Capacity { set; get; }
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            GeograficObject geograficObject = new GeograficObject()
            {
                Name = "First Geografic Object",
                Area = 100000,
            };
            Land land = new Land()
            {
                Name = "Пустыня",
                Area = 10000,
                Climate = "Сухой",
            };
            Continent continent = new Continent()
            {
                Name = "Евразия",
                Area = 9000,
                Climate = "Умеренный",
                CountOfCountries = 100,
            };
            Country country = new Country()
            {
                Name = "Германия",
                Area = 3000,
                Climate = "Умеренный",
                Capital = "Берлин",
            };

            Island island = new Island()
            {
                Name = "Гренландия",
                OceanAround = "Atlantic, Pasific, Indian",
                Area = 11000,
                Climate = "Умеренный",
                CountOfCountries = 44,
            };
            Minsk minsk = new Minsk()
            {
                Name = "Minsk",

            };
            Water water = new Water()
            {
                TypeOfWater = "Пресная",
            };
            Sea blacksea = new Sea()
            {
                Area = 1000,
                Name = "Черное море",
                Capacity = 14000,
            };
            geograficObject.ToString();
            land.ToString();
            continent.ToString();
            country.ToString();
            island.ToString();
            minsk.ToString();
            water.ToString();
            blacksea.ToString();

            if (land is Land)
            {
                Console.WriteLine($"тип land = {land.GetType()}");
            }
            else
            {
                Console.WriteLine($"land не тип Land");
            }
            Land landCast = geograficObject as Land;
            if (landCast != null)
            {
                Console.WriteLine($"geograficObject успешно приведен к типу Land");
            }
            else
            {
                Console.WriteLine($"geograficObject не удалось привести к типу Land");
            }
            Console.WriteLine("Принтер:");
            Printer printer = new Printer();

            City[] cities = new City[] { minsk };

            foreach (var city in cities)
            {
                printer.IAmPrinting(city);
            }

            OceanChoose oceanChoose = new OceanChoose();
            oceanChoose.ChooseOfOcean((OceanEnum)1);
            ClassContainerPlanet planet = new ClassContainerPlanet();
            planet.AddCountry(country);
            Console.WriteLine(12);
            planet.RemoveCountry(country);

            Continent Evrasia = new Continent()
            {
                Name = "Evrasia",
                Area = 999999,
                CountOfCountries = 12,
                Climate = "Умеренный"
            };

            Country Italy = new Country()
            {
                Name = "Italy",
                Capital = "Rome",
                ContinentName = "Evrasia"
            };
            Country Belarus = new Country() 
            {
                Name = "Belarus",
                Capital = "Minsk",
                ContinentName = "Evrasia"
            };
            Country Nepal = new Country()
            {
                Name = "Nepal",
                Capital = "Some Capital",
                ContinentName = "Africa"
            };
            Sea blackSea = new Sea()
            {
                Area = 12000,
                Name = "Black Sea",
                TypeOfWater = "Salt"
            };
            Sea redSea = new Sea()
            {
                Area = 1000,
                Name = "Red Sea",
                TypeOfWater = "Salt"
            };
            Island Zeland = new Island()
            {
                Climate = "Normal",
                Area = 2000,
                Name = "Zeland"

            };
            Island Sumatra = new Island()
            {
                Climate = "Normal",
                Area = 1000,
                Name = "Sumatra"

            };
            Island Kipr = new Island()
            {
                Climate = "Normal",
                Area = 3000,
                Name = "Kipr"


            };
            Console.WriteLine("Do:");
            planet.ShowInfo();
            Console.WriteLine();
            Console.WriteLine();
            planet.AddCountry(Italy);
            planet.AddCountry(Belarus);
            planet.AddCountry(Nepal);

            planet.SearchCountriesByContinent("Evrasia");
            planet.AddSea(blackSea);
            planet.AddSea(redSea);
            planet.CountOfSeas();
            planet.AddIsland(Zeland);
            planet.AddIsland(Kipr);
            planet.AddIsland(Sumatra);
            Console.WriteLine("Posle:");
            Console.WriteLine();
            planet.ShowInfo();
            Console.WriteLine();
            planet.IslandsInAlphabet();
            Console.WriteLine();
            planet.ShowInfo();



        }
    }

}
