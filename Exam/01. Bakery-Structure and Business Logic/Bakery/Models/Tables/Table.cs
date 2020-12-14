using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using Bakery.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bakery.Models.Tables
{
    public abstract class Table : ITable
    {
        private List<IBakedFood> bakedFoods;
        private List<IDrink> drinks;
        private int capacity;
        private int numberOfPeople;
        public Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            TableNumber = tableNumber;
            Capacity = capacity;
            PricePerPerson = pricePerPerson;
            this.bakedFoods = new List<IBakedFood>();
            this.drinks = new List<IDrink>();
        }
        public int TableNumber { get; }

        public int Capacity
        {
            get => this.capacity;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidTableCapacity);
                }
                this.capacity = value;
            }
        }

        public int NumberOfPeople
        {
            get => this.numberOfPeople;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidNumberOfPeople);
                }
                this.numberOfPeople = value;
            }
        }
        public IReadOnlyCollection<IBakedFood> FoodOrders => this.bakedFoods;
        public IReadOnlyCollection<IDrink> DrinkOrders => this.drinks;
        public decimal PricePerPerson { get; protected set; }

        public bool IsReserved { get; protected set; }

        public decimal Price => PricePerPerson * NumberOfPeople;

        public void Clear()
        {
            //foreach (var drink in this.drinks)
            //{
            //    this.drinks.Remove(drink);
            //}
            //foreach (var food in this.bakedFoods)
            //{
            //    this.bakedFoods.Remove(food);
            //}
            this.IsReserved = false;
            NumberOfPeople = 0;
        }

        public decimal GetBill()
        {
            return this.bakedFoods.Sum(x => x.Price) 
                + this.drinks.Sum(x => x.Price) + this.Price;
        }

        public string GetFreeTableInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Table: {TableNumber}");
            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Capacity: {Capacity}");
            sb.AppendLine($"Price per Person: {PricePerPerson}");

            return sb.ToString().Trim();
        }

        public void OrderDrink(IDrink drink)
        {
            this.drinks.Add(drink);
        }

        public void OrderFood(IBakedFood food)
        {
            this.bakedFoods.Add(food);
        }

        public void Reserve(int numberOfPeople)
        {
            this.IsReserved = true;
            NumberOfPeople = numberOfPeople;
        }
    }
}
