using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Depot.Models
{
    public class BlogCategory
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50), Required]
        public string Name { get; set; }


        public List<Blog> blog { get; set; }
    }
}
