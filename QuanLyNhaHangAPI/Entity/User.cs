namespace QuanLyNhaHangAPI.Entity
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("user")]
    public partial class user
    {
        [Key]
        [Column(Order = 1)]
        public Guid idline { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int active { get; set; }
    }
}
