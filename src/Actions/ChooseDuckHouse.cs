using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse {
        public static void CollectInput (Farm farm, IHousing animal) {
            Console.Clear();

            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                DuckHouse house = farm.DuckHouses[i];
                if (house.Capacity > 0) {
                Console.WriteLine ($"{i + 1}. Duck House");
                Console.Write($"Current animals: {house.GetList().Count}");
                Console.WriteLine ();
                }
            }

            Console.WriteLine ();

            // How can I output the type of animal chosen here?
            Console.WriteLine ($"Place the animal where?");

            Console.Write ("> ");
            int choice = Int32.Parse(Console.ReadLine ());
            int index = choice - 1;

            farm.DuckHouses[index].AddResource(animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}