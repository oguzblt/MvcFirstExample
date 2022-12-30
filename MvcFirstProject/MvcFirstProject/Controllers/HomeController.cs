using MvcFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFirstProject.Controllers
{
    public class HomeController : Controller
    {
        private Context context = new Context();
        //GET: Home 
        public ActionResult Index()
        {
            var homepageblog = context.Blogs.Select(i => new BlogModel()
            {
                Id = i.Id,
                BlogName=i.BlogName,
                Description=i.Description,
                Date=i.Date,
                HomePage=i.HomePage,
                Statu=i.Statu,
                Image=i.Image

            }).Where(i => i.Statu == true && i.HomePage == true).OrderByDescending(i => i.Date);
            
            return View(homepageblog.ToList());
        }
    }
}