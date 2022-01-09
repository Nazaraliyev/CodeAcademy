using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class FeedBack
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50)]
        public string Name { get; set; }


        [MaxLength(1000)]
        public string Message { get; set; }


        [MaxLength(30)]
        public string Position { get; set; }
    }
}
