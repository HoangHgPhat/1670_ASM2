using System.ComponentModel.DataAnnotations;

namespace _1670_ASM2.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Bio { get; set; }
    }
}
