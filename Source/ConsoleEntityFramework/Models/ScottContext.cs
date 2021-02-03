using System;
using Microsoft.EntityFrameworkCore;

namespace ConsoleEntityFramework.Models
{
    public class ScottContext : DbContext
    {
        public ScottContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
                          .UseSqlServer(@"Data Source=(localdb)\ProjectsV14;Initial Catalog=Scott_EF;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
