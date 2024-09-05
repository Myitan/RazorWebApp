using Microsoft.EntityFrameworkCore;
using SimpleCrudApp.Models;

namespace SimpleCrudApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}