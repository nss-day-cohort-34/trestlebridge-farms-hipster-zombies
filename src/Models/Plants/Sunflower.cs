using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISeedProducing, ICompostProduction, IPlowing, INaturaling, IPlantable
    {
        private Guid _id = Guid.NewGuid();
         private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        private int _seedsProduced = 650;
        private double _compostProduced = 21.6;
        public string Type { get; } = "Sunflower";

        public string plant {get;} = "Sunflower";

        public double Compost()
        {
            return _compostProduced;
        }

        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Sunflower Seeds!";
        }

         public void Plow()
        {
            Console.WriteLine($"Sunflower {this._shortId} produced {this._seedsProduced} seeds! ");
        }

        public void Natural()
        {
             Console.WriteLine($"Sunflower {this._shortId} produced {this._seedsProduced} seeds! ");
        }

        public void Planting()
        {
            Console.WriteLine($"Sunflower {this._shortId} produced {this._seedsProduced} seeds! ");
        }
    }
}