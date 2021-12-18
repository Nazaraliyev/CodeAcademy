﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oxu.az.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(200)]
        public string Name { get; set; }



        [Column(TypeName = "ntext")]
        public string Text { get; set; }




        [MaxLength(50)]
        public string Img { get; set; }



        public DateTime CreateDate { get; set; }

        public int Watch { get; set; }

        public int Like { get; set; }

        public int Unlike { get; set; }
    }
}
