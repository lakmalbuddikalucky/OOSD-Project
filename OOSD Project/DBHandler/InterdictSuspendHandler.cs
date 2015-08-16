using MySql.Data.MySqlClient;
using OOSD_Project.Database;
using OOSD_Project.DBTableClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBHandler
{
    class InterdictSuspendHandler
    {

        public static bool addInterdictSuspend(InterdictSuspend s)
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO interdict_suspend (post, rank, reason, unattended_from, unattended_to, rejoined, suspend_from, suspend_to, more_notes, employee_idemployee) VALUES (N'" + s.post + "', N'" + s.rank + "', N'" + s.reason + "', '" + s.unattended_from.ToString("yyyy-MM-dd") + "', N'" + s.unattended_to.ToString("yyyy-MM-dd") + "', " + s.rejoined + ", '" + s.suspend_from.ToString("yyyy-MM-dd") + "', '" + s.suspend_to.ToString("yyyy-MM-dd") + "', N'" + s.more_notes + "', " + Employee.employee_id + ")";
                cmd.Connection = dbcon.connection;
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                dbcon.closeConnection();
                return true;
            }
            else
            {
                dbcon.closeConnection();
                return false;
            }

            /*}
            catch (MySqlException e)
            {
                int errorcode = e.Number;
                dbcon.closeConnection();
                return false;
            }*/


        }



        public static bool addInterdictSuspendRecord()
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO interdict_suspend (unattended_from, unattended_to, suspend_from, suspend_to, employee_idemployee) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', " + Employee.employee_id + ")";
                cmd.Connection = dbcon.connection;
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                dbcon.closeConnection();
                return true;
            }
            else
            {
                dbcon.closeConnection();
                return false;
            }

            /*}
            catch (MySqlException e)
            {
                int errorcode = e.Number;
                dbcon.closeConnection();
                return false;
            }*/


        }




        public static bool updateInterdictSuspend(InterdictSuspend s)
        {
            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "UPDATE interdict_suspend SET post=N'" + s.post + "', rank=N'" + s.rank + "', reason=N'" + s.reason + "', unattended_from='" + s.unattended_from.ToString("yyyy-MM-dd") + "', unattended_to=N'" + s.unattended_to.ToString("yyyy-MM-dd") + "', rejoined=" + s.rejoined + ", suspend_from='" + s.suspend_from.ToString("yyyy-MM-dd") + "', suspend_to='" + s.suspend_to.ToString("yyyy-MM-dd") + "', more_notes='" + s.more_notes + "' WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                dbcon.closeConnection();

                return true;
            }
            else
            {
                dbcon.closeConnection();
                return false;
            }

            /*}
            catch (MySqlException e)
            {
                int errorcode = e.Number;
                dbcon.closeConnection();
                return false;
            }*/

        }


        public static InterdictSuspend getInterdictSuspend()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM interdict_suspend WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                Console.Write(Employee.employee_id + "\n");

                InterdictSuspend s = null;

                if (reader.Read())
                {
                    s = new InterdictSuspend();

                    s.post = reader["post"].ToString();
                    s.rank = reader["rank"].ToString();
                    s.reason = reader["reason"].ToString();
                    s.more_notes = reader["more_notes"].ToString();
                    s.unattended_from = Convert.ToDateTime(reader["unattended_from"]);
                    s.unattended_to = Convert.ToDateTime(reader["unattended_to"]);
                    s.suspend_from = Convert.ToDateTime(reader["suspend_from"]);
                    s.suspend_to = Convert.ToDateTime(reader["suspend_to"]);

                    if (reader["rejoined"].ToString() == "True") { s.rejoined = true; }
                    else { s.rejoined = false; }


                }

                reader.Close();

                dbcon.closeConnection();

                return s;
            }
            else
            {

                return null;
            }

            //}
            //catch (MySqlException e)
            //{
            //int errorcode = e.Number;
            //return null;
            //}

        }

    }
}
