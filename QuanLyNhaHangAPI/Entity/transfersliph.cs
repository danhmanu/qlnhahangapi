using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLyNhaHangAPI.Entity
{
    [Table("transfersliph")]
    public class transfersliph
    {
        [Key]
        [Column(Order = 0)]
        public int idline { get; set; }
        public string code { get; set; } // Mã phiếu 
        public string name { get; set; } // tên phiếu
        public int idmedexahexport { get; set; } // Khoa chuyển
        public int idmedexahimport { get; set; } // Khoa  nhận
        public int active { get; set; }
        public DateTime timecr { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime timeup { get; set; }
    }
}
