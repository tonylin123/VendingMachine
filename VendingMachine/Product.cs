using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class userData
    {
        public int moneyPool;
    }

    public abstract class productList
    {
        public string name { get; set; }
        public int price { get; set; }
        public int id { get; set; }


        public void examine()
        {
            Console.WriteLine($"The {name} costs {price}.");
        }
        public productList(int id ,string name, int price)
        {    
            this.name = name;
            this.price = price;
            this.id = id;

        }
    }
}