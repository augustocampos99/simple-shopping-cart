using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Enums
{
    public enum StatusOrderEnum
    {
        PENDING = 1,
        PAID = 2,
        PREPARING = 3,
        SEND = 4,
        DELIVERED = 5
    }
}
