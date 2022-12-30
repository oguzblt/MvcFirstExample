using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcFirstProject.Models
{
    public class Context : DbContext
    {
        public Context():base("BlogDbConnect")
        {
            Database.SetInitializer(new Initializer());
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}