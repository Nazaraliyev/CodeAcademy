using System.ComponentModel.DataAnnotations;

namespace Sync_OnePage_Template_Asp.Net.Models
{
    public class Description
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50)]
        public string Name { get; set; }



        [MaxLength(50)]
        public string NameIcon { get; set; }



        [MaxLength(1000)]
        public string Content { get; set; }
    }
}
