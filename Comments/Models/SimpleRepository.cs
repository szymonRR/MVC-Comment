using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comments.Models
{
    public class SimpleRepository
    {

        private static SimpleRepository sharedRepository = new SimpleRepository();
        private List<Comment> ComList = new List<Comment>();
        private List<Article> ArtiList = new List<Article>();
        public static SimpleRepository SharedRepository => sharedRepository;
        public SimpleRepository()
        {
            var initialCom =new[] {
            
                new Comment(1,1,"Szymon","Tralalala"),
                new Comment(2,1,"Szymon","Tralalala"),
                new Comment(3,1,"Szymon","Tralalala"),
                new Comment(4,1,"Szymon","Tralalala"),
                new Comment(5,1,"Szymon","Tralalala")
            };
            foreach(var c in initialCom)
            {
                AddCom(c);
            }
           

        }

        public IEnumerable<Comment> Comms => ComList;
        public void AddCom(Comment c) => ComList.Add(c);

    }
}
