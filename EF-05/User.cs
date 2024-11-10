using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05
{
    internal class User
    {
        public int Id { get; set; }

        public required string Username { get; set; }

        public required string Email { get; set; }
    }
}
