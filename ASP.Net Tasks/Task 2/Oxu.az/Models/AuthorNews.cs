using System.ComponentModel.DataAnnotations;

namespace Oxu.az.Models
{
    public class AuthorNews
    {
        [Key]
        public int Id { get; set; }


        public Author Author { get; set; }
        public News News { get; set; }
    }
}
