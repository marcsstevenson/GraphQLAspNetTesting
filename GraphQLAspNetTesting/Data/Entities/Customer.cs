using System;
using System.Collections.Generic;

namespace GraphQLAspNetTesting.Data.Entities
{
    public class Customer : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public IList<Order> Orders { get; set; }
    }
}
