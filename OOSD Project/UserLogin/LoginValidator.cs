using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOSD_Project.Database;
using MySql.Data.MySqlClient;
using System.Net;

namespace OOSD_Project.UserLogin
{
    class LoginValidator
    {

        public static bool validateLogin(UserLog ul)
        {

            DBConnector dbcon = new DBConnector();
            dbcon.openConnection();

            //try {

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM user WHERE username='" + ul.getUsername() + "' AND password='" + ul.getPassword() + "'";
            cmd.Connection = dbcon.connection;

            MySqlDataReader login = cmd.ExecuteReader();

            if (login.Read())
            {
                LoginSession.setSession(login.GetString("iduser"));
                //login.Close();
                dbcon.closeConnection();
                return true;
            }
            else
            {
                //login.Close();
                dbcon.closeConnection();
                return false;
            }
            //}
            //catch (MySqlException e){
            //int errorcode = e.Number;
            //return false;
            //}

        }


    }
}
