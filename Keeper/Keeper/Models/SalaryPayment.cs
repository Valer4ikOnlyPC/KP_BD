using System;
using System.Collections.Generic;

namespace Keeper.Models
{
    public partial class SalaryPayment
    {
        public int PayoutId { get; set; }
        public DateTime PayoutDate { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
