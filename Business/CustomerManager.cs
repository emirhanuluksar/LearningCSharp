using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class CustomerManager
    {

        /*
         * Simulation Of Adding
         */
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Added!");
        }

        /*
         * Simulation Of Updating
         */
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Updated!");
        }

        /*
         * Simulation Of Deleting
         */
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Deleted!");
        }
    }
}
