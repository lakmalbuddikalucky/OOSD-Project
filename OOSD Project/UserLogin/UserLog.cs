using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.UserLogin
{
    class UserLog
    {

        private string emp_no;

        public string getEmp_no()
        {
            return this.emp_no;
        }

        public void setEmp_no(string value)
        {
            this.emp_no = value;
        }


        private int emp_id;

        public int getEmp_id()
        {
            return this.emp_id;
        }

        public void setEmp_id(int value)
        {
            this.emp_id = value;
        }



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
