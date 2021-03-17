using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Domain.Models.Order
{
    public class BillModel
    {
        public BillModel(){}
        public BillModel(int table, string total) {
            this.Table = table;
            this.TotalBill = total;
        }

        public int Table { get; set; }
        public string TotalBill { get; set; }
    }
}

