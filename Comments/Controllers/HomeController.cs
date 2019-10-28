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
        
        public List<Article> GetArticleList() {
            //In futre get list from database??
            List<Article> articleList = new List<Article>();
            Article artile1 = new Article { ArticleId = 1, AutorName = "Szymon", Content = "Trallalala" };
            articleList.Add(artile1 ) ;

            return articleList;
        }

        
        
    }
}
