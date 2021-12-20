using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Keeper.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderAndItems = new HashSet<OrderAndItem>();
        }

        public int OrderId { get; set; }
        public int Table { get; set; }
        public TimeSpan Time { get; set; }
        public decimal OrderAmount { get; set; }
        public int EmployeeId { get; set; }
        public string? Status { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual ICollection<OrderAndItem> OrderAndItems { get; set; }

        [NotMapped]
        public string EmployeeSTR
        {
            get
            {
                using (ValeraDBContext db = new ValeraDBContext())
                {
                    Employee em1 = db.Employees.Where(s => s.EmployeeId == EmployeeId).FirstOrDefault();
                    return em1.ToString();
                }
            }
        }
    }
}
