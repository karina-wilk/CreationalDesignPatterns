﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Mouses
{
    public class TracerMouse : IMouse
    {
        public int DPI { get; set; }
        public decimal Price { get; set; }

        public int GetDPI()
        {
            Console.WriteLine("Call from method returning Tracer's mouse DPI");
            return DPI;
        }
    }
}
