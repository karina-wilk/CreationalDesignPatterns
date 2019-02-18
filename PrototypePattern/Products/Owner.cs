using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Products
{
    public class Owner
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get => this.FirstName + " " + this.LastName;
        }

        public Owner(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }
    }
}
