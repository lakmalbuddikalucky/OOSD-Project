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

            try {

                DBConnector dbcon = new DBConnector();
                dbcon.openConnection();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO employee (employee_no, full_name, image_url, old_employee_no, employee_type, epf_no, salutation, occupation, initials, first_name, last_name, nic_no, date_issued, nationality, religion, date_of_birth, place_of_birth, married, date_of_marriage, action_status, blood_group) VALUES (N'" + em.getEmployee_no() + "', N'" + em.getFull_name() + "', N'" + em.getImg_url() + "', N'" + em.getOld_employee_no() + "', N'" + em.getEmployee_type() + "', N'" + em.getEpf_no() + "', N'" + em.getSalutation() + "', N'" + em.getOccupation() + "', N'" + em.getInitials() + "', N'" + em.getFirst_name() + "', N'" + em.getLast_name() + "', N'" + em.getNic_no() + "', '" + em.getDate_issued() + "', N'" + em.getNationality() + "', N'" + em.getReligion() + "', '" + em.getDate_of_birth() + "', N'" + em.getPlace_of_birth() + "', " + em.getMarried() + ", '" + em.getDate_of_marriage() + "', N'" + em.getAction_status() + "', N'" + em.getBlood_group() + "')";
                cmd.Connection = dbcon.connection;
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                dbcon.closeConnection();

                return true;

            }
            catch (MySqlException e){
                int errorcode = e.Number;
                return false;
            }

        }

    }
}
