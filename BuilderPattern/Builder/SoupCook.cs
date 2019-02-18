using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public abstract class SoupCook
    {
        protected Soup Soup { get; set; }

        public Soup PourSoupToPlate()
        {
            return this.Soup;
        }

        public abstract void BoilWater(int numerOfLiters);
        public abstract void AddVegetables(List<string> veggies);
        public abstract void AddSpiece(string spiece);
    }
}
