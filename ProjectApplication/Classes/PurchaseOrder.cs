using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApplication.Classes
{
    class PurchaseOrder
    {
        public int PurchaseOrderId { get; set; }

        public int OrderStatusId { get; set; }

        public DateTime OrderDate { get; set; }

        public double TotalPrice { get; set; }

        public int SupplierId { get; set; }

        public int EmployeeId { get; set; }

        public bool Paid { get; set; }
    }
}
