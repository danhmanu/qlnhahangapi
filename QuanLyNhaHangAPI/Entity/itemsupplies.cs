using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLyNhaHangAPI.Entity
{
    [Table("itemsupplies")]
    public class itemsupplies
    {
        [Key]
        [Column(Order = 0)]
        public int idline { get; set; }

        [StringLength(30)]
        public string code { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public string desc { get; set; }

        public int idunit { get; set; }
        public int active { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime timecr { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime timeup { get; set; }
    }
}
