using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05
{
    internal class Post
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }

        public int AuthorId { get; set; }
        public User? Author { get; set; }

        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
    }
}
