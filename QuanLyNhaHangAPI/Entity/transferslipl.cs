using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLyNhaHangAPI.Entity
{
    [Table("transferslipl")]
    public class transferslipl
    {
        [Key]
        [Column(Order = 0)]
        public int idline { get; set; }
        public int idh { get; set; }
        public int iditem { get; set; }
        public int qtytransfer { get; set; }
        public int active { get; set; }
        public DateTime timecr { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime timeup { get; set; }
    }
}
