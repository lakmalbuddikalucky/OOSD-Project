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
    class JobStatusHandler
    {

        public static bool addJobStatus(JobStatus j)
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO job_status (rank, post,em_type, contract_started_date, contract_ended_date, probation_time, probation_started_date, probation_ended_date, probation_to_permanent_status, probation_to_permanent_date, contract_to_permanent_date, employee_idemployee) VALUES (N'" + j.rank + "', N'" + j.post + "', N'" + j.em_type + "', '" + j.contract_started_date.ToString("yyyy-MM-dd") + "', '" + j.contract_ended_date.ToString("yyyy-MM-dd") + "', N'" + j.probation_time + "', '" + j.probation_started_date.ToString("yyyy-MM-dd") + "', '" + j.probation_ended_date.ToString("yyyy-MM-dd") + "', " + j.probation_to_permanent_status + ", '" + j.probation_to_permanent_date.ToString("yyyy-MM-dd") + "', '" + j.contract_to_permanent_date.ToString("yyyy-MM-dd") + "', " + Employee.employee_id + ")";
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



        public static bool addJobStatusRecord()
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO job_status (contract_started_date, contract_ended_date, probation_started_date, probation_ended_date, probation_to_permanent_date, contract_to_permanent_date, employee_idemployee) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', " + Employee.employee_id + ")";
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




        public static bool updateJobStatus(JobStatus j)
        {
            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "UPDATE job_status SET rank=N'" + j.rank + "', post=N'" + j.post + "', em_type=N'" + j.em_type + "', contract_started_date='" + j.contract_started_date.ToString("yyyy-MM-dd") + "', contract_ended_date='" + j.contract_ended_date.ToString("yyyy-MM-dd") + "', probation_time=N'" + j.probation_time + "', probation_started_date='" + j.probation_started_date.ToString("yyyy-MM-dd") + "', probation_ended_date='" + j.probation_ended_date.ToString("yyyy-MM-dd") + "', probation_to_permanent_status=" + j.probation_to_permanent_status + ", probation_to_permanent_date='" + j.probation_to_permanent_date.ToString("yyyy-MM-dd") + "', contract_to_permanent_date='" + j.contract_to_permanent_date.ToString("yyyy-MM-dd") + "' WHERE employee_idemployee=" + Employee.employee_id;
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


        public static JobStatus getJobStatus()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM job_status WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                Console.Write(Employee.employee_id + "\n");

                JobStatus j = null;

                if (reader.Read())
                {
                    j = new JobStatus();

                    j.post = reader["post"].ToString();
                    j.rank = reader["rank"].ToString();
                    j.em_type = reader["em_type"].ToString();

                    j.probation_time = reader["probation_time"].ToString();

                    if (reader["probation_to_permanent_status"].ToString() == "True") { j.probation_to_permanent_status = true; }
                    else { j.probation_to_permanent_status = false; }

                    j.contract_started_date = Convert.ToDateTime(reader["contract_started_date"]);
                    j.contract_ended_date = Convert.ToDateTime(reader["contract_ended_date"]);
                    j.probation_started_date = Convert.ToDateTime(reader["probation_started_date"]);
                    j.probation_ended_date = Convert.ToDateTime(reader["probation_ended_date"]);
                    j.probation_to_permanent_date = Convert.ToDateTime(reader["probation_to_permanent_date"]);
                    j.contract_to_permanent_date = Convert.ToDateTime(reader["contract_to_permanent_date"]);

                }

                reader.Close();

                dbcon.closeConnection();

                return j;
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
