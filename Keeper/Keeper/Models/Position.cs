using System;
using System.Collections.Generic;

namespace Keeper.Models
{
    public partial class Position
    {
        public Position()
        {
            Employees = new HashSet<Employee>();
        }

        public int PositionId { get; set; }
        public string Title { get; set; } = null!;
        public decimal Rfp { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
