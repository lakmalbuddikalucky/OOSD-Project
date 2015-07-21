using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.UserLogin
{
    class UserLog
    {
        private string username;

        public string getUsername() { 
            return this.username; 
        }

        public void setUsername(string value)
        { 
            this.username = value; 
        }
        

        string password;

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string value)
        {
            this.password = value;
        }
    }
}
