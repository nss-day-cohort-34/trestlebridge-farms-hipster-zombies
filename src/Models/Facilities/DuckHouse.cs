using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class DuckHouse : IFacility<IHousing>
    {
        private int _capacity = 2;
        private Guid _id = Guid.NewGuid();
        private List<IHousing> _animals = new List<IHousing>();
        public List<IHousing> GetList()
        {
            return _animals;
        } 
        public double Capacity {
            get {
                return _capacity;
            }
        }


        public void AddResource(IHousing animal)
        {
            _animals.Add(animal);
            _capacity = _capacity - 1;
            Console.WriteLine($"Animal added to duck house. Current Animal Count is {_animals.Count}. Remaining capacity is {_capacity}.");
            Console.ReadLine();
        }

        public void AddResource(List<IHousing> animals)
        {
            throw new NotImplementedException();
        }
             
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck house {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}