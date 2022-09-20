using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class Auth
    {
        public int AuthId { get; set; }
        public string Login { get; set; }
        public string Passwd { get; set; }
    }
}
