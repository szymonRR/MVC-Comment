using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comments.Models
{
    public class Comment
    {
        public int ComentId { get; private set; }
        public string Nick { get; private set; }
        public string Text { get; private set; }
        public DateTime Date { get; private set; }

        public Comment(int comentId, string nick, string text)
        {
            ComentId = comentId;
            Nick = nick;
            Text = text;
            Date = DateTime.Now;
        }

    }
}
