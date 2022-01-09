using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class TagToBlog
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("TagId")]
        public int TagId { get; set; }
        public BlogTag BlogTag { get; set; }


        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
