using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customer1 = new Customers();
            customer1.CustomerId = 1000;
            customer1.CustomerName = "Cem";
            customer1.CustomerLastName = "Sarı";
            customer1.CustomerAdress = "İstanbul";
            Customers customer2 = new Customers();
            customer2.CustomerId = 1001;
            customer2.CustomerName = "Sefa";
            customer2.CustomerLastName = "Güler";
            customer2.CustomerAdress = "Kocaeli";
            Customers customer3 = new Customers();
            customer3.CustomerId = 1003;
            customer3.CustomerName = "İlkcan";
            customer3.CustomerLastName = "Ceylan";
            customer3.CustomerAdress = "Konya";

            Customers[] array = new Customers[] { customer1, customer2,customer3 };

            CustomerManager manage = new CustomerManager();
            manage.AddCustomer(customer3);
            manage.DeleteCustomer(customer3);
            manage.ListCustomers(array);


            
        }
    }
}
