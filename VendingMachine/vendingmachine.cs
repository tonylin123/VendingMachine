using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VendingMachine
{
    public class  VendingMachine : IVending
    {
        private readonly int[] denominations = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        
        public static List<productList> products = new List<productList>()
        {
            new Drink(1,"Cola", 11),
            new Drink(2,"Ice tea", 15),
            new Snack(3,"Kex", 15),
            new Snack(4,"Lays", 30),
          
            };
        public int moneyPool { get; set; }

        public void Purchase(int productId)
        {

            try
                {
               
                foreach (productList product in products)
            {
                if (product.id == productId)
                {  
                    if (product.price <= moneyPool)
                    {
                        moneyPool = moneyPool - product.price;
                        
                    }
                    else
                    {
                        throw new Exception("Not enough money");
                        }
                    }
                }
                }



            catch (FormatException e)
            {

                Console.Write(e.Message);
            }

        }
        public void ShowAll()
        {
            //initalising the products in this method
           


            Console.WriteLine($"{products.Count} products are available;");
            for (int i = 0; i < products.Count; i++)
            {
                products[i].examine();
            }
            
            Console.Read();
        }


        public bool InsertMoney(int money)
        {
            if (denominations.Contains(money))
            {
                moneyPool = money + moneyPool;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string EndTransaction()
        {
            StringBuilder sb = new StringBuilder();


            foreach (int coin in denominations)
            {
                if (moneyPool / coin > 0)
                {
                    sb.Append($"Returning: {moneyPool / coin} * {coin}");
                }
                moneyPool %= coin;
            }
            return sb.ToString();

        }

        
    }
}
