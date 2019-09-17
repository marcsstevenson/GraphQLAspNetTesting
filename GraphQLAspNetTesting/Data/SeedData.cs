using GraphQLAspNetTesting.Data.Entities;
using GraphQLAspNetTesting.Helpers;
using RandomNameGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLAspNetTesting.Data
{
    public static class SeedData
    {
        public static void Seed(this OrderingContext dbContext)
        {
            if (!dbContext.Customers.Any())
            {
                var products = GenerateProducts(10);
                products.ForEach(p => dbContext.Products.Add(p));

                var customer = GenerateCustomer();                
                dbContext.Customers.Add(customer);

                var orders = GenerateOrders(customer, products);
                orders.ForEach(o => dbContext.Orders.Add(o));

                dbContext.SaveChanges();

                var ordersCount = dbContext.Orders.Count();
            }
        }

        private static Customer GenerateCustomer()
        {
            var personNameGenerator = new PersonNameGenerator();

            var customer =  new Customer
            {
                Name = personNameGenerator.GenerateRandomFirstAndLastName()

            };

            customer.SetForCreated();

            return customer;
        }

        private static List<Product> GenerateProducts(int count)
        {
            var products = new List<Product>();

            for (int i = 0; i < count; i++)
            {
                var product = new Product
                {
                    Name = "Product " + i
                };

                product.SetForCreated();

                products.Add(product);
            }

            return products;
        }

        private static List<Order> GenerateOrders(Customer customer, List<Product> products)
        {
            var random = new Random();
            var orders = new List<Order>();

            products.ForEach(p => {
                var order = new Order
                {
                    Customer = customer,
                    Product = p,
                    PricePerUnit = p.Price,
                    Quantity = random.Next(1, 20)
                };

                order.SetForCreated();

                orders.Add(order);
            });

            return orders;
        }
    }
}
