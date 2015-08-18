using MySql.Data.MySqlClient;
using OOSD_Project.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.UserLogin
{
    class LoginSession
    {

        public static void setSession(string userid){

            LoginInfo.UserID = userid;
            LoginInfo.inTime = DateTime.Now;
            LoginInfo.computer_name = Environment.MachineName;
            LoginInfo.ipAddress = Dns.GetHostAddresses(Environment.MachineName)[0].ToString();

            DBConnector dbcon = new DBConnector();
            dbcon.openConnection();

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "INSERT INTO login_session (in_time, computer_name, ip_address, user_iduser) VALUES ('" + LoginInfo.inTime.ToString("yyyy-MM-dd HH:mm:ss") + "', N'" + LoginInfo.computer_name + "', '" + LoginInfo.ipAddress + "', "+int.Parse(LoginInfo.UserID)+")";
            cmd.Connection = dbcon.connection;
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT * FROM login_session ORDER BY idlogin_session DESC LIMIT 1";
            cmd.Connection = dbcon.connection;

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                LoginInfo.sessionID = int.Parse(reader.GetString(0));
                //Console.Write(LoginInfo.sessionID);
            }

            dbcon.closeConnection();


        }

        public static void expireSession(string userid)
        {

            LoginInfo.outTime = DateTime.Now;

            DBConnector dbcon = new DBConnector();
            dbcon.openConnection();

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "UPDATE login_session SET out_time='" + LoginInfo.outTime.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE idlogin_session=" + LoginInfo.sessionID + "";
            cmd.Connection = dbcon.connection;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            dbcon.closeConnection();

            LoginInfo.UserID = null;
            LoginInfo.inTime = DateTime.MinValue;
            LoginInfo.outTime = DateTime.MinValue;
            LoginInfo.computer_name = null;
            LoginInfo.ipAddress = null;

        }

    }
}
