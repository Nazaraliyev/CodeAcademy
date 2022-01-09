using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Benco.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50)]
        public string Name { get; set; }


        public List<Blog> blogs { get; set; }
    }
}
