﻿using System.ComponentModel.DataAnnotations;

namespace Benco.Models
{
    public class SosialMedia
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50)]
        public string Name { get; set; }


        [MaxLength(50)]
        public string Icon { get; set; }



        [MaxLength(200)]
        public string Link { get; set; }
    }
}
