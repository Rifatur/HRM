using Microsoft.EntityFrameworkCore;
using MrHRM.Domain.Entities.HR;

namespace MrHRM.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> employees { get; set; }
    }
}
