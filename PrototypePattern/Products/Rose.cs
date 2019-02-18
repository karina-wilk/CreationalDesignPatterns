using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Products
{
    public class Rose : Flower
    {
        public int NumberOfSpikes { get; set; }
        public Rose(string color, string ownerFName, string ownerLName) 
            : base(10, 50, color, ownerFName, ownerLName)
        {
            NumberOfSpikes = this.NumberOfLeaves;
        }
        public override Flower Clone()
        {
            var newRose = this.MemberwiseClone() as Rose; //shallow copy
            newRose.Owner = new Owner(this.Owner.FirstName, this.Owner.LastName);//deep copy
            
            return newRose;
        }
    }
}
