using System;
using System.Collections.Generic;

namespace Keeper.Models
{
    public partial class RevenuePerDay
    {
        public int RevenueId { get; set; }
        public decimal RevenueAmount { get; set; }
        public double RevenueRatio { get; set; }
        public DateTime Date { get; set; }
        public int CoffeeHouseId { get; set; }

        public virtual CoffeeHouse CoffeeHouse { get; set; } = null!;
    }
}
