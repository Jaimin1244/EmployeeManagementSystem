using System.Data.Entity;

namespace EmployeeManagementAPI.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext() : base("EmployeeDBContext") { }

        public DbSet<Employee> Employees { get; set; }
    }
}
