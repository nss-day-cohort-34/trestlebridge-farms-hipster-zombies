using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Chicken : IResource, IHousing, IMeatProducing, IEggProducing, IFeatherProducing
    {
        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 1.7;

        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        private double _eggsProduced = 7.0;

        private double _feathersProduced = 0.5;


        public string Type {get; } = "Chicken";

        public double FeedPerDay { get; set; } = 0.9;

        public double Butcher()
        {
            return _meatProduced;
        }

        public double EggProduction()
        {
            return _eggsProduced;
        }

        public double FeatherProduction()
        {
            return _feathersProduced;
        }

        public void Feed()
        {
            Console.WriteLine($"Chicken {this._shortId} just ate {this.FeedPerDay}kg of feed");
        }
        public override string ToString () {
            return $"Chicken {this._shortId}. Bwak!";
        }
    }
}