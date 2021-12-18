﻿using System.ComponentModel.DataAnnotations;

namespace Oxu.az.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50)]
        public string Name { get; set; }



        [MaxLength(50)]
        public string Surname { get; set; }
    }
}
