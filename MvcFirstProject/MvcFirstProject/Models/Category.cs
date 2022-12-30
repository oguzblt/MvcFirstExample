using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcFirstProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<Blog> Blogs { get; set; }

    }
}