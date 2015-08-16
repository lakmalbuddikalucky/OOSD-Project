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
    class ReAppointmentHandler
    {

        public static bool addReAppointment(ReAppointment ra)
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO reappointment (rank, post, suspension__system, suspension_reason, suspension_approved_note, rejoining_date, notes, employee_idemployee) VALUES (N'" + ra.rank + "', N'" + ra.post + "', N'" + ra.suspension__system + "', N'" + ra.suspension_reason + "', N'" + ra.suspension_approved_note + "', '" + ra.rejoining_date.ToString("yyyy-MM-dd") + "', N'" + ra.notes + "', " + Employee.employee_id + ")";
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



        public static bool addReAppointmentRecord()
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO reappointment (rejoining_date, employee_idemployee) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd") + "', " + Employee.employee_id + ")";
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




        public static bool updateReAppointment(ReAppointment ra)
        {
            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "UPDATE reappointment SET rank=N'" + ra.rank + "', post=N'" + ra.post + "', suspension__system=N'" + ra.suspension__system + "', suspension_reason=N'" + ra.suspension_reason + "', suspension_approved_note=N'" + ra.suspension_approved_note + "', rejoining_date='" + ra.rejoining_date.ToString("yyyy-MM-dd") + "', notes=N'" + ra.notes + "' WHERE employee_idemployee=" + Employee.employee_id;
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


        public static ReAppointment getReAppointment()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM reappointment WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                Console.Write(Employee.employee_id + "\n");

                ReAppointment ra = null;

                if (reader.Read())
                {
                    ra = new ReAppointment();

                    ra.post = reader["post"].ToString();
                    ra.rank = reader["rank"].ToString();
                    ra.notes = reader["notes"].ToString();
                    ra.suspension__system = reader["suspension__system"].ToString();
                    ra.suspension_approved_note = reader["suspension_approved_note"].ToString();
                    ra.suspension_reason = reader["suspension_reason"].ToString();

                    ra.rejoining_date = Convert.ToDateTime(reader["rejoining_date"]);
                    
                }

                reader.Close();

                dbcon.closeConnection();

                return ra;
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
