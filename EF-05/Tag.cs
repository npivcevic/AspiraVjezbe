using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05
{
    internal class Tag
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
