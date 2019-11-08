using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comments.Models
{
    public class Comment
    {
        public int ComentId { get;  set; }
        public int ArticleId { get;  set; }
        public string Nick { get;  set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public Comment(int comentId, int articleID, string nick, string text)
        {
            ComentId = comentId;
            ArticleId = articleID;
            Nick = nick;
            Text = text;
            Date = DateTime.Now;
        }
        public Comment()
        {
            Date = DateTime.Now;
        }

    }
}
