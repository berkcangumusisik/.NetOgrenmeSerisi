using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.LINQ
{
    public class DataSource
    {
        List<Customer> customers;
        public DataSource()
        {
            customers = new List<Customer>();
        }
        public List<Customer> customerList()
        {
            var faker = new Faker();

            for (int i = 0; i < 1000; i++)
            {
                Customer customer = new Customer();
                customer.ID = i;
                customer.Name = faker.Name.FirstName();
                customer.Surname = faker.Name.LastName();
                customers.Add(customer);

            }

            return customers;

            
        }
    }
}
