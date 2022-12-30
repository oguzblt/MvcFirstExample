using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcFirstProject.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string BlogName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Contents { get; set; }
        public DateTime Date { get; set; }
        public bool Statu { get; set; }
        public bool HomePage { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}