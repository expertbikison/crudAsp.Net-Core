using crudAsp.Net_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace crudAsp.Net_Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
