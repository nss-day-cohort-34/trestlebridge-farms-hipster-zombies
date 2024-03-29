using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid();

        public List<IGrazing> _animals = new List<IGrazing>();



        public List<IGrazing> GetList()
        {
            return _animals;
        } 

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (IGrazing animal)
        {
            _animals.Add(animal);
            _capacity = _capacity - 1;
            Console.WriteLine($"Animal added to grazing field. Current Animal Count is {_animals.Count}. Remaining capacity is {_capacity}.");
            Console.ReadLine();
        }


        public void AddResource (List<IGrazing> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}