using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.CustomerName = "Gokhan";
            customer1.IdentityNumber = "12345678910";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Infinity Loop";
            customer2.TaxNumber = "1234567890";

            //Gerçek müşteri - Tüzel Müşteri 
            //Bunlar ayrı müşteri tipi aynı yerde kullanılmaz
            //SOLID
            //Bir yerde new görürsen bellekteki referans numarası olduğunu bil!
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);



        }

    }
}
