using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Depot.Models
{
    public class TagToBlog
    {
        [Key]
        public int Id { get; set; }



        [ForeignKey("BlogId")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }




        [ForeignKey("BlogTagId")]
        public int BlogTagId { get; set; }
        public BlogTag BlogTag { get; set; }
    }
}
