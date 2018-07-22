using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirket
{
    public class User
    {
        public string name { get; set; }
        public string password { get; set; }
    
        public User(string _name, string _password)
        {
            this.name = _name;
            this.password = _password;
        }
      
    }
    
}
