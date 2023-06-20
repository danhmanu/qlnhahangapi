using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLyNhaHangAPI.Entity
{
    [Table("catemedexal")]
    public class catemedexal
    {
        [Key]
        [Column(Order = 0)]
        public int idline { get; set; }

        public int idh { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(100)]
        public string decrp { get; set; }
        public int active { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime timecr { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime timeup { get; set; }
    }
}
