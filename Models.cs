using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techfix_App
{
    internal class Models
    {
        public class Supplier
        {
            public int Id { get; set; }
            public string SupplierName { get; set; }
        }

        public class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string ProductDescription { get; set; }
            public decimal Price { get; set; }
            public int Stock { get; set; }
        }

    }
}
