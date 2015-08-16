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
    class DisciplinaryDetailsHandler
    {

        public static bool addDisciplinaryDetails(DisciplinaryDetails dd)
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
                if (dbcon.openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO desciplinary_details (rank, post, breaking, request_main_admin, breaking_date, given_sentence, given_sentence_date, verdict_of_director_general, verdict_of_director_general_date, inquiry_officer, suspended_date, rejoined_date, suspended_time, employee_idemployee) VALUES (N'" + dd.rank + "', N'" + dd.post + "', N'" + dd.breaking + "', N'" + dd.request_main_admin + "', '" + dd.breaking_date.ToString("yyyy-MM-dd") + "', N'" + dd.given_sentence + "', '" + dd.given_sentence_date.ToString("yyyy-MM-dd") + "', N'" + dd.verdict_of_director_general + "', '" + dd.verdict_of_director_general_date.ToString("yyyy-MM-dd") + "', N'" + dd.inquiry_officer + "', '" + dd.suspended_date.ToString("yyyy-MM-dd") + "', '" + dd.rejoined_date.ToString("yyyy-MM-dd") + "', N'" + dd.suspended_time + "', " + Employee.employee_id + ")";
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



        public static bool addDisciplinaryDetailsRecord()
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO desciplinary_details (breaking_date, given_sentence_date, verdict_of_director_general_date, suspended_date, rejoined_date, employee_idemployee) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', " + Employee.employee_id + ")";
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




        public static bool updateDisciplinaryDetails(DisciplinaryDetails dd)
        {
            DBConnector dbcon = new DBConnector();

            //try
            //{
                if (dbcon.openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "UPDATE desciplinary_details SET rank=N'" + dd.rank + "', post=N'" + dd.post + "', breaking=N'" + dd.breaking + "', request_main_admin=N'" + dd.request_main_admin + "', breaking_date='" + dd.breaking_date.ToString("yyyy-MM-dd") + "', given_sentence=N'" + dd.given_sentence + "', given_sentence_date='" + dd.given_sentence_date.ToString("yyyy-MM-dd") + "', verdict_of_director_general=N'" + dd.verdict_of_director_general + "', verdict_of_director_general_date='" + dd.verdict_of_director_general_date.ToString("yyyy-MM-dd") + "', inquiry_officer=N'" + dd.inquiry_officer + "', suspended_date='" + dd.suspended_date.ToString("yyyy-MM-dd") + "', rejoined_date='" + dd.rejoined_date.ToString("yyyy-MM-dd") + "', suspended_time=N'" + dd.suspended_time + "' WHERE employee_idemployee=" + Employee.employee_id;
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


        public static DisciplinaryDetails getDisciplinaryDetails()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM desciplinary_details WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                Console.Write(Employee.employee_id + "\n");

                DisciplinaryDetails dd = null;

                if (reader.Read())
                {
                    dd = new DisciplinaryDetails();

                    dd.rank = reader["rank"].ToString();
                    dd.post = reader["post"].ToString();
                    dd.breaking = reader["breaking"].ToString();
                    dd.breaking_date = Convert.ToDateTime(reader["breaking_date"]);
                    dd.given_sentence = reader["given_sentence"].ToString();
                    dd.given_sentence_date = Convert.ToDateTime(reader["given_sentence_date"]);
                    dd.inquiry_officer = reader["inquiry_officer"].ToString();
                    dd.rejoined_date = Convert.ToDateTime(reader["rejoined_date"]);
                    dd.request_main_admin = reader["request_main_admin"].ToString();
                    dd.suspended_date = Convert.ToDateTime(reader["suspended_date"]);
                    dd.suspended_time = reader["suspended_time"].ToString();
                    dd.verdict_of_director_general = reader["verdict_of_director_general"].ToString();
                    dd.verdict_of_director_general_date = Convert.ToDateTime(reader["verdict_of_director_general_date"]);


                }

                reader.Close();

                dbcon.closeConnection();

                return dd;
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
