using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLyNhaHangAPI.Entity
{
    [Table("catesupplies")]
    public class catesupplies
    {
        [Key]
        [Column(Order = 0)]
        public int idline { get; set; }

        [StringLength(30)]
        public string code { get; set; }
        public string name { get; set; }
        public int active { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime timecr { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime timeup { get; set; }
    }
}
