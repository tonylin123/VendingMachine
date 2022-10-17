using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2022-10-17.
namespace VendingMachine
{
    internal class ApplicationManager
    {

        public void ShowMenu(VendingMachine vendingMachine)
        {




            while (true)
            {
                if (vendingMachine.Basket.Count > 0)
                    vendingMachine.ShowBasket();
                int menu;
                Console.WriteLine($"\nBalance:{vendingMachine.MoneyPool} KR.\n");
                Console.Write("Here are the options :\n");
                Console.Write("1-Purchase.\n2-ShowAll.\n3-InsertMoney.\n4-EndTransaction.\n");




                //run loop
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());


                    switch (menu)
                    {
                        case 1:
                            
                            
                            if (vendingMachine.MoneyPool != 0)
                            {
                                vendingMachine.ShowAll();

                                Console.WriteLine("Enter the product ID to purchase");
                                var input = Console.ReadLine();
                                bool inputok = int.TryParse(input, out int id);
                                if (inputok)
                                    vendingMachine.Purchase(id);

                            }
                            else
                                Console.WriteLine("Please insert money first\n");



                            break;
                        case 2:
                            vendingMachine.ShowAll();
                            break;
                        case 3:
                            vendingMachine.InsertMoney();


                            break;
                        case 4:
                            vendingMachine.EndTransaction();
                            Console.Write("\nThank you for your order.\n");
                            Environment.Exit(0);
                          
                            break;

                        default:
                            Console.Write("Input correct option\n" + menu);

                            break;
                    }
                }
                catch (FormatException e)
                {

                    Console.Write(e.Message);
                }
               // Console.WriteLine("\nAny key return to the menu\n");.
               

            }
        }

    }
}