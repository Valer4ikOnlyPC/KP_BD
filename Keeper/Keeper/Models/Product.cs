using System;
using System.Collections.Generic;

namespace Keeper.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderAndItems = new HashSet<OrderAndItem>();
        }

        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateOfWriteOff { get; set; }
        public int CoffeeShopId { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual CoffeeHouse CoffeeShop { get; set; } = null!;
        public virtual ICollection<OrderAndItem> OrderAndItems { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
