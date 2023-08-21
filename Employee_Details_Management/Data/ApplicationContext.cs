using Employee_Details_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Details_Management.Data
{
    public class ApplicationContext :DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
