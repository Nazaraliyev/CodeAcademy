using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Depot.Models
{
    public class ProductComment
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(100)]
        public string Name { get; set; }



        [MaxLength(100)]
        public string Mail { get; set; }



        [MaxLength(100)]
        public string Website { get; set; }



        [MaxLength(2000)]
        public string Content { get; set; }



        [Column(TypeName = "tinyint")]
        public byte Star  { get; set; }



        public DateTime CreatedTime { get; set; }



        [ForeignKey("ColorToProductId")]
        public int ColorToProductId { get; set; }
        public ColorToProduct colorToProduct { get; set; }



        [ForeignKey("CostumeUserId")]
        public int CostumeUserId { get; set; }
        public CostumeUser costumeUser { get; set; }



        [ForeignKey("ProductCommentId")]
        public int ProductCommentId { get; set; }
        public ProductComment productComment { get; set; }
    }
}
