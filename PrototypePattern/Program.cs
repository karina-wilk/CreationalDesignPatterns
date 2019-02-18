using PrototypePattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var rose = new Rose("red", "John", "Kovalsky");
            var clonedRose = rose.Clone();

            Console.WriteLine($"Original's owner: {rose.Owner.FullName}, \tcopy's owner: {clonedRose.Owner.FullName}");

            clonedRose.Owner.FirstName = "Ana";

            Console.WriteLine($"Original's owner: {rose.Owner.FullName}, \tcopy's owner: {clonedRose.Owner.FullName}");

            Console.Read();
        }
    }
}
