namespace QuanLyNhaHangAPI.Models
{
    public class UserModel
    {
        public Guid idline { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime timecr { get; set; }
        public DateTime timeup { get; set; }
        public int active { get; set; }
    }
}
