using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StartBootstrap_2_ASP.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50)]
        public string Name { get; set; }


        public List<Product> products { get; set; }
    }
}
