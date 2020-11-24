using NUnit.Framework;
using System;
namespace CarManager
{
    public class CarTests
    {
        private Car car;
        [SetUp]
        public void Setup()
        {
            this.car = new Car("Audi", "А8", 7, 50);
        }

        [Test]
        public void TestPrivateConstructor()
        {
            //Act
            var fuelAmount = 0;
            //Assert
            Assert.AreEqual(fuelAmount, car.FuelAmount);
        }
        [Test]
        public void TestMakeSet()
        {
            string make = "Audi";
            //Assert
            Assert.AreEqual(make, car.Make);
        }
        [TestCase("")]
        [TestCase(null)]
        public void TestSetWithException(string make)
        {
            //Act-Assert
            Assert.Throws<ArgumentException>(() => new Car(make, "А8", 7, 50));
        }
        [Test]
        public void TestModelSet()
        {
            var model = "А8";
            //Assert
            Assert.AreEqual(car.Model,model);
        }
        [TestCase("")]
        [TestCase(null)]
        public void TestModelSetWithException(string model)
        {
            //Act-Assert
            Assert.Throws<ArgumentException>(() => new Car("Audi", model, 7, 50));
        }
        [Test]
        public void TestFuelConsumptionSet()
        {
            var fuelConsumption = 7;
            //Assert
            Assert.AreEqual(fuelConsumption, car.FuelConsumption);
        }
        [Test]
        [TestCase(0)]
        [TestCase(-2)]
        public void TestFuelConsumptionSetWithException(double fuelConsumption)
        {
            //Act-Assert
            Assert.Throws<ArgumentException>(() => new Car("Audi","A8",fuelConsumption,20));
        }
        [Test]
        public void TestFuelCapacitySet()
        {
            var fuelCapacity = 50;
            //Assert
            Assert.AreEqual(fuelCapacity, car.FuelCapacity);
        }
        [Test]
        [TestCase(0)]
        [TestCase(-2)]
        public void TestFuelCapacitySetWithException(double fuelCapacity)
        {
            //Act-Assert
            Assert.Throws<ArgumentException>(() => new Car("Audi", "A8", 7, fuelCapacity));
        }
        [Test]
        [TestCase(-4)]
        [TestCase(0)]
        public void TestRefuelWithExecption(double fuelToRefuel)
        {
            //Act-Assert
            Assert.Throws<ArgumentException>(() => car.Refuel(fuelToRefuel));
        }
        [Test]
        public void TestIsRefuelCorrectly()
        {
            //Act
            car.Refuel(20);
            var actualResult = car.FuelAmount;
            var expectedResult = 20;
            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
        [Test]
        public void TestIfFuelAmountIsBiggerThanFuelCapacity()
        {
            //Act
            car.Refuel(55);
            var actualResult = car.FuelAmount;
            var expectedResult = 50;
            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
        [Test]
        public void TestDriveWithException()
        {
            //Act-Assert
            Assert.Throws<InvalidOperationException>(() => car.Drive(800));
        }
        [Test]
        public void DriveCorrectly()
        {
            //Act
            car.Refuel(40);
            car.Drive(400);
            var expectedResult = 12;
            var actualResult = car.FuelAmount;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}