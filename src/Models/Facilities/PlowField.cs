using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class PlowField : IFacility<IPlowing>
    {
        private int _capacity = 65;
        private Guid _id = Guid.NewGuid();

        private List<IPlowing> _seeds = new List<IPlowing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (IPlowing seed)
        {
            _seeds.Add(seed);
            Console.WriteLine("Seed added to field");
            Console.ReadLine();
        }


        public void AddResource (List<IPlowing> seeds)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plow field {shortId} has {this._seeds.Count} seeds\n");
            this._seeds.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}