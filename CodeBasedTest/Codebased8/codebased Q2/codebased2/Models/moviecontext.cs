using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace codebased2.Models
{
    public class moviecontext:DbContext
    {
        public moviecontext() : base( "Connectstr")
        {

        }
        public DbSet<movie> movie { get; set; }
    }
}