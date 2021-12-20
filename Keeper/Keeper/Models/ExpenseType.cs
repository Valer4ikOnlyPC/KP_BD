using System;
using System.Collections.Generic;

namespace Keeper.Models
{
    public partial class ExpenseType
    {
        public ExpenseType()
        {
            CoffeeShopExpenses = new HashSet<CoffeeShopExpense>();
        }

        public int ExpenseTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CoffeeShopExpense> CoffeeShopExpenses { get; set; }
    }
}
