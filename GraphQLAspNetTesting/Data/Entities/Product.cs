using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQLAspNetTesting.Data.Entities
{
    public class Product : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
