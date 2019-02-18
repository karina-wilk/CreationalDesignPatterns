using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Product
{
    public abstract class Soup
    {
        public List<string> Vegetables { get; set; }
        public int WaterVolumeInLiters { get; set; }
        public List<string> Spices { get; set; }

        public abstract void GetLabel();

    }
}
