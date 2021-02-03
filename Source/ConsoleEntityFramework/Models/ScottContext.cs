using System;
using System.Data.Entity;

namespace ConsoleEntityFramework.Models
{
    public class ScottContext : DbContext
    {
        public ScottContext() : base("name=ScottDBConnectionString")
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
