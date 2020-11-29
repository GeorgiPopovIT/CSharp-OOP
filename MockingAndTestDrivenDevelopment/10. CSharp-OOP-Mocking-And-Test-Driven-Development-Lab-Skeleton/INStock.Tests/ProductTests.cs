using NUnit.Framework;
namespace INStock.Tests
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void TestProductConstrucor()
        {
            //Arrange
            Product product = new Product("Milk",2m,1);

            //Assert
            Assert.IsNotNull(product);
        }
       
    }
}