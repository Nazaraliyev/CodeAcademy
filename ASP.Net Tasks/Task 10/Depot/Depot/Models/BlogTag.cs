using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Depot.Models
{
    public class BlogTag
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50), Required]
        public string Name { get; set; }


        public List<TagToBlog> tagToBlogs { get; set; }
    }
}
