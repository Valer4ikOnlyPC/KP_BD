using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Keeper.Models
{
    public partial class OrderAndItem
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;

        [NotMapped]
        public string ProductName
        {
            get
            {
                using (ValeraDBContext db = new ValeraDBContext())
                {
                    Product pr1 = db.Products.Where(s => s.ProductId == ProductId).FirstOrDefault();
                    return pr1.ToString();
                }
            }
        }
        [NotMapped]
        public decimal ProductPrice
        {
            get
            {
                using (ValeraDBContext db = new ValeraDBContext())
                {
                    Product pr1 = db.Products.Where(s => s.ProductId == ProductId).FirstOrDefault();
                    return pr1.Price * Qty;
                }
            }
        }
    }
}
