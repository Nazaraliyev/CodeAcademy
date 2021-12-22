using System.ComponentModel.DataAnnotations;


namespace Repair.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(100)]
        public string Name { get; set; }
    }
}
