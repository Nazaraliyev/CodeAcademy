using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Depot.Models
{
    public class BlogImage
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(250)]
        public string Name { get; set; }



        [NotMapped]
        public IFormFile ImageFile { get; set; }



        [ForeignKey("BlogId")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
