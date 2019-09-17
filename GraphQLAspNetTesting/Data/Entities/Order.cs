using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQLAspNetTesting.Data.Entities
{
    public class Order : IEntity
    {
        public Guid Id { get; set; }
        public Customer Customer { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal PricePerUnit { get; set; }
        public Product Product { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
