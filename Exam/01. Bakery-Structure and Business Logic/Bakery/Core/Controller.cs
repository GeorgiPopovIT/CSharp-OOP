using Bakery.Core.Contracts;
using Bakery.Models.BakedFoods;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables;
using Bakery.Models.Tables.Contracts;
using Bakery.Utilities.Enums;
using Bakery.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bakery.Core
{
    public class Controller : IController
    {
        private decimal sum = 0;
        private List<IBakedFood> bakedFoods;
        private List<IDrink> drinks;
        private List<ITable> tables;
        public Controller()
        {
            this.bakedFoods = new List<IBakedFood>();
            this.drinks = new List<IDrink>();
            this.tables = new List<ITable>();
        }
        public string AddDrink(string type, string name, int portion, string brand)
        {
            IDrink drink = CreateDrink(type, name, portion, brand);
            this.drinks.Add(drink);
            return String.Format(OutputMessages.DrinkAdded, name, brand);
        }

        public string AddFood(string type, string name, decimal price)
        {
            IBakedFood bakedFood = CreateFood(type, name, price);
            this.bakedFoods.Add(bakedFood);
            return String.Format(OutputMessages.FoodAdded, name, type);
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            ITable table = CreateTable(type, tableNumber, capacity);
            this.tables.Add(table);
            return String.Format(OutputMessages.TableAdded, tableNumber);
        }

        public string GetFreeTablesInfo()
        {
            StringBuilder sb = new StringBuilder();
            var freeTables = this.tables.Where(t => t.IsReserved == false);
            foreach (var table in freeTables)
            {
                sb.AppendLine(table.GetFreeTableInfo());
            }
            return sb.ToString().Trim();
        }

        public string GetTotalIncome()
        {
            foreach (var table in this.tables)
            {
                sum += table.GetBill();
            }
            return String.Format(OutputMessages.TotalIncome, sum);
        }

        public string LeaveTable(int tableNumber)
        {
            StringBuilder sb = new StringBuilder();
            var currTable = this.tables.FirstOrDefault(t => t.TableNumber == tableNumber);

            sb.AppendLine($"Table: {tableNumber}");
            sb.AppendLine($"Bill: {currTable.GetBill():F2}");
            // currTable.Clear();
            //sum -= currTable.GetBill();
            return sb.ToString().Trim();
        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            var currTable = this.tables.FirstOrDefault(t => t.TableNumber == tableNumber);
            var currDrink = this.drinks.FirstOrDefault(d => d.Name == drinkName && d.Brand == drinkBrand);
            if (currTable == null)
            {
                return String.Format(OutputMessages.WrongTableNumber, tableNumber);
            }
            else if (currDrink == null)
            {
                return String.Format(OutputMessages.NonExistentDrink, drinkName, drinkBrand);
            }
            currTable.OrderDrink(currDrink);
            return String.Format(OutputMessages.FoodOrderSuccessful, tableNumber, drinkName);
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            var currTable = this.tables.FirstOrDefault(t => t.TableNumber == tableNumber);
            var currFood = this.bakedFoods.FirstOrDefault(b => b.Name == foodName);
            if (currTable == null)
            {
                return String.Format(OutputMessages.WrongTableNumber, tableNumber);
            }
            else if (currFood == null)
            {
                return String.Format(OutputMessages.NonExistentFood, foodName);
            }
            currTable.OrderFood(currFood);
            return String.Format(OutputMessages.FoodOrderSuccessful, tableNumber, foodName);
        }

        public string ReserveTable(int numberOfPeople)
        {
            var tableToReserve = this.tables.FirstOrDefault(t => t.IsReserved == false && numberOfPeople <= t.Capacity);
            if (tableToReserve == null)
            {
                return String.Format(OutputMessages.ReservationNotPossible, numberOfPeople);
            }
            tableToReserve.Reserve(numberOfPeople);
            return String.Format(OutputMessages.TableReserved, tableToReserve.TableNumber, numberOfPeople);
        }
        private static IBakedFood CreateFood(string type, string name, decimal price)
        {
            Enum.TryParse(type, out BakedFoodType foodType);
            IBakedFood bakedFood = foodType switch
            {
                BakedFoodType.Bread => new Bread(name, price),
                BakedFoodType.Cake => new Cake(name, price),
                _ => default
            };

            return bakedFood;
        }
        private static IDrink CreateDrink(string type, string name, int portion, string brand)
        {
            Enum.TryParse(type, out DrinkType drinkType);
            IDrink drink = drinkType switch
            {
                DrinkType.Tea => new Tea(name, portion, brand),
                DrinkType.Water => new Water(name, portion, brand),
                _ => default
            };

            return drink;
        }
        private static ITable CreateTable(string type, int tableNumber, int capacity)
        {
            Enum.TryParse(type, out TableType drinkType);
            ITable table = drinkType switch
            {
                TableType.InsideTable => new InsideTable(tableNumber, capacity),
                TableType.OutsideTable => new OutsideTable(tableNumber, capacity),
                _ => default
            };

            return table;
        }
    }
}
