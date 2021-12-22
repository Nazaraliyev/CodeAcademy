using System.ComponentModel.DataAnnotations;

namespace Repair.Models
{
    public class tagToBlog
    {
        [Key]
        public int Id { get; set; }


        public Blog Blog { get; set; }


        public Tag Tag { get; set; }
    }
}
