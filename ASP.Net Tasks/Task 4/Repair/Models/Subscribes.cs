using System.ComponentModel.DataAnnotations;


namespace Repair.Models
{
    public class Subscribes
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(200)]
        public string Mail { get; set; }
    }
}
