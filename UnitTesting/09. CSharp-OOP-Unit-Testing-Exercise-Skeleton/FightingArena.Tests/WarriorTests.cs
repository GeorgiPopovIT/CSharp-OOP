using NUnit.Framework;
using System;

namespace FightingArena
{
    public class WarriorTests
    {
        private Warrior warrior;
        [SetUp]
        public void Setup()
        {
             this.warrior = new Warrior("Pesho",8,30);
        }

        [Test]
        public void TestConstructor()
        {
            Assert.IsNotNull(warrior);
        }
        [Test]
        public void TestNameSet()
        {
            string name = "Pesho";
            Assert.AreEqual(name, warrior.Name);
        } 
        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void TestNameWithException(string name)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, 8,30));
        }
        [Test]
        public void TestDamageSet()
        {
            int damage = 8;
            Assert.AreEqual(damage,warrior.Damage);
        }
        [Test]
        public void TestDamageSetWithException()
        {
            int damage = -2;
            Assert.Throws<ArgumentException>(() => new Warrior("Pesho",damage,30));
        }
        [Test]
        public void TestHPSet()
        {
            int hp = 30;
            Assert.AreEqual(hp, warrior.HP);
        }
        [Test]
        public void TestHPSetWithException()
        {
            int hp = -2;
            Assert.Throws<ArgumentException>(() => new Warrior("Pesho", 8, hp));
        }
        [Test]
        public void TestAttackerWithBelowConstant()
        {
            Warrior warrior1 = new Warrior("Gosho",9,25);
            Warrior warrior2 = new Warrior("Pesho", 9, 25);
            //Act-Assert
            Assert.Throws<InvalidOperationException>(() => warrior1.Attack(warrior2));
        }
        [Test]
        public void TestDefenderWithBelowConstant()
        {
            Warrior warrior1 = new Warrior("Gosho", 9, 25);
            Warrior warrior2 = new Warrior("Pesho", 9, 25);
            //Act-Assert
            Assert.Throws<InvalidOperationException>(() => warrior2.Attack(warrior1));
        }
        [Test]
        public void TestAttackerHPBelowThanDefenderDamage()
        {
            Warrior warrior1 = new Warrior("Gosho", 9, 40);
            Warrior warrior2 = new Warrior("Pesho", 50, 40);

            //Act-Assert
            Assert.Throws<InvalidOperationException>(() => warrior1.Attack(warrior2));
        }
        [Test]
        public void TestAtatckDecrease()
        {
            //Arrange
            Warrior warrior1 = new Warrior("Gosho", 9, 40);
            Warrior warrior2 = new Warrior("Pesho", 35, 40);
            //Act
            int expecetedHP = warrior1.HP - warrior2.Damage;
            int expecetedwarior2Hp = warrior2.HP - warrior1.Damage;
            warrior1.Attack(warrior2);
            //Assert
            Assert.AreEqual(expecetedHP, warrior1.HP);
            Assert.AreEqual(expecetedwarior2Hp, warrior2.HP);

        }
        [Test]
        public void TestAtatckAttakerDamageIsBiggerThanDefenderHP()
        {
            //Arrange
            Warrior warrior1 = new Warrior("Gosho", 42, 40);
            Warrior warrior2 = new Warrior("Pesho", 35, 40);
            //Act
            int expecetedWariorHP = warrior1.HP - warrior2.Damage;
            int expecetedWarrior2HP = 0;
            warrior1.Attack(warrior2);
            //Assert
            Assert.AreEqual(expecetedWariorHP, warrior1.HP);
            Assert.AreEqual(expecetedWarrior2HP, warrior2.HP);

        }
    }

}