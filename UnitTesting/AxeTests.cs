using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    private Axe axe;
    private Dummy dummy;
    
    [Test]
    [TestCase(10, 10, 10, 10)]
    public void AxeLosesDurabilityAfterAttack(int attack, int durability
        , int health, int expierence)
    {
        //Arrange
        axe = new Axe(attack, durability);
        dummy = new Dummy(health, expierence);
        //Act
        axe.Attack(dummy);
        int expectedResult = axe.DurabilityPoints;
        int actualResult = 9;
        //Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    [TestCase(10, 10, 20, 0)]
    public void AttackingWithBrokenWeapon(
         int health, int experience, int attack, int durability)
    {
        //Arrange
        dummy = new Dummy(health, experience);
        axe = new Axe(attack, durability);

        //Act-Assert
        Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));

    }
}

