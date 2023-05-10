using _1670_ASM2.Data;
using System.ComponentModel.DataAnnotations;

namespace _1670_ASM2.Models
{
    public class Book
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required] public string BookCoverURL { get; set; }
        [Required]
        public BookGenre Genre { get; set; }
        [Required] 
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public string Author { get; set; }

        //Relationships
        public List<Book_Author> Books_Authors { get; set; }

    }
}
