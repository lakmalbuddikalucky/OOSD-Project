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
    class ContactDetailsHandler
    {

        public static bool addContactDetails(ContactDetails cd)
        {
            DBConnector dbcon = new DBConnector();

            try
            {                
                if (dbcon.openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO contact_details (perm_home_no, perm_address, perm_city, perm_province, perm_district, perm_uc, perm_grama, perm_polling_division, perm_teleophone, perm_mobile, perm_fax, perm_email, cur_home_no, cur_address, cur_city, cur_province, cur_uc, cur_grama, cur_polling_division, cur_teleophone, cur_mobile, cur_fax, cur_email, employee_idemployee) VALUES (N'" + cd.perm_home_no + "', N'" + cd.perm_address + "', N'" + cd.perm_city + "', N'" + cd.perm_province + "', N'" + cd.perm_district + "', N'" + cd.perm_uc + "', N'" + cd.perm_grama + "', N'" + cd.perm_polling_division + "', N'" + cd.perm_teleophone + "', N'" + cd.perm_mobile + "', N'" + cd.perm_fax + "', N'" + cd.perm_email + "', N'" + cd.cur_home_no + "', N'" + cd.cur_address + "', N'" + cd.cur_city + "', N'" + cd.cur_province + "', N'" + cd.cur_uc + "', N'" + cd.cur_grama + "', N'" + cd.cur_polling_division + "', N'" + cd.cur_teleophone + "', N'" + cd.cur_mobile + "', N'" + cd.cur_fax + "', N'" + cd.cur_email + "', " + Employee.employee_id + ")";
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

            }catch (MySqlException e)
            {
                int errorcode = e.Number;
                dbcon.closeConnection();
                return false;
            }

        }

    }
}
