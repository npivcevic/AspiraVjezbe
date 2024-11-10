using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05
{
    internal class Comment
    {
        public int Id { get; set; }

        public required string Text { get; set; }

        public int PostId { get; set; }
        public Post? Post { get; set; }

        public int? AuthorId { get; set; }
        public User? Author { get; set; }
    }
}
