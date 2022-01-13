using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Depot.Models
{
    public class BlogComment
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(100), Required]
        public string Name { get; set; }



        [MaxLength(100), Required]
        public string Mail { get; set; }



        [MaxLength(100)]
        public string Website { get; set; }



        [MaxLength(2000), Required]
        public string Content { get; set; }



        public DateTime CreatedTime { get; set; }



        [ForeignKey("BlogId")]
        public int BlogId { get; set; }
        public Blog blog { get; set; }



        [ForeignKey("CostumeUserId")]
        public int CostumeUserId { get; set; }
        public CostumeUser costumeUser { get; set; }



        [ForeignKey("BlogCommentId")]
        public int BlogCommentId { get; set; }
        public BlogComment blogComment { get; set; }
    }
}
