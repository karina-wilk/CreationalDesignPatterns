using BuilderPattern.Director;
using BuilderPattern.Product;
using BuilderPattern.SpecificBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> avVegetables = new List<string>
            {
                "carrots",
                "tomatos",
                "potatos",
                "onion",
                "garlic"
            };

            List<string> avSpices = new List<string>
            {
                "salt",
                "pepper",
                "basil"
            };

            Chef chef = new Chef();
            Soup tomatoSoup = chef.PrepareSoup(new TomatoSoupCook(), avVegetables, avSpices);

            tomatoSoup.GetLabel();


            avVegetables.Add("chicken meat");
            Soup chickenSoup = chef.PrepareSoup(new ChickenSoupCook(), avVegetables, avSpices);

            chickenSoup.GetLabel();

            Console.Read();
        }
    }
}
