using System.ComponentModel.DataAnnotations;


namespace Repair.Models
{
    public class BlogCategory
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(100)]
        public string Name { get; set; }
    }
}
