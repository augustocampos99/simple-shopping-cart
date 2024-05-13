using ShoppingCart.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public Guid Guid { get; set; }

        public string? Description { get; set; }

        public StatusOrderEnum Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public List<OrderItem> Items { get; set; }

        public User User { get; set; }

    }
}
