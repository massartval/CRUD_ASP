using CRUD_ASP.Context.Config;
using CRUD_ASP.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ASP.Context
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        private string _connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CRUD_ASP;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableDetailedErrors(true);
            optionsBuilder.UseSqlServer(_connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
        }
    }
}
