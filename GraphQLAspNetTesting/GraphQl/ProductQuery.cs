using GraphQL.Types;
using GraphQLAspNetTesting.GraphQl.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLAspNetTesting.GraphQl
{
    public class ProductQuery : ObjectGraphType
    {
        public ProductQuery()
        {
            Field<ListGraphType<ProductType>>(
                //"products", resolve context => 
                );
        }
    }
}
