using NUnit.Framework;
using System;

[TestFixture]
public class DummyTests
{
    [Test]
    public void DummyLosesHealthIAttacked()
    {
        Dummy dummy = new Dummy(10, 10);

        dummy.TakeAttack(1);

        var actualResult = dummy.Health;
        var expectedResult = 9;

        Assert.AreEqual(actualResult, expectedResult);
    }
    [Test]
    public void DeadDummyThrowsExceptionIfAttacked()
    {
        //Arrange
        Dummy dummy = new Dummy(0,10);

        //Act-Assert
        Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(1));
    }
    [Test]
    public void DeadDummyCanGiveXP()
    {
        //Arrange
        Dummy dummy = new Dummy(0, 10);

        //Act
        var actualResult = 10;
        var expectedresult = dummy.GiveExperience();

        //Assert
        Assert.AreEqual(actualResult, expectedresult);
    }
    [Test]
    public void AliveDummyCantGiveXP()
    {
        //Arrange
        Dummy dummy = new Dummy(1, 10);
        //Act-Assert
        Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
    }
}
