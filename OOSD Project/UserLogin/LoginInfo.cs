using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.UserLogin
{
    public static class LoginInfo
    {
        public static int sessionID = 0;
        public static string UserID = null;
        public static DateTime inTime = DateTime.MinValue;
        public static DateTime outTime = DateTime.MinValue;
        public static string computer_name = null;
        public static string ipAddress = null;
    }
}
