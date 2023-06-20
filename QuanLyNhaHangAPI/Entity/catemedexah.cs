using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLyNhaHangAPI.Entity
{
    [Table("catemedexah")]
    public class catemedexah
    {
        [Key]
        [Column(Order = 0)]
        public int idline { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string decrp { get; set; }
        public int active { get; set; }
        public DateTime timecr { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime timeup { get; set; }
    }
}
