﻿using Chainblock.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Chainblock
{
    public class ChainBlock : IChainblock
    {
        private readonly Dictionary<int, ITransaction> transactions;
        public ChainBlock()
        {
            this.transactions = new Dictionary<int, ITransaction>();
        }
        public int Count => this.transactions.Count;

        public void Add(ITransaction tx)
        {
            if (this.transactions.ContainsKey(tx.Id))
            {
                throw new InvalidOperationException();
            }
            transactions[tx.Id] = tx;
        }

        public void ChangeTransactionStatus(int id, TransactionStatus newStatus)
        {
            throw new NotImplementedException();
        }

        public bool Contains(ITransaction tx)
        {
            if (!transactions.ContainsValue(tx))
            {
                return false;
            }
            return true;
        }

        public bool Contains(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException();
            }
            else if (!this.transactions.ContainsKey(id))
            {
                return false;
            }
            return true;
        }

        public IEnumerable<ITransaction> GetAllInAmountRange(double lo, double hi)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetAllOrderedByAmountDescendingThenById()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllReceiversWithTransactionStatus(TransactionStatus status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllSendersWithTransactionStatus(TransactionStatus status)
        {
            throw new NotImplementedException();
        }

        public ITransaction GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetByReceiverAndAmountRange(string receiver, double lo, double hi)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetByReceiverOrderedByAmountThenById(string receiver)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetBySenderAndMinimumAmountDescending(string sender, double amount)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetBySenderOrderedByAmountDescending(string sender)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetByTransactionStatus(TransactionStatus status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetByTransactionStatusAndMaximumAmount(TransactionStatus status, double amount)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<ITransaction> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void RemoveTransactionById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
