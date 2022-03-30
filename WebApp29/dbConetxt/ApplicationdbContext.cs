using Microsoft.EntityFrameworkCore;
using WebApp29.Models;

namespace WebApp29.dbConetxt
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Profile> Profiles { get; set; }
    }
}
