using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Duck : IResource, IHousing, IEggProducing, IFeatherProducing
    {
        private Guid _id = Guid.NewGuid();

        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        private double _eggsProduced = 6.0;

        private double _feathersProduced = 0.75;


        public string Type {get; } = "Duck";

        public double FeedPerDay { get; set; } = 0.8;

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
            Console.WriteLine($"Duck {this._shortId} just ate {this.FeedPerDay}kg of feed");
        }
        public override string ToString () {
            return $"Duck {this._shortId}. Quack!";
        }
    }
}