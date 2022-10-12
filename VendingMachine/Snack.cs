using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Kex : productList
    {
        public Kex() : base("Kex", 15, "eat")
        {
        }
    }
    public class Olw : productList
    {
        public Olw() : base("Lays", 30, "eat")
        {
        }
    }
}
