using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApplication.Classes
{
    class SalesOrderProduct
    {
        public int SalesOrderId { get; set; }

        public int ProductId { get; set; }

        public SalesOrder SalesOrder { get; set; }

        public Product Product { get; set; }

    }
}
