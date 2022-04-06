using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainResponsability.Request
{
    public class User
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime BirthDate { get; set; }
    }
}
