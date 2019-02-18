using BuilderPattern.Builder;
using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.SpecificBuilder
{
    public class ChickenSoupCook : SoupCook
    {
        public ChickenSoupCook()
            => this.Soup = new ChickenSoup();

        public override void AddSpiece(string spiece) 
            => this.Soup.Spices.Add(spiece);

        public override void AddVegetables(List<string> veggies)
        { 
            if(veggies.Contains("onion"))
            {
                //Frying onion...
                veggies.Remove("onion");
                veggies.Add("fried onion");
            }
            this.Soup.Vegetables.AddRange(veggies);
        }

        public override void BoilWater(int numerOfLiters)
            => this.Soup.WaterVolumeInLiters += numerOfLiters;
    }
}
