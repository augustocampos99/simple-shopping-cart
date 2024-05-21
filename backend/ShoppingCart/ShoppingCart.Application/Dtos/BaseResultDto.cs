using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Application.Dtos
{
    public class BaseResultDto<T>
    {
        public BaseResultDto()
        {
            Message = String.Empty;
        }

        public bool Success { get; set; }

        public T? Result { get; set; }

        public string Message { get; set; }

    }
}
