using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using QuanLyNhaHangAPI.Entity;
using System.Data.Entity;

namespace QuanLyNhaHangAPI.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration Configuration;
        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public AppDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
            var connectionString = Configuration.GetConnectionString("WebApiDatabase");
            options.UseMySQL(connectionString);
        }

        public virtual DbSet<User> Users { get; set; }
    }
}
