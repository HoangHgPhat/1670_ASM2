using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1670_ASM2.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
       
        public string FullName { get; set; }
       
        public string Bio { get; set; }

        //relationsips
        public List<Book_Author> Books_Authors { get; set; }

    }
}
