using Akbar_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Akbar_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<WebUser> webUsers { get; set; }
    }
}
