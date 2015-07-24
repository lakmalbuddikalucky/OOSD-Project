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
    class DependentDetailsHandler
    {

        public static bool addDependentDetails(DependentDetails dd)
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO dependent_details (salutation, full_name, relation, date_of_post, nic_no, personal_tp, office_tp, personal_address, official_address, education, status, note, birth_certificate, marriage_certificate, deathade, doctor, employee_idemployee) VALUES (N'" + dd.salutation + "', N'" + dd.full_name + "', N'" + dd.relation + "', '" + dd.getDate_of_post() + "', N'" + dd.nic_no + "', N'" + dd.personal_tp + "', N'" + dd.office_tp + "', N'" + dd.personal_address + "', N'" + dd.official_address + "', N'" + dd.education + "', N'" + dd.status + "', N'" + dd.note + "', N'" + dd.birth_certificate + "', N'" + dd.marriage_certificate + "', " + dd.deathade + ", " + dd.doctor + ", " + Employee.employee_id + ")";
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

            //}
            //catch (MySqlException e)
            //{
            //int errorcode = e.Number;
            //dbcon.closeConnection();
            //return false;
            //}

        }



        public static DependentDetails getDependentDetails()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM dependent_details WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                Console.Write(Employee.employee_id + "\n");

                DependentDetails dd = new DependentDetails();

                if (reader.Read())
                {

                    dd.birth_certificate = reader["birth_certificate"].ToString();

                    if (reader["deathade"].ToString() == "1") { dd.deathade = true; }
                    else { dd.deathade = false; }

                    if (reader["doctor"].ToString() == "1") { dd.doctor = true; }
                    else { dd.doctor = false; }

                    dd.full_name = reader["full_name"].ToString();
                    dd.marriage_certificate = reader["marriage_certificate"].ToString();
                    dd.nic_no = reader["nic_no"].ToString();
                    dd.note = reader["note"].ToString();
                    dd.office_tp = reader["office_tp"].ToString();
                    dd.official_address = reader["official_address"].ToString();
                    dd.personal_address = reader["personal_address"].ToString();
                    dd.personal_tp = reader["personal_tp"].ToString();
                    dd.relation = reader["relation"].ToString();
                    dd.salutation = reader["salutation"].ToString();
                    dd.status = reader["status"].ToString();
                    dd.education = reader["education"].ToString(); 
                    

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
