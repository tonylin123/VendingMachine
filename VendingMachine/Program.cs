using System;
using System.Data.SqlTypes;
using VendingMachine;


namespace VendingMachine
{
    public class Program
    {

        
        private static void Main(string[] args)
        {

            VendingMachine vm = new VendingMachine();
            
            while (true)
            {
                
               int menu;
                Console.Write("\nHere are the options :\n");
                Console.Write("1-Purchase.\n2-ShowAll.\n3-InsertMoney.\n4-EndTransaction.\n5-Exit.\n");
                Console.Write("\nInput your choice :");


                int money;


           VendingMachine execute = new VendingMachine();

                //variables

                //run loop
                try
                {   

                    menu = Convert.ToInt32(Console.ReadLine());
                    // Console.WriteLine($"You currently have {user1.moneyPool}kr.\n\nWhich of the following would you like to do?\n1. Purchace an item from the vending machine\n2. Look at the items in the vending machine\n3. Insert money\n4. Leave the machine\n\n(Enter the number corresponding with the task you wish to perform))");
                    // int task = validator.isInt(Console.ReadLine());
                    switch (menu)
                {
                    case 1:

                            vm.Purchase(3);


                            break;
                    case 2:
                        execute.ShowAll();
                        break;
                    case 3:
                          // vm.InsertMoney();
                           

                            break;
                    case 4:
                            vm.EndTransaction();
                            
                            Console.Write("\nHere are the options :\n");
                            break;
                    case 5:
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
                Console.WriteLine("Any key return to the menu\n");
                Console.ReadKey();
            
                }
        }
           
    }
}
