using Microsoft.EntityFrameworkCore;
using QuanLyNhaHangAPI.Entity;

namespace QuanLyNhaHangAPI.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<user> Users { get; set; }
    }
}
