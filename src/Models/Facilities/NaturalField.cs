using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class NaturalField : IFacility<INaturaling>
    {
        private int _capacity = 60;
        private Guid _id = Guid.NewGuid();

        private List<INaturaling> _seeds = new List<INaturaling>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (INaturaling seed)
        {
            _seeds.Add(seed);
            Console.WriteLine("Seed added to field");
            Console.ReadLine();
        }


        public void AddResource (List<INaturaling> seeds)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural field {shortId} has {this._seeds.Count} seeds\n");
            this._seeds.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}