using System.ComponentModel.DataAnnotations;


namespace Repair.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(100)]
        public string Name { get; set; }


        [MaxLength(500)]
        public string Description { get; set; }
    }
}
