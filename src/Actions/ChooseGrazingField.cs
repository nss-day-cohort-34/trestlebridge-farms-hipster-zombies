using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField {

        public static void CollectInput (Farm farm, IGrazing animal) {
            Console.Clear();


            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                GrazingField field = farm.GrazingFields[i];
                if (field.Capacity > 0) {
                Console.WriteLine ($"{i + 1}. Grazing Field");
                Console.WriteLine($"Current animals: {field.GetList().Count}");
                var animalsGroupedByType = field._animals.GroupBy(n => n.animal);
                foreach (var group in animalsGroupedByType)
                {
                  Console.WriteLine($"{group.Key}: {group.Count()}");
                }
                Console.WriteLine ();
                }
            }

if(farm.GrazingFields.Count >= 1) {
            Console.WriteLine ();

            // How can I output the type of animal chosen here?
            Console.WriteLine ($"Place the animal where?");


            Console.Write ("> ");
            int choice = Int32.Parse(Console.ReadLine ());
            int index = choice - 1;

            farm.GrazingFields[index].AddResource(animal);
             }else{
                Console.WriteLine("No Field to select from, Please purchase an appropriate facility. ");
                Console.ReadLine();
            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}