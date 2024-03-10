namespace WebApplication1.Models
{
    public class Memory
    {
        public required int ID { get; set; }
        public required string Description { get; set; }
        public required DateOnly Date { get; set; }
        public  Author? Author { get; set; }
        public  int? AuthorID { get; set; }
    }
}
