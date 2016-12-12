using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prettyhair;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeleteProductFromSystem()
        {
            //Arrange
            Repository r1 = new Repository();
            Ware v1 = new Ware();
            //Act
            r1.Wareliste.Add(v1);
            //Assert
            Assert.AreEqual(v1, r1.Wareliste[0]);
            Assert.AreEqual(1, r1.Wareliste.Count);
            //Act
            r1.Wareliste.Remove(v1);
            //Assert
            Assert.AreEqual(0, r1.Wareliste.Count);
        }
        [TestMethod]
        public void AdjustPrice()
        {
            //Arrange
            Ware p1 = new Ware();
            //Act
            p1.price = 100;
            //Assert
            Assert.AreEqual(100, p1.price);
            //Act
            p1.price = 50;
            //Assert
            Assert.AreEqual(50, p1.price);
        }
        [TestMethod]
        public void AdjustDescription()
        {
            //Arrange
            Ware d1 = new Ware();
            //Act
            d1.description = "Haarprodukt";
            //Assert
            Assert.AreEqual("Haarprodukt", d1.description);
            //Act
            d1.description = "Handsker";
            //Assert
            Assert.AreEqual("Handsker", d1.description);
        }
        [TestMethod]
        public void AdjustAmount()
        {
            //Arrange
            Ware a1 = new Ware();
            //Act
            a1.amount = 10;
            //Assert
            Assert.AreEqual(10, a1.amount);
            a1.amount = 20;
            Assert.AreEqual(20, a1.amount);
        }
        [TestMethod]
        public void IsProductInInventory()
        {
            //Arrange
            Repository r1 = new Repository();
            Ware v1 = new Ware();
            //Act
            //Skal genere en metode, som finder en specific ting, såå når den tjekker for Assert, skal testens assert passe ned programmets før den passer. 
        }
        [TestMethod] 
        public void AddProductToSystem()
        {
            //Arrange
            Repository r1 = new Repository();
            Ware v1 = new Ware();
            //Act
            r1.Wareliste.Add(v1);
            //Assert
            Assert.AreEqual(v1, r1.Wareliste[0]);
            Assert.AreEqual(1, r1.Wareliste.Count);
        }
        [TestMethod]
        public void WareDesignation()
        {

        }
    }
}
