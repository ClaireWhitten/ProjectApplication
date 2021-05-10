using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApplication.Classes
{
    class Invoice
    {
        public int InvoiceId { get; set; }

        public int SalesOrderId { get; set; }

        public DateTime Date { get; set; }

        public bool Paid { get; set; }


    }
}
