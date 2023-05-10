using System.ComponentModel.DataAnnotations;

namespace _1670_ASM2.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Bio { get; set; }
        //Relationships
        public List<Book> Books { get; set; }
    }
}
