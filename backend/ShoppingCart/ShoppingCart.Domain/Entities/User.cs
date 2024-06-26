﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        public Guid Guid { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}
