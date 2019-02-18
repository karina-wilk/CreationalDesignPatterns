using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Products
{
    public abstract class Flower
    {
        protected int NumberOfLeaves;
        private int NumberOfPetals;

        public string Color { get; set; }
        public Owner Owner { get; set; }

        protected Flower(int leavesCount, int petalsCount, string color, string ownerFirstName, string ownerLastName)
        {
            NumberOfLeaves = leavesCount;
            NumberOfPetals = petalsCount;
            Color = color;
            Owner = new Owner(ownerFirstName, ownerLastName);
        }

        public abstract Flower Clone();
    }
}
