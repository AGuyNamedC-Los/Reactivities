using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DbSet<Activity> Activities { get; set; }     // name of database table

        public DataContext(DbContextOptions options) : base(options) {}
    }
}