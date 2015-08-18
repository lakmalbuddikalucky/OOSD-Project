using MySql.Data.MySqlClient;
using OOSD_Project.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.UserLogin
{
    class UserHandler
    {

        public static string addUser(UserLog ul)
        {
            //Set employee_id for employee number
            ul.setEmp_id(getEmployeeID(ul.getEmp_no()));

            Console.Write("Emp id = "+ul.getEmp_id() + "\n");

            //Check whether user exists
            if (!(userExists(ul.getEmp_id())))
            {
                //try
                //{

                DBConnector dbcon = new DBConnector();

                if (dbcon.openConnection())
                {

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO user (username, password, employee_idemployee, system_status, access_level) VALUES (N'" + ul.getUsername() + "', MD5('" + ul.getPassword() + "'), " + ul.getEmp_id() + ", 1, 1)";
                    cmd.Connection = dbcon.connection;
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    dbcon.closeConnection();

                    return "success";
                }
                else
                {
                    return "";
                }

                //}
                //catch (MySqlException e)
                //{
                //int errorcode = e.Number;
                //return false;
                //}
            }
            else
            {
                return "user exists";
            }

        }



        public static string updateUser(UserLog ul)
        {
            //Set employee_id for employee number
            ul.setEmp_id(getEmployeeID(ul.getEmp_no()));

            //Check whether user exists
            if (userExists(ul.getEmp_id()))
            {
                //try
                //{

                DBConnector dbcon = new DBConnector();

                if (dbcon.openConnection())
                {

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "UPDATE user SET username=N'" + ul.getUsername() + "', password=MD5('" + ul.getPassword() + "') WHERE employee_idemployee="+ ul.getEmp_id();
                    cmd.Connection = dbcon.connection;
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    dbcon.closeConnection();

                    return "success";
                }
                else
                {
                    return "";
                }

                //}
                //catch (MySqlException e)
                //{
                //int errorcode = e.Number;
                //return false;
                //}
            }
            else
            {
                return "user does not exist";
            }

        }



        //Check whether user exists
        public static bool userExists(int no)
        {

            bool exists = false;

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM user WHERE employee_idemployee=" + no;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read())
                {
                    Console.Write("exists\n");
                    exists = true;
                }

                reader.Close();

                dbcon.closeConnection();

                return exists;
            }
            else
            {

                return false;
            }

            //}
            //catch (MySqlException e)
            //{
            //int errorcode = e.Number;
            //return false;
            //}

        }


        //get employee_id of employee
        public static int getEmployeeID(string no)
        {
            int id = 0;
            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM employee WHERE employee_no=N'" + no + "'";
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    id = int.Parse(reader["idemployee"].ToString());
                    Console.Write(id + "\n");
                }

                reader.Close();

                dbcon.closeConnection();

                return id;
            }
            else
            {

                return 0;
            }

            //}
            //catch (MySqlException e)
            //{
            //int errorcode = e.Number;
            //return 0;
            //}

        }


    }
}
