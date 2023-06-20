namespace QuanLyNhaHangAPI.Models
{
    public class TransferSlipReadModel
    {
        public int idline { get; set; }
        public int idh { get; set; } 
        public int iditem { get; set; }
        public string codeitem { get; set; }
        public string nameitem { get; set; }
        public string nameunit { get; set; }
        public int qtytransfer { get; set; }
        public int active { get; set; }
        public DateTime timecr { get; set; }
        public DateTime timeup { get; set; }
    }
}
