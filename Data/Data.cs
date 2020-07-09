using Microsoft.EntityFrameworkCore;

namespace freightWebApp.Data
{
    public class freightWebAppContext : DbContext
    {
        public freightWebAppContext (
            DbContextOptions<freightWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<freightWebApp.Models.Freight> Freight { get; set; }
    }
}