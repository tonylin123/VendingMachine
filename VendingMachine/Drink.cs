using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Coke : productList
    {
        public Coke() : base("Cola", 11, "drink")
        {
        }
    }
    public class Fanta : productList
    {
        public Fanta() : base("Ice tea", 15, "drink")
        {
        }
    }
}