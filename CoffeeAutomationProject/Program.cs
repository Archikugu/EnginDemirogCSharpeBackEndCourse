using CoffeeAutomationProject.Abstract;
using CoffeeAutomationProject.Concrete;
using CoffeeAutomationProject.Entities;
using System;
using CoffeeAutomationProject.Adapters;

namespace CoffeeAutomationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = 1999, FirstName = "Gökhan", LastName = "Gök", NationalId = 1234567890 });

            BaseCustomerManager customerManager1 = new NeroCustomerManager();
            customerManager1.Save(new Customer { DateOfBirth = 1999, FirstName = "Gökhan", LastName = "Gök", NationalId = 1234567890 });

        }
    }
}
