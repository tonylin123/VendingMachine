using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Snack : productList
    {
        public Snack(int id, string name, int price) : base(id, name, price)
        {
        }
    }

}

