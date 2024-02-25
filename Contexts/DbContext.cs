using Microsoft.EntityFrameworkCore;

namespace MyMvcProject.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

      
        public DbSet<Employee> Employees
        { get; set; }
    }
}

