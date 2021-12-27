using System.ComponentModel.DataAnnotations;

namespace Starx.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }




        [MaxLength(50)]
        public string Name { get; set; }



        [MaxLength(50)]
        public string Surname { get; set; }

    }
}
