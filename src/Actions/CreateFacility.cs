using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class CreateFacility {
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Grazing field");
            Console.WriteLine ("2. Plowed field");
            Console.WriteLine ("3. Natural field");
            Console.WriteLine ("4. Chicken house");
            Console.WriteLine ("5. Duck House");

            Console.WriteLine ();
            Console.WriteLine ("Choose what you want to create");

            Console.Write ("> ");
            string input = Console.ReadLine ();

            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    Console.WriteLine("New Grazing Field Created, Press Enter to Return to Menu.");
                    Console.ReadLine();
                    break;
                case 2:
                    farm.AddPlowField(new PlowField());
                    Console.WriteLine("New Plow Field Created, Press Enter to Return to Menu.");
                    Console.ReadLine();
                    break;
                case 3:
                    farm.AddNaturalField(new NaturalField());
                    Console.WriteLine("New Natural Field Created, Press Enter to Return to Menu.");
                    Console.ReadLine();
                    break;
                case 4:
                    farm.AddChickenHouse(new ChickenHouse());
                    Console.WriteLine("New Chicken House Created, Press Enter to Return to Menu.");
                    Console.ReadLine();
                    break;
                case 5:
                    farm.AddDuckHouse(new DuckHouse());
                    Console.WriteLine("New Duck House Created, Press Enter to Return to Menu.");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    }
}