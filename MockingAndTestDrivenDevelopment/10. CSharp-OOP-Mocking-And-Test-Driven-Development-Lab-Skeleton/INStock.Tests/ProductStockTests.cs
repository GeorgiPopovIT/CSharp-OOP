namespace INStock.Tests
{
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class ProductStockTests
    {
        private Product product;
        private ProductStock stock;
        [SetUp]
        public void SetConstructor()
        {
            this.stock = new ProductStock();
            this.product = new Product("Bread", 1.2m, 1);
        }
        [Test]
        public void TestConstructor()
        {
            //Assert
            Assert.IsNotNull(stock);
        }
        [Test]
        public void TestCountProperty()
        {
            Assert.AreEqual(0, stock.Count);
        }
        [Test]
        public void TestAddMethod()
        {
            //Act
            stock.Add(product);
            //Assert
            Assert.AreEqual(stock.Count, 1);
        }
        [Test]
        public void TestContainsMethod()
        {
            //Act
            stock.Add(product);

            var expectedResult = stock.Contains(product);
            var actualResult = true;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void TestFindMethod()
        {
            //Act
            stock.Add(product);
            var expectedResult = stock.Find(0);
            var actualResult = product;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void TestFindAllByPrice()
        {
            //Arrange-Act
            stock.Add(product);
            stock.Add(new Product("Egg", 1.2m, 3));
            stock.Add(new Product("Milk", 2.2m, 5));
            var expectedResult = stock.FindAllByPrice(1.2m).Length;
            var actualResult = 2;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
