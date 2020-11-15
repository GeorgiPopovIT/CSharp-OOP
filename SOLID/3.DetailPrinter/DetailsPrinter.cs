using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class DetailsPrinter
    {
        private List<Employee> employees;

        public DetailsPrinter(List<Employee> employees)
        {
            this.employees = employees;
        }

        public void PrintDetails()
        {
            foreach (IWorker worker in this.employees)
            {
                //if (employee is Manager)
                //{
                //    this.PrintManager((Manager)employee);
                //}
                //else
                //{
                //    this.PrintEmployee(employee);
                //}
                this.PrintSomeone(worker);
            }
        }
        // crete a PrintSomeone

        private void PrintSomeone(IWorker worker)
        {
            Console.WriteLine(worker.ToString());
        }
        //private void PrintEmployee(Employee employee)
        //{
        //    Console.WriteLine(employee.Name);
        //}

        //private void PrintManager(Manager manager)
        //{
        //    Console.WriteLine(manager.Name);
        //    Console.WriteLine(string.Join(Environment.NewLine, manager.Documents));
        //}
    }
}
