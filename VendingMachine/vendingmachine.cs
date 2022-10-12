using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class vendingmachine
    {
        public void showAll()
        {
            //initalising the products in this method
            List<productList> products = new List<productList>();
            products.Add(new Kex());
            products.Add(new Olw());
            products.Add(new Coke());
            products.Add(new Fanta());
            

            Console.WriteLine($"{products.Count} products are available;");
            for (int i = 0; i < products.Count; i++)
            {
                products[i].examine();
            }

            Console.Read();
        }
    
    public static int insertMoney()
    {
       
        
        int[] denominations = new int[8] { 1000, 500, 100, 50, 20, 10, 5, 1 };
        bool toInsert = true;
        int inserted = 0;
        while (toInsert)
        {
            int insertHolder = 0;
            Console.WriteLine("What size note would you like to insert? (1000, 500, 100, 50, 20, 10, 5, 1)\nOr type \"exit\" to go back to the main menu.");
           
            if (insertHolder!= 8)
            {
                    insertHolder = Convert.ToInt32(Console.ReadLine()) ;
            }
            else
            {
                toInsert = false;
            }
            foreach (int note in denominations)
            {
                if (insertHolder == note)
                {
                    Console.WriteLine("Your note has be inserted successfully.");
                    inserted += insertHolder;
                        Console.WriteLine(insertHolder);
                }
            }
        }
        return inserted;
    }

    public void endTransaction(int remainder)
    {
        int[] denominations = new int[8] { 1000, 500, 100, 50, 20, 10, 5, 1 };
        int[] returnedNotes = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
        for (int i = 0; i < denominations.Length; i++)
        {
            while (remainder >= denominations[i])
            {
                remainder -= denominations[i];
                returnedNotes[i]++;
            }
        }
        for (int i = 0; i < returnedNotes.Length; i++)
        {
            if (returnedNotes[i] > 0)
            {
                Console.WriteLine($"You recieve {returnedNotes[i]} {denominations[i]}kr notes,");
            }
        }
        Console.Read();
    }
}
}