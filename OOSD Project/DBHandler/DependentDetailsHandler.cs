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

        public static bool addDependentDetails(DependentDetails dd) {

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

    }
}
