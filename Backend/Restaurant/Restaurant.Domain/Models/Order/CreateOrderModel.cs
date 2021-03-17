using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Domain.Models.Order
{
    public class CreateOrderModel
    {
        public int Table { get; set; }
        public Guid ProductId { get; set; }
    }
}
