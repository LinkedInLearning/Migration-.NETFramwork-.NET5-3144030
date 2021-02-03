using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleEntityFramework.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public int ManagerId { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }        
        public virtual Department Department { get; set; }
    }
}
