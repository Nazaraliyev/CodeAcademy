using System.ComponentModel.DataAnnotations;

namespace SixteenClothing.Models
{
    public class Speciality
    {
        [Key]
        public int Id { get; set; }




        [MaxLength(100)]
        public string Name { get; set; }
    }
}
