using System.ComponentModel.DataAnnotations;

namespace Repair.Models
{
    public class Blogimage
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50)]
        public int Path { get; set; }


        public Blog Blog { get; set; }
    }
}
