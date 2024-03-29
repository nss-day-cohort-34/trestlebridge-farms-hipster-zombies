using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<IFacility<IPlantable>> PlowFields { get; } = new List<IFacility<IPlantable>> ();
        public List<IFacility<IPlantable>>  NaturalFields { get; } = new List<IFacility<IPlantable>> ();
        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();
        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();



        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T> (IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                default:
                    break;
            }
        }

        public void AddGrazingField (GrazingField field)
        {
            GrazingFields.Add(field);
        }

        public void AddPlowField (PlowField field)
        {
            PlowFields.Add(field);
        }

        public void AddNaturalField (NaturalField field)
        {
            NaturalFields.Add(field);
        }

        public void AddChickenHouse (ChickenHouse field)
        {
            ChickenHouses.Add(field);
        }

        public void AddDuckHouse (DuckHouse field)
        {
            DuckHouses.Add(field);
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));
            PlowFields.ForEach(pf => report.Append(pf));
            NaturalFields.ForEach(nf => report.Append(nf));
            ChickenHouses.ForEach(ch => report.Append(ch));
            DuckHouses.ForEach(dh => report.Append(dh));

            return report.ToString();
        }
    }
}