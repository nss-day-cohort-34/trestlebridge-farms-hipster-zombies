using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sesame : IResource, ISeedProducing, IPlowing
    {
         private Guid _id = Guid.NewGuid();
         private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        private int _seedsProduced = 40;
        public string Type { get; } = "Sesame";

        public double Harvest () {
            return _seedsProduced;
        }

        public void Plow()
        {

            Console.WriteLine($"Sesame {this._shortId} produced {this._seedsProduced} seeds! ");
        }


        public override string ToString () {
            return $"Sesame. Yum!";
        }
    }
}