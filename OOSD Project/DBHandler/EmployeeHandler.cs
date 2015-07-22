using MySql.Data.MySqlClient;
using OOSD_Project.DBTableClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.Database
{
    class EmployeeHandler
    {

        public static bool addEmployee(Employee em){

            //try
            //{

                DBConnector dbcon = new DBConnector();

                if (dbcon.openConnection())
                {

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO employee (employee_no, full_name, image_url, old_employee_no, employee_type, epf_no, salutation, occupation, initials, first_name, last_name, nic_no, date_issued, nationality, religion, date_of_birth, place_of_birth, married, date_of_marriage, action_status, blood_group) VALUES (N'" + em.getEmployee_no() + "', N'" + em.getFull_name() + "', N'" + em.getImg_url() + "', N'" + em.getOld_employee_no() + "', N'" + em.getEmployee_type() + "', N'" + em.getEpf_no() + "', N'" + em.getSalutation() + "', N'" + em.getOccupation() + "', N'" + em.getInitials() + "', N'" + em.getFirst_name() + "', N'" + em.getLast_name() + "', N'" + em.getNic_no() + "', '" + em.getDate_issued() + "', N'" + em.getNationality() + "', N'" + em.getReligion() + "', '" + em.getDate_of_birth() + "', N'" + em.getPlace_of_birth() + "', " + em.getMarried() + ", '" + em.getDate_of_marriage() + "', N'" + em.getAction_status() + "', N'" + em.getBlood_group() + "')";
                    cmd.Connection = dbcon.connection;
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT * FROM employee ORDER BY idemployee DESC LIMIT 1";
                    cmd.Connection = dbcon.connection;

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Employee.employee_id = int.Parse(reader.GetString(0));
                        Console.Write(Employee.employee_id);
                    }

                    reader.Close();

                    dbcon.closeConnection();

                    return true;
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


        public static bool checkEmployee(string id) {

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM employee WHERE employee_no='"+id+"'";
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();
                    cmd.Dispose();
                    dbcon.closeConnection();
                    return true;
                }
                else
                {
                    reader.Close();
                    cmd.Dispose();
                    dbcon.closeConnection();
                    return false;
                }
                
            }
            else
            {
                
                dbcon.closeConnection();
                return false;
            }
        }

        public static bool updateEmployee(Employee em) {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "UPDATE employee SET employee_no=N'" + em.getEmployee_no() + "', full_name=N'" + em.getFull_name() + "', image_url=N'" + em.getImg_url() + "', old_employee_no=N'" + em.getOld_employee_no() + "', employee_type=N'" + em.getEmployee_type() + "', epf_no=N'" + em.getEpf_no() + "', salutation=N'" + em.getSalutation() + "', occupation=N'" + em.getOccupation() + "', initials=N'" + em.getInitials() + "', first_name=N'" + em.getFirst_name() + "', last_name=N'" + em.getLast_name() + "', nic_no=N'" + em.getNic_no() + "', date_issued='" + em.getDate_issued() + "', nationality=N'" + em.getNationality() + "', religion=N'" + em.getReligion() + "', date_of_birth='" + em.getDate_of_birth() + "', place_of_birth=N'" + em.getPlace_of_birth() + "', married=" + em.getMarried() + ", date_of_marriage='" + em.getDate_of_marriage() + "', action_status=N'" + em.getAction_status() + "', blood_group=N'" + em.getBlood_group() + "' WHERE idemployee="+Employee.employee_id;
                cmd.Connection = dbcon.connection;
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                dbcon.closeConnection();

                return true;
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


        public static Employee getEmployee(){

            Employee em = new Employee();

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM employee WHERE idemployee="+Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    em.setAction_status(reader.GetString("action_status"));
                    em.setBlood_grouph(reader.GetString(""));
                    em.setDate_issued(reader.GetString(""));
                }

                reader.Close();

                dbcon.closeConnection();

                return em;
            }
            else
            {

                return null;
            }

            //}
            //catch (MySqlException e)
            //{
            //int errorcode = e.Number;
            //return false;
            //}

        }

    }
}
