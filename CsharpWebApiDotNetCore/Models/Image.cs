﻿using System.ComponentModel.DataAnnotations.Schema;

namespace CsharpWebApiDotNetCore.Models
{
    public class Image
    {
        public int Id { get; set; }

        public string? Url { get; set; }

        public bool IsCover { get; set; }

        //[ForeignKey("Location")]
        public int LocationId{ get; set;}
    }
}
