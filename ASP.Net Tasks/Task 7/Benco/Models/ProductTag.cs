using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Benco.Models
{
    public class ProductTag
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(30)]
        public string Name { get; set; }


        public List<TagToProduct> tagToProducts { get; set; }
    }
}
