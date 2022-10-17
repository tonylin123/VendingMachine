using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//2022-10-17
namespace VendingMachine
{
    public class VendingMachine : IVending
    {

        private readonly int[] denominations = { 1, 5, 10, 20, 50, 100, 500, 1000 };

        public int MoneyPool { get; set; }
        public List<Product> Basket = new List<Product>();

        public List<Product> Products = new List<Product>();


        public void Productinventory()
        {
            Products.Add(new Drink("Coke", 15));
            Products.Add(new Drink("Fanta", 14));
            Products.Add(new Drink("Redbull", 20));
            Products.Add(new Snack("Lays", 27));
            Products.Add(new Snack("Pringles", 27));
            Products.Add(new Snack("Olw", 25));
            Products.Add(new Food("Sandwich", 50));
            Products.Add(new Food("Hamburger", 80));
            Products.Add(new Food("Bread", 30));


            for (int i = 0; i < Products.Count; i++)
            {
                Products[i].Id = i + 1;
            }
        }




        public void Purchase(int id)
        {

            if (id > Products.Count)
            {
                Console.WriteLine("Not a valid Id");
            }
            foreach (var product in Products)
            {
                if (product.Id == id)
                {
                    if (MoneyPool > product.Price)
                    {
                        Basket.Add(product);
                        MoneyPool -= product.Price;
                        Console.WriteLine($"{product.Name} was added to your baskcet.");
                    }
                    else
                    {
                        Console.WriteLine($"This item costs {product.Price} KR, but you have {MoneyPool} KR to spend");
                        Console.WriteLine("Insert more money or end transaction.");
                    }
                }
            }
        }

        public void ShowBasket()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Your current shoppingbasket:");
            foreach (var product in Basket)
                Console.WriteLine(product.Name);

            Console.WriteLine();
        }

        public void ShowAll()
        {
            //initalising the products in this method

            Console.WriteLine($"{Products.Count} products are available;");
            for (int i = 0; i < Products.Count; i++)
            {
                Products[i].Examine(Products[i]);
            }

            
        }

        public void InsertMoney()
        {
            bool insert = true;
            while (insert)
            {
                Console.WriteLine("Only accepted currencies are: 1, 5, 10, 20, 50, 100, 500, 1000");

                var correct = int.TryParse(Console.ReadLine(), out int Balance);
                switch (correct)
                {
                    case false:
                        Console.WriteLine("Please insert the correct currency.");

                        break;
                    case true:
                        if (!denominations.Contains(Balance))
                        {
                            Console.WriteLine("That is not a valid currency");
                            break;
                        }

                        MoneyPool += Balance;
                        Console.WriteLine($"You inserted {Balance}, Balance: {MoneyPool} KR.");
                        Console.WriteLine("Do you want to insert more? (y/n)");
                        var answer = Console.ReadLine().ToLower();
                        switch (answer)
                        {
                            case "y":
                                break;
                            case "n":
                                insert = false;
                                Console.Clear();
                                break;
                        }
                        break;
                }
            }
        }
        public Dictionary<int, int> EndTransaction()
        {
            if (Basket.Count > 0)
            {
                Console.WriteLine("The purchased products instruction.");
            }
            foreach (var item in Basket)
                item.Use(item);
            Console.WriteLine("Here is your money back. " + MoneyPool + " KR ");


            Dictionary<int, int> returnMoney = new Dictionary<int, int>();
            for (int i = denominations.Length - 1; i >= 0; i--)
            {
                int change = MoneyPool / denominations[i];
                if (change != 0)
                {
                    returnMoney.Add(denominations[i], change);
                }

                MoneyPool = MoneyPool % denominations[i];
            }


            foreach (var item in returnMoney)
            {
                Console.WriteLine("Quantity: " + item.Value + " Currency: " + item.Key + " KR ");
            }
            Console.WriteLine("\nPress any key to exit.");
            
            return returnMoney;
        }

    }
}
