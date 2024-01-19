using CRUDoperation.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CRUDoperation.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
