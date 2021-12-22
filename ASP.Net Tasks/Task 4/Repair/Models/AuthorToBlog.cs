using System.ComponentModel.DataAnnotations;

namespace Repair.Models
{
    public class AuthorToBlog
    {
        [Key]
        public int Id { get; set; }


        public Blog Blog { get; set; }


        public Author Author { get; set; }
    }
}
