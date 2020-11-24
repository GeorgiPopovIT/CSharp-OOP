using NUnit.Framework;
using System;

namespace Database
{
    public class DatabaseTests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void TestConstructor()
        {
            //Arrange
            Database database = new Database(1, 2, 3, 4, 5);
            //Act
            var actualResult = database.Count;
            var expectedRestult = 5;
            //Assert
            Assert.AreEqual(actualResult,expectedRestult);
        }
        [Test]
        public void AddMethod()
        {
            //Arrange
            Database database = new Database(1, 2, 3, 4, 5);
            //Act
            database.Add(1);
            var actualResult = database.Count;
            var expectedRestult = 6;
            //Assert
            Assert.AreEqual(actualResult, expectedRestult);
        }
        [Test]
        public void AddMethodWithException()
        {
            //Arrange
            Database database = new Database(1, 2, 3, 4, 5,6,7,8,9,10,11,12,13,14,15,16);
            //Act-Assert
            Assert.Throws<InvalidOperationException>(() => database.Add(16));
        }
        [Test]
        public void RemoveMethod()
        {
            //Arrange
            Database database = new Database(1,23,16);
            //Act
            database.Remove();
            var actualResult = database.Count;
            var expectedResult = 2;

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
        [Test]
        public void RemoveMethodWithException()
        {
            //Arrange
            Database database = new Database();
            //Act-Assert
            Assert.Throws<InvalidOperationException>(() => database.Remove());
           
        }
        [Test]
        public void FetchMethod()
        {
            //Arrange
            Database database = new Database(1,2,3,4,5);
            //Act
            var actualResult = new int[]{ 1, 2, 3, 4, 5 };

            var expectedResult = database.Fetch();
            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}