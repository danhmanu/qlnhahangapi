using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLyNhaHangAPI.Entity
{
    [Table("cateshareh")]
    public class cateshareh
    {
        [Key]
        [Column(Order = 0)]
        public int idline { get; set; }
        public string name { get; set; }
        public string decrp { get; set; }
        public int active { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime timecr { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime timeup { get; set; }
    }
}
