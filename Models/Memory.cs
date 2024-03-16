using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Memory
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Desciption123")]
        public required string Description { get; set; }
        public required DateOnly Date { get; set; }
        [Display(Name = "Author")]
        [ForeignKey("AuthorID")]
        
        public Author? Author { get; set; }
        [Display(Name = "Author_ID")]
        [Required]
        public required int AuthorID { get; set; }
    }
}
