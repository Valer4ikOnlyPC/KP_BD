using System;
using System.Collections.Generic;

namespace Keeper.Models
{
    public partial class CoffeeShopExpense
    {
        public int ExpenseId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; } = null!;
        public int CoffeeShopId { get; set; }
        public int ExpenseTypeId { get; set; }

        public virtual CoffeeHouse CoffeeShop { get; set; } = null!;
        public virtual ExpenseType ExpenseType { get; set; } = null!;
    }
}
