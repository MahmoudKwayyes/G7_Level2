using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Exceptions
{
    internal class LoginException:Exception
    {
        public DateTime Date { get; set; }
        public Product MyProperty { get; set; }
        public string User { get; set; }
        public LoginException(string user) : base("Faild Login")
        {
            Date = DateTime.Now;
            User = user;
        }
    }


}
