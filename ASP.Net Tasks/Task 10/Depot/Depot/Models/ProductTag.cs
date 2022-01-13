using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Depot.Models
{
    public class ProductTag
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50), Required]
        public string Name { get; set; }


        public List<TagToProduct> tagToBlogs { get; set; }
    }
}
