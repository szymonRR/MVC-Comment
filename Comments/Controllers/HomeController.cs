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
        public IActionResult Article(int? id)
        {
            ViewData["com"] = SimpleRepository.SharedRepository.Comms.Where(c => c.ArticleId==id);
            ViewBag.articleid = id;
            ViewBag.comId = SimpleRepository.SharedRepository.Comms.Count()+1;
            return View("ArticleView");
        }
        
        [HttpPost]
        public IActionResult Article(Comment com){


            Repository.AddCom(com);
            
           return RedirectToAction("Article");
        }

        
        
    }
}
