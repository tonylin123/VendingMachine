
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using VendingMachine;
using Xunit;





namespace VendingMachine.test
{
    public class VendingMachineTest
    {
        public VendingMachine vendingmachine = new VendingMachine();
        public Product coke = new Drink("Coke", 15);
        [Fact]
        public void MoneyDenominationsContainsCorrectAmounChange()
            {
                
                int expectedLength = 8;
                int[] expetedMoneyDenomination = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
                
                int[] result = expetedMoneyDenomination;

                Assert.Equal(expectedLength, result.Length);
                Assert.NotNull(result);
                Assert.Equal(result, expetedMoneyDenomination);
         }


        [Fact]
        public void PurchaseTestWithID()
        {
            vendingmachine.MoneyPool = 100;
            vendingmachine.Products.Add(coke);
            coke.Id = 1;
            vendingmachine.Purchase(1);
            Assert.Equal(85, vendingmachine.MoneyPool);
        }


        [Fact]
        public void Test_Price()
        {
           
            // Act
            Assert.Equal(15, coke.Price);
        }
        [Fact]
        public void Test_Name()
        {
            
            // Act
            Assert.Equal("Coke", coke.Name);
        }
        [Fact]
        public void Basketcheck()
        {
            vendingmachine.Basket.Add(coke);
            Assert.True(vendingmachine.Basket != null);
        }
        [Fact]
        public void Returnmoeny()
        {
            vendingmachine.MoneyPool = 100;

            vendingmachine.EndTransaction();
            Assert.Equal(0, vendingmachine.MoneyPool);
        }
}
}


