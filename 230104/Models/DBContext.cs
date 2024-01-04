using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _230104.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {

        }

        public DBContext()
        {
        }

        public DbSet<Auto> Auto{ get; set; } = null;
        public DbSet<User> User{ get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string conn = "server=localhost; database=autok; user=root; password=";

                optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
            }
        }
    }
}
