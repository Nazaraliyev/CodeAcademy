using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(100)]
        public string Name { get; set; }


        [MaxLength(1000)]
        public string ProductIndo { get; set; }



        [ForeignKey("BrendId")]
        public int BrendId { get; set; }
        public Brend Brend { get; set; }



        [ForeignKey("CategoryId")]
        public int Categoryid { get; set; }
        public ProductCategory productCategory { get; set; }



        [Column(TypeName = "ntext")]
        public string Description { get; set; }


        public DateTime CreatedTime { get; set; }


        public int SellCount { get; set; }



        public List<Favourite> favourites { get; set; }
        public List<ColorToProduct> colorToProducts { get; set; }
        public List<TagToProduct> tagToProducts { get; set; }
        public List<Images> images { get; set; }
        public List<Reviews> reviews { get; set; }
        public List<Cart> carts { get; set; }
        
        
        
    }
}
