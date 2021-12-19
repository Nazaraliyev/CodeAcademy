using System.ComponentModel.DataAnnotations;

namespace SixteenClothing.Models
{
    public class ContactUsAccordions
    {
        [Key]
        public int Id { get; set; }




        [MaxLength(50)]
        public string Header { get; set; }



        [MaxLength(200)]
        public string Text { get; set; }
    }
}
