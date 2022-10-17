using System;
using System.Collections.Generic;
using System.Text;


namespace VendingMachine
{
    class Program
    {
        static bool alive = true;

        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.Productinventory();
            vendingMachine.MoneyPool = 0;

            ApplicationManager applicationManager = new ApplicationManager();

            Console.WriteLine("VENDING MACHINE");

            while (alive)
            {
                applicationManager.ShowMenu(vendingMachine);
            }
        }
    }
}