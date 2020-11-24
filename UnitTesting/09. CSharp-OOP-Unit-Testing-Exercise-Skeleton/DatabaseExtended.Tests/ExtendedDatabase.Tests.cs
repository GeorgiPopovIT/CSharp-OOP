//using ExtendedDatabase;
using NUnit.Framework;
using System;

namespace ExtendedDatabase
{
    public class ExtendedDatabaseTests
    {

        private readonly Person[] people = new Person[]
        {
            new Person(1,"Ivan"),
            new Person(2,"Stamat")
        };

        private ExtendedDatabase extendedDatabase;
        [SetUp]
        public void Setup()
        {
            Person[] personsData = new Person[]
            {
                new Person(1, "Ivan1"),
                new Person(2, "Ivan2"),
                new Person(3, "Ivan3"),
                new Person(4, "Ivan4"),
                new Person(5, "Ivan5"),
                new Person(6, "Ivan6"),
                new Person(7, "Ivan7"),
                new Person(8, "Ivan8"),
                new Person(9, "Ivan9"),
                new Person(10, "Ivan10"),
                new Person(11, "Ivan11"),
                new Person(12, "Ivan12"),
                new Person(13, "Ivan13"),
                new Person(14, "Ivan14"),
                new Person(15, "Ivan15"),
            };
            this.extendedDatabase = new ExtendedDatabase(personsData);
        }
        [Test]
        public void TestPersonConstrucotr()
        {
            //Arrange
            Person person = new Person(1, "Ivan");
            //Act
            var expectedUsername = "Ivan";
            var actualUsername = person.UserName;

            var expectedId = 1;
            var actualId = person.Id;
            //Assert
            Assert.AreEqual(expectedUsername, actualUsername);
            Assert.AreEqual(expectedId, actualId);
        }
        [Test]
        public void TestExtendedDatabaseConstructor()
        {
            //Arrange
            this.extendedDatabase = new ExtendedDatabase(people);
            //Act
            var expectedResult = 2;
            var actualResult = extendedDatabase.Count;
            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
        [Test]
        public void TestConstructorWithAddRange()
        {
            //Arrange
            Person[] people = new Person[17];
            //ExtendedDatabase database = new ExtendedDatabase(people);
            //Act-Assert
            Assert.Throws<ArgumentException>(() => this.extendedDatabase = new ExtendedDatabase(people));
        }
        [Test]
        public void TestAddMethodWithContainsUserName()
        {
            //Arrange 
            Person person = new Person(31231, "Ivan1");
            //Act-Assert
            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Add(person));
        }
        [Test]
        public void TestAddMethodWithFullCapacity()
        {
            //Arrange 
            Person person = new Person(31231, "Ivan16");
            //Act
            extendedDatabase.Add(person);
            //Assert
            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Add(new Person(17, "Ivan17")));
        }
        [Test]
        public void TestAddMethodWithContainsId()
        {
            //Arrange 
            Person person = new Person(1, "Ivan45");
            //Act-Assert
            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Add(person));
        }
        [Test]
        public void TestRemoveMethodWithoutExecption()
        {
            //Arrange 
            var actualResult = 14;
            //Act
            this.extendedDatabase.Remove();
            var expectedResult = extendedDatabase.Count;
            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
        [Test]
        public void TestRemoveMethodWithExecption()
        {
            //Arrange 
            ExtendedDatabase database = new ExtendedDatabase(people);
            //Act
            database.Remove();
            database.Remove();
            //Assert
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }
        [Test]
        public void IfNoUserIsPresentByThisUserName()
        {
            //Arrange

            //Act-Assert
            Assert.Throws<InvalidOperationException>(() => extendedDatabase.FindByUsername("iovko"));
        }
        [Test]
        public void IfUsernameParamaterIsNull()
        {
            //Arrange

            //Act-Assert
            Assert.Throws<ArgumentNullException>(() => extendedDatabase.FindByUsername(null));
        }
        [Test]
        public void FindUsernameWithoutException()
        {
            //Arrange
            var person = new Person(1, "Ivan1");
            //Act
            var actualResult = "Ivan1";
            var expectedResult = extendedDatabase.FindByUsername(person.UserName).UserName;

            Assert.AreEqual(actualResult, expectedResult);
        }
        [Test]
        public void IfNoUserIsPresentByThisUserId()
        {
            //Arrange

            //Act-Assert
            Assert.Throws<InvalidOperationException>(() => extendedDatabase.FindById(34));
        }
        [Test]
        public void IfNegativeIdsAreFound()
        {
            //Arrange

            //Act-Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => extendedDatabase.FindById(-34));
        }
        [Test]
        public void FindIdWithoutException()
        {
            //Arrange
            var person = new Person(1, "Ivan1");
            //Act
            var actualResult = 1;
            var expectedResult = extendedDatabase.FindById(person.Id).Id;

            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}