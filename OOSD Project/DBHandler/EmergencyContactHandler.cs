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
    class EmergencyContactHandler
    {

        public static bool addEmergencyContact(EmergencyContact ec)
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO emergency_contact (salutation, full_name, relation, nic_no, personal_address, official_address, personal_tp, official_tp, mobile_no, employee_no, int_ext, priority, employee_idemployee) VALUES (N'" + ec.salutation + "', N'" + ec.full_name + "', N'" + ec.relation + "', '" + ec.nic_no + "', N'" + ec.personal_address + "', N'" + ec.official_address + "', N'" + ec.personal_tp + "', N'" + ec.office_tp + "', N'" + ec.mobile_no + "', N'" + ec.employee_no + "', N'" + ec.int_ext + "', N'" + ec.priority + "', " + Employee.employee_id + ")";
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


        public static EmergencyContact getEmergencyContact()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM emergency_contact WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                Console.Write(Employee.employee_id + "\n");

                EmergencyContact ec = null;

                if (reader.Read())
                {
                    ec = new EmergencyContact();

                    ec.full_name = reader["full_name"].ToString();
                    ec.int_ext = reader["int_ext"].ToString();
                    ec.mobile_no = reader["mobile_no"].ToString();
                    ec.nic_no = reader["nic_no"].ToString();
                    ec.office_tp = reader["official_tp"].ToString();
                    ec.official_address = reader["official_address"].ToString();
                    ec.personal_address = reader["personal_address"].ToString();
                    ec.personal_tp = reader["personal_tp"].ToString();
                    ec.priority = reader["priority"].ToString();
                    ec.relation = reader["relation"].ToString();
                    ec.salutation = reader["salutation"].ToString();
                    ec.employee_no = reader["employee_no"].ToString();

                }

                reader.Close();

                dbcon.closeConnection();

                return ec;
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
