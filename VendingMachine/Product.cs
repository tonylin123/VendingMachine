using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace VendingMachine
{


    public abstract class Product
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }





        public Product(string name, int price)
        {
            Name = name;
            Price = price;


        }

        public abstract void Examine(Product product);
        public abstract void Use(Product product);
    }
}