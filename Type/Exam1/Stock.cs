using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1
{
    public class Stock
    {
        public int StockQty { get; set; }

        public int? SafetyStockQty { get; set; } = null;

        public string UpdatedUser { get; set; }
    }
}
