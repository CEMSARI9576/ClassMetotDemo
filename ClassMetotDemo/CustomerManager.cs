using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customers cust)

        {
            Console.WriteLine("----------------Add---------------------");
            Console.WriteLine(cust.CustomerId + " ID numaralı" + cust.CustomerName +" "+ cust.CustomerLastName + " adlı müşteri eklenmiştir.");

        }
        public void DeleteCustomer(Customers cust)
           
        {
            Console.WriteLine("----------------Delete---------------------");
            Console.WriteLine(cust.CustomerId + " ID numaralı" + cust.CustomerName + " " +cust.CustomerLastName + " adlı müşteri silinmiştir.");
        }
        public void ListCustomers(Customers[] array)
        {
            Console.WriteLine("----------------List---------------------");
            foreach (Customers item in array)
            {
              
                Console.WriteLine(item.CustomerId + ":" + item.CustomerName + " " + item.CustomerLastName + " --->" + item.CustomerAdress+" kullanıcılar");
            } 
        }
    }
}

