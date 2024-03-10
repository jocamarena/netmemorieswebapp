namespace WebApplication1.Models
{
    public class Author
    {
        public required int ID { get; set; }
        public required string Name { get; set; }
        public ICollection<Memory> Memories { get;  } = new List<Memory>();
    }
}
