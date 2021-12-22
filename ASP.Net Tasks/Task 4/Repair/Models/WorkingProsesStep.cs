using System.ComponentModel.DataAnnotations;

namespace Repair.Models
{
    public class WorkingProsesStep
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50)]
        public string Description { get; set; }


        [MaxLength(50)]
        public string Icon { get; set; }
    }
}
