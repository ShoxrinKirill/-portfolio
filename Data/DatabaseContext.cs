using _portfolio.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace _portfolio.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Example> Example { get; set; }
        public DbSet<Diplomas> Diplomas { get; set; }
    }
}