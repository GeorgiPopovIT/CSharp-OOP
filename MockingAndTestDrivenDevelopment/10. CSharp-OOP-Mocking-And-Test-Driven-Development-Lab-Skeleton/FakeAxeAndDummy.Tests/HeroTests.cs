using FakeAxeAndDummy.Contracts;
using FakeAxeAndDummy.Tests.Fakes;
using Moq;
using NUnit.Framework;
[TestFixture]
public class HeroTests
{
    [Test]
    public void HeroWhenAttackTargests()
    {
        //Mock<ITarget> mockTarget = new Mock<ITarget>();

        //mockTarget.Setup(p => p.GiveExperience()).Returns(20);
        //mockTarget.Setup(p => p.IsDead()).Returns(true);
        //Mock<IWeapon> mockWeapon = new Mock<IWeapon>();
        //Hero hero = new Hero("Pesho", mockWeapon.Object);
        //hero.Attack(mockTarget.Object);
        //Assert.That(hero.Experience, Is.EqualTo(10));

        IWeapon fakeWeapon = new FakeWeapon();
        ITarget fakeTarget = new FakeTarget();

        Hero hero = new Hero("Pesho", fakeWeapon);
        hero.Attack(fakeTarget);

        Assert.AreEqual(20, hero.Experience);

    }

}