using NUnit.Framework;
using System.Collections.Generic;
using System;

namespace FightingArena
{
    public class ArenaTests
    {
        private Arena arena;
        private Warrior attacker;
        private Warrior defender;
        private IReadOnlyCollection<Warrior> warriors;
        [SetUp]
        public void Setup()
        {
            this.arena = new Arena();
            this.attacker = new Warrior("Pesho", 20, 40);
            this.defender = new Warrior("Gosho", 8, 35);
        }
        [Test]
        public void TestArenaConstructorIsNull()
        {
            Assert.IsNotNull(this.arena.Warriors);
        }
        [Test]
        public void TestArenaConstructor()
        {
            //Act
            var expectedResult = arena;
            var actualResult = new List<Warrior>();
            //Assert
            Assert.AreEqual(expectedResult.Count, actualResult.Count);
        }
        [Test]
        public void CountPropertyTset()
        {
            //Act
            var actualResult = arena.Count;
            var expectedResult = 0;
            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
        //[Test]
        public void TestWarriorsIReadOnlyCollectionProperty()
        {
            //Act
            var actualResult = warriors;
            var expectedResult = arena.Warriors;

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
        [Test]
        public void TestEnrollWithException()
        {
            //Arrange
            Warrior warrior = new Warrior("Pesho", 5, 30);
            //Act
            arena.Enroll(warrior);
            //Assert
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior));
        }
        [Test]
        public void TestEnrollCorrectly()
        {
            //Arrange
            Warrior warrior = new Warrior("Pesho", 5, 30);
            //Act
            arena.Enroll(warrior);

            var actualResult = arena.Count;
            var expectedResult = 1;
            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
        [Test]
        public void TestFightMethodWithExceptionWhenMissingAttacker()
        {
            arena.Enroll(defender);
            //Act-Assert
            Assert.Throws<InvalidOperationException>(()=> arena.Fight(attacker.Name,defender.Name));
        }
        [Test]
        public void TestFightMethodWithExceptionWhenMissingDefender()
        {
            arena.Enroll(attacker);
            //Act-Assert
            Assert.Throws<InvalidOperationException>(() => arena.Fight(attacker.Name, defender.Name));
        }
        [Test]
        public void TestFightMethodCorrectly()
        {
            //Arrange
            var expecetedAttackerHP = attacker.HP - defender.Damage;
            var expecetedDefenderHP = defender.HP - attacker.Damage;
            //Act
            arena.Enroll(attacker);
            arena.Enroll(defender);

            arena.Fight(attacker.Name, defender.Name);
            //Assert
            Assert.AreEqual(expecetedAttackerHP, attacker.HP);
            Assert.AreEqual(expecetedDefenderHP, defender.HP);
        }
    }
}
