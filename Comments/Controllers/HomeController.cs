using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Comments.Models;

namespace Comments.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Index");
        }
        public ViewResult Article()
        {
            Comment com1 = new Comment(1, "a", "Dupa");
            return View("ArticleView",com1);
        }
        
        
        
        
    }
}
