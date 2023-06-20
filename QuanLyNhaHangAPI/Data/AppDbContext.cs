using Microsoft.EntityFrameworkCore;
using QuanLyNhaHangAPI.Entity;

namespace QuanLyNhaHangAPI.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<catemedexah> catemedexahs { get; set; }
        public virtual DbSet<catemedexal> catemedexals { get; set; }
        public virtual DbSet<cateshareh> catesharehs { get; set; }
        public virtual DbSet<catesharel> catesharels { get; set; }
        public virtual DbSet<catesupplies> catesuppliess { get; set; }
        public virtual DbSet<itemsupplies> itemsuppliess { get; set; }
        public virtual DbSet<transfersliph> transfersliphs { get; set; }
        public virtual DbSet<transferslipl> transferslipls { get; set; }
    }
}
