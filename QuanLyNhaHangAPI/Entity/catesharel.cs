using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLyNhaHangAPI.Entity
{
    [Table("catesharel")]
    public class catesharel
    {
        [Key]
        [Column(Order = 0)]
        public int idline { get; set; }
        public int idh { get; set; }
        public string name { get; set; }
        public string decrp { get; set; }
        public int active { get; set; }
        public DateTime timecr { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime timeup { get; set; }
    }
}
