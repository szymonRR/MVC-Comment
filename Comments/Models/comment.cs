using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comments.Models
{
    public class Comment
    {
        public int ComentId { get; private set; }
        public int ArticleId { get; private set; }
        public string Nick { get; private set; }
        public string Text { get; private set; }
        public DateTime Date { get; private set; }

        public Comment(int comentId, int articleID, string nick, string text)
        {
            ComentId = comentId;
            ArticleId = articleID;
            Nick = nick;
            Text = text;
            Date = DateTime.Now;
        }

    }
}
