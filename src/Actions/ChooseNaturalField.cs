using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class ChooseNaturalField {

        public static void CollectInput (Farm farm, INaturaling seed) {
            Console.Clear();

            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                NaturalField field = farm.NaturalFields[i];
                if (field.Capacity > 0) {
                Console.WriteLine ($"{i + 1}. Natural Field");
                Console.Write($"Current Plant Seeds: {field.GetList().Count}");
                Console.WriteLine ();
                }
            }

            Console.WriteLine ();

            // How can I output the type of animal chosen here?
            Console.WriteLine ($"Place the seeds where?");

            Console.Write ("> ");
            int choice = Int32.Parse(Console.ReadLine ());
            int index = choice - 1;

            farm.NaturalFields[index].AddResource(seed);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
    }