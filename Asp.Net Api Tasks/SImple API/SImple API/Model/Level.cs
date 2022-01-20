using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simple_API.Model
{
    public class Level
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50), Required]
        public string Name { get; set; }


        public List<Student> Students { get; set; }
    }
}
