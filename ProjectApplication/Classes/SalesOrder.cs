using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApplication.Classes
{
    class SalesOrder
    {
        public int SalesOrderId { get; set; }

        public int OrderStatusId { get; set; }

        public DateTime OrderDate { get; set; }

        public int TotalPrice { get; set; }

        public int CustomerId { get; set; }

        public int EmployeeId { get; set; }

        public int InvoiceId { get; set; }

        public bool Paid { get; set; }

    }
}
