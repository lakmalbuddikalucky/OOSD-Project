using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class Notification
    {
        string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        string content;
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        string employee_name;
        public string Employee_name
        {
            get { return employee_name; }
            set { employee_name = value; }
        }

        string employee_number;
        public string Employee_number
        {
            get { return employee_number; }
            set { employee_number = value; }
        }

        int employee_idemployee;
        public int Employee_idemployee
        {
            get { return employee_idemployee; }
            set { employee_idemployee = value; }
        }

        int user_iduser;
        public int User_iduser
        {
            get { return user_iduser; }
            set { user_iduser = value; }
        }
    }
}
