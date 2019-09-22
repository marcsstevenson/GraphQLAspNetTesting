using GraphQL.Types;
using GraphQLAspNetTesting.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLAspNetTesting.GraphQl.Types
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(i => i.Id);
            Field(i => i.Name);
            Field(i => i.Price);
        }
    }
}
