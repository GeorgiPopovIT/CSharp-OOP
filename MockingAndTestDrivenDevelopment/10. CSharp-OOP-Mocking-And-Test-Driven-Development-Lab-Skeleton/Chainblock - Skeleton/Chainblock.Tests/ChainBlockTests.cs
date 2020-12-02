using Chainblock.Contracts;
using Moq;
using NUnit.Framework;
using System;


namespace Chainblock.Tests
{
    [TestFixture]
    public class ChainBlockTests
    {
        private ITransaction transaction;
        private IChainblock chainBlock;
        [SetUp]
        public void SetUp()
        {
            this.transaction = new Transaction()
            {
                Id = 1,
                From = "Georgi",
                To = "Pesho",
                Status = TransactionStatus.Successfull,
                Amount = 1
            };
            this.chainBlock = new ChainBlock();
        }
        [Test]
        public void Given_Transaction_When_AddTransaction_Is_Called_Then_TransactionCountIncrease()
        {
            //Arrange
            Mock<IChainblock> dummyChainBlock = new Mock<IChainblock>();
            dummyChainBlock.SetupGet(x => x.Count).Returns(1);
            //Act
            int expetedChainBlockCount = 1;
            chainBlock.Add(transaction);
            //Assert
            Assert.AreEqual(expetedChainBlockCount, dummyChainBlock.Object);
        }
        [Test]
        //[Category("Add Mehod")]
        public void Given_Transaction_When_AddTransaction_Is_Called_Then_InvalidOperationExceptionIsThrown()
        {
            //Act
            chainBlock.Add(transaction);

            //Assert
            Assert.Throws<InvalidOperationException>(() => chainBlock.Add(transaction));
        }
        [Test]
        [Category("Count property")]
        public void Given_PropertyCountValue_WhenCountIsCalled_Then_ProperNumber()
        {
            int expectedChainBlockXCount = 0;
            Assert.AreEqual(expectedChainBlockXCount, chainBlock.Count);
        }
        [Test]
        [Category("Contains ---> id method")]
        public void GiveExistId_When_Contains_IsCalled_Then_ReturnTrue()
        {
            this.chainBlock.Add(this.transaction);
            var result = this.chainBlock.Contains(this.transaction.Id);

            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        [Category("Contains ---> id method")]
        public void GiveNonExistId_When_Contains_IsCalled_Then_ReturnFalse()
        {
            //Assert
            Assert.That(this.chainBlock.Contains(this.transaction.Id), Is.False);
        }
        [Test]
        [Category("Contains ---> id method")]
        public void GiveNegativeId_When_Contains_IsCalled_Then_ThrowInvalidArgumentException()
        {
            Assert.Throws<ArgumentException>(() => this.chainBlock.Contains(-1));
        }
        [Test]
        [Category("Contains --> Transaction method")]
        public void Give_ExistingTransaction_When_ContainsByIdtransactionsCalled_By_ReturnTrue()
        {
            chainBlock.Add(this.transaction);
            Assert.That(chainBlock.Contains(this.transaction),Is.True);
        }
        [Test]
        [Category("Contains --> Transaction method")]
        public void Give_NonExistingTransaction_When_ContainsByIdtransactionsCalled_By_ReturnTrue()
        {
            Assert.IsFalse(chainBlock.Contains(this.transaction));
        }
    }
}
