using NUnit.Framework;
using System;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private Item item;
        private BankVault bankVault;
        [SetUp]
        public void Setup()
        {
            this.item = new Item("Georgi", "123");
            this.bankVault = new BankVault();
        }

        [Test]
        public void TestItemCtor()
        {
            Assert.IsNotNull(this.item);
        }
        [Test]
        public void TestBankVaultCtor()
        {
            Assert.IsNotNull(this.bankVault);
        }
        [Test]
        public void TestIReadOnlyCollection()
        {
            BankVault vault = new BankVault();
            var actualResult = vault.VaultCells;
            var expectedResult = this.bankVault.VaultCells;

            Assert.AreEqual(actualResult, expectedResult);
        }
        [Test]
        public void TestAddMethod_When_ContainsKey()
        {
            Item item2 = new Item("Pesho", "234");
            //this.bankVault.AddItem("1",item);
            Assert.Throws<ArgumentException>(() => bankVault.AddItem("C8", item2));
        }
        [Test]
        public void TestAddMethod_Is_nULL()
        {
            Item item2 = new Item("Pesho", "234");
            this.bankVault.AddItem("A1", item);
            Assert.Throws<ArgumentException>(() => bankVault.AddItem("A1", item2));
        }
        [Test]
        public void TestAddMethod_cellExist()
        {
            Item item2 = new Item("Pesho", "123");
            this.bankVault.AddItem("A1", item);
            Assert.Throws<InvalidOperationException>(() => bankVault.AddItem("B1", item2));
        }
        [Test]
        public void TestAddMethod_Correctly()
        {
            var result = this.bankVault.AddItem("A1", item);
            Assert.That(result, Is.TypeOf<string>());
        }
        [Test]
        public void RemoveMethod_When_IsNotContainsKey()
        {
            //this.bankVault.AddItem("A1", item);
            Assert.Throws<ArgumentException>(() => this.bankVault.RemoveItem("A1",item));
        }
        [Test]
        public void RemoveMethod_When_Is_DiffrentFromItem()
        {
            this.bankVault.AddItem("A1", item);
            Assert.Throws<ArgumentException>(() => this.bankVault.RemoveItem("A1", new Item("A1","455")));
        }
        [Test]
        public void RemoveMethod_Correctly()
        {
            this.bankVault.AddItem("A1", item);
            var result = this.bankVault.RemoveItem("A1", this.item);
            Assert.That(result, Is.TypeOf<string>());
        }
    }
}