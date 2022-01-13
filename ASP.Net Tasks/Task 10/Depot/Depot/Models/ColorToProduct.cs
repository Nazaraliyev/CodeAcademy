using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Depot.Models
{
    public class ColorToProduct
    {
        [Key]
        public int Id { get; set; }


        [Column(TypeName = "money")]
        public decimal Price { get; set; }




        [Column(TypeName = "money")]
        public decimal Discount { get; set; }



        public DateTime DiscountTime { get; set; }



        [ForeignKey("ColorId")]
        public int ColorId { get; set; }
        public Color Color { get; set; }



        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public Product product { get; set; }


        public List<Wish> wishes { get; set; }
        public List<Material> materials { get; set; }
        public List<Cart> carts { get; set; }
        public List<ProductComment> productComments { get; set; }

    }
}
