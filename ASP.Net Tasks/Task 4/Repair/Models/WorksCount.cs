using System.ComponentModel.DataAnnotations;


namespace Repair.Models
{
    public class WorksCount
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50)]
        public string Name { get; set; }


        public int Count { get; set; }
    }
}
