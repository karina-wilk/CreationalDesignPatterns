using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Product
{
    public class ChickenSoup : Soup
    {
        public ChickenSoup()
        {
            this.Spices = new List<string>();
            this.Vegetables = new List<string>();
        }
        public override void GetLabel()
            => Console.WriteLine($"Delicious Chicken Soup made of {String.Join(", ", Vegetables)}!");
    }
}
