using System.ComponentModel.DataAnnotations;

namespace Starx.Models
{
    public class CategoyToService
    {
        [Key]
        public int Id { get; set; }



        public Category Category { get; set; }



        public Service Service { get; set; }

    }
}
