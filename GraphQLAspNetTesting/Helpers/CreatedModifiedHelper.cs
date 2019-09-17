using GraphQLAspNetTesting.Data.Entities;
using System;

namespace GraphQLAspNetTesting.Helpers
{
    public static class CreatedModifiedHelper
    {
        public static void SetForCreated(this IEntity entity)
        {
            entity.Created = DateTime.Now;

            entity.SetForModified();
        }

        public static void SetForModified(this IEntity entity)
        {
            entity.Modified = DateTime.Now;
        }
    }
}
