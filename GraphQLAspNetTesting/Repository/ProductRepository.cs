using GraphQLAspNetTesting.Data;
using GraphQLAspNetTesting.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLAspNetTesting.Repository
{
    public class ProductRepository
    {
        private readonly OrderingContext dbContext;

        public ProductRepository(OrderingContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Product> GetAll()
        {
            return dbContext.Products;
        }
    }
}
