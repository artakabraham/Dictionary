using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new()
            {
                Id = 101,
                Name = "Mark",
                Salary = 5000
            };
            Customer customer2 = new()
            {
                Id = 102,
                Name = "Pam",
                Salary = 6500
            };
            Customer customer3 = new()
            {
                Id = 103,
                Name = "John",
                Salary = 2000
            };

            Dictionary<int, Customer> customersDictionary = new();
            customersDictionary.Add(customer1.Id, customer1);
            customersDictionary.Add(customer2.Id, customer2);
            customersDictionary.Add(customer3.Id, customer3);

            Customer customer101 = customersDictionary[101];

            foreach (KeyValuePair<int,Customer> customerKeyValuePair in customersDictionary)
            {
                Console.WriteLine($"Key - {customerKeyValuePair.Key} Name - { customerKeyValuePair.Value.Name}");
            } 
        }
    }
}
