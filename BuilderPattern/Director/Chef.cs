using BuilderPattern.Builder;
using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Director
{
    public class Chef
    {
        public Soup PrepareSoup(SoupCook cook, List<string> veggies, List<string> spieces)
        {
            cook.BoilWater(5);
            cook.AddVegetables(veggies);
            foreach (var s in spieces)
            {
                cook.AddSpiece(s);
            }

            return cook.PourSoupToPlate();
        }
    }
}
