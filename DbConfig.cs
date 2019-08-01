using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvConfig
{
    public class DbConfig
    {
        public string Host { get; set; }
        public string port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }
        public bool Default { get; set; }
    }
}
