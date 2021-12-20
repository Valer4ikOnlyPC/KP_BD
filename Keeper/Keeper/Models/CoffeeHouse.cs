using System;
using System.Collections.Generic;

namespace Keeper.Models
{
    public partial class CoffeeHouse
    {
        public CoffeeHouse()
        {
            CoffeeShopExpenses = new HashSet<CoffeeShopExpense>();
            Employees = new HashSet<Employee>();
            Products = new HashSet<Product>();
            RevenuePerDays = new HashSet<RevenuePerDay>();
        }

        public int CoffeeShopId { get; set; }
        public string Address { get; set; } = null!;
        public TimeSpan Start { get; set; }
        public TimeSpan EndOfWork { get; set; }

        public virtual ICollection<CoffeeShopExpense> CoffeeShopExpenses { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<RevenuePerDay> RevenuePerDays { get; set; }
    }
}
