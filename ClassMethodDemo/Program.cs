using Business;
using Entity;
using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            // ctrl + k --> ctrl + c comment
            //Customer customer1 = new Customer
            //{
            //    Id = 1,
            //    FirstName = "John",
            //    LastName = "Doe"
            //};

            //Customer customer2 = new Customer
            //{
            //    Id = 2,
            //    FirstName = "John2",
            //    LastName = "Doe"
            //};

            // Another way
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "John";
            customer1.LastName = "Doe";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "John2";
            customer2.LastName = "Doe";

            customerManager.Add(customer1);
            customerManager.Delete(customer1);
            customerManager.Update(customer1);
            customerManager.customerList(customer2);
            
        }
    }
}
