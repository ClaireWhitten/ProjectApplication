using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApplication.Classes
{
    class PurchaseOrderProduct
    {
        public int PurchaseOrderId { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }
    }
}
