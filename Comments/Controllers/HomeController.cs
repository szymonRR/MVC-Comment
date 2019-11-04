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
        SimpleRepository Repository = SimpleRepository.SharedRepository;
        public ViewResult Index()
        {

            return View("Index");
        }
        public IActionResult Article()
        {
            ViewData["com"] = SimpleRepository.SharedRepository.Comms;
            return View("ArticleView");
        }
        
        [HttpPost]
        public IActionResult Article(Comment com){
            
            
            
            
           return RedirectToAction("Article");
        }

        
        
    }
}
