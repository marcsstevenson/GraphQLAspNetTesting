using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLAspNetTesting.GraphQl
{
    public class OrderingSchema : Schema
    {
        public OrderingSchema(IDependencyResolver resolver): base(resolver)
        {
            Query = resolver.Resolve<ProductQuery>();
        }
    }
}
