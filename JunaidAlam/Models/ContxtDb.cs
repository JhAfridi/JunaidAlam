using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JunaidAlam.Models
{
    public class ContxtDb : DbContext
    {
        public ContxtDb(): base("name=ContxtDb")
        {
            //Constructor
        }

        public DbSet<Product> Products { get; set; }

    }
}