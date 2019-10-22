using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class ChoosePlantableField {

        public static void CollectInput (Farm farm, IPlantable seed) {
            Console.Clear();

            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                IFacility<IPlantable> field= farm.NaturalFields[i];
                if (field.Capacity > 0) {
                Console.WriteLine ($"{i + 1}. Natural Field");
                Console.WriteLine($"Current Plant Seeds: {field.GetList().Count}");

                var plantsGroupedByType = field.GetList().GroupBy(n => n.plant);
                foreach (var group in plantsGroupedByType)
                {
                  Console.WriteLine($"{group.Key}: {group.Count()}");  
                }

                Console.WriteLine ();
                }
            }


            for (int i = 0; i < farm.PlowFields.Count; i++)
            {
                IFacility<IPlantable> field = farm.PlowFields[i];
                if (field.Capacity > 0) {
                Console.WriteLine ($"{i + 1 + farm.NaturalFields.Count}. Plow Field");
                Console.WriteLine($"Current Plant Seeds: {field.GetList().Count}");

                var plantsGroupedByType = field.GetList().GroupBy(n => n.plant);
                foreach (var group in plantsGroupedByType)
                {
                  Console.WriteLine($"{group.Key}: {group.Count()}");  
                }

                Console.WriteLine ();
                }
            }

            Console.WriteLine ();

            // How can I output the type of animal chosen here?
            Console.WriteLine ($"Place the seeds where?");

            Console.Write ("> ");
            int choice = Int32.Parse(Console.ReadLine ());
            int indexNatural = choice - 1;
            int indexPlow = choice - 1 - farm.NaturalFields.Count;

            if (choice <= farm.NaturalFields.Count) {
            farm.NaturalFields[indexNatural].AddResource(seed);
            } else {
            farm.PlowFields[indexPlow].AddResource(seed);
            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
    }