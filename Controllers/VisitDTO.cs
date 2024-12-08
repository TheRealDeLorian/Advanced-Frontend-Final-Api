namespace Advanced_Frontend_Final_Api.Controllers
{
    public class VisitDTO
    {
        public int Id { get; set; }
        public int Personid { get; set; }
        public int Templeid { get; set; }
        public DateTime VisitTime { get; set; }
        public string Note { get; set; }
    }
}