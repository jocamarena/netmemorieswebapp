using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Author
    {
        [Key]
        public required int ID { get; set; }
        [Display(Name = "Name")]
        public required string Name { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        public ICollection<Memory> Memories { get;  } = new List<Memory>();
    }
}
