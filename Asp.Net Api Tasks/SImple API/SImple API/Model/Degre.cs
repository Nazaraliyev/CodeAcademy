using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simple_API.Model
{
    public class Degre
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50), Required]
        public string Name { get; set; }


        public List<Class> Classes  { get; set; }
    }
}
