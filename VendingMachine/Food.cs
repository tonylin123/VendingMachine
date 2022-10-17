using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Food : Product
    {
        public Food(string name, int price) : base(name, price) { }

        public override void Examine(Product product)
        {
            Console.WriteLine($"{Id} - {product.Name}, {product.Price} KR,");
        }

        public override void Use(Product product)
        {
            Console.WriteLine($"{product.Name} - Eat!");
        }


    }


}
