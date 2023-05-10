using _1670_ASM2.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1670_ASM2.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
         
        public string BookCoverURL { get; set; }
        
        public BookGenre Genre { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Author { get; set; }

        //Relationships
        public List<Book_Author> Books_Authors { get; set; }

        public int PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }
    }
}
