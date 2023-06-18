
namespace QuanLyNhaHangAPI.Entity
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("User")]
    public partial class User
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int siterf { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid idline { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
