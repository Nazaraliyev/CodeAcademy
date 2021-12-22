using System.ComponentModel.DataAnnotations;

namespace Repair.Models
{
    public class BlogComment
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(100)]
        public string CommentSubject { get; set; }


        [MaxLength(1000)]
        public string Comment { get; set; }


        [MaxLength(100)]
        public string Username { get; set; }


        [MaxLength(200)]
        public string Usermail { get; set; }


        [MaxLength(50)]
        public string Usermmage { get; set; }


        public BlogComment BlogComments { get; set; }

        public Blog Blog { get; set; }
    }
}
