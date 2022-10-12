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
        public string usageType { get; set; }
        public void use()
        {
            Console.WriteLine($"You {usageType} the {name}.");
        }
        public void examine()
        {
            Console.WriteLine($"The {name} costs {price}.");
        }
        public productList(string name, int price, string usageType)
        {
            this.name = name;
            this.price = price;
            this.usageType = usageType;
        }
    }
}