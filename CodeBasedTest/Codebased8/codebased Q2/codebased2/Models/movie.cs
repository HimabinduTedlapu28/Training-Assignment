using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace codebased2.Models
{
    public class movie
    {
        [Key]
        public int mid { get; set; }
        public string moviename { get; set; }
        public string dateofrelease { get; set; }
    }
}