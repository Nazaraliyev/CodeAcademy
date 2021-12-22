using System.ComponentModel.DataAnnotations;

namespace Repair.Models
{
    public class EstimateList
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(100)]
        public string Name { get; set; }


        [MaxLength(15)]
        public string Phone { get; set; }



        [MaxLength(100)]
        public string Mail { get; set; }


        [MaxLength(500)]
        public string Message { get; set; }
    }
}
