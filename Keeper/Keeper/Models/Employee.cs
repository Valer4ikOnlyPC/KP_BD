using System;
using System.Collections.Generic;

namespace Keeper.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
            SalaryPayments = new HashSet<SalaryPayment>();
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; } = null!;
        public string? Patronymice { get; set; }
        public string Surname { get; set; } = null!;
        public byte Age { get; set; }
        public byte Seniority { get; set; }
        public string Gender { get; set; } = null!;
        public int PositionId { get; set; }
        public int CoffeeHouseId { get; set; }

        public virtual CoffeeHouse CoffeeHouse { get; set; } = null!;
        public virtual Position Position { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<SalaryPayment> SalaryPayments { get; set; }

        public override string ToString()
        {
            return $"{Surname} {Name}";
        }
    }
}
