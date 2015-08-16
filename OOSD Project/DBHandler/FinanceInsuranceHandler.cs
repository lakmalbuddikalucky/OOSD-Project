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
    class FinanceInsuranceHandler
    {
        public static bool addFinanceInsurance(FinanceInsurance fi)
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO finance_insurance (type, value, begin_date, end_date, note, employee_idemployee) VALUES (N'" + fi.type + "', " + fi.value + ", '" + fi.getBegin_date().ToString("yyyy-MM-dd") + "', '" + fi.getEnd_date().ToString("yyyy-MM-dd") + "', N'" + fi.note + "', " + Employee.employee_id + ")";
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


        public static FinanceInsurance getFinanceInsurance()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM finance_insurance WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                FinanceInsurance fi = null;

                if (reader.Read())
                {
                    fi = new FinanceInsurance();

                    fi.type = reader["type"].ToString();
                    fi.value = double.Parse(reader["value"].ToString());
                    fi.note = reader["note"].ToString();

                    fi.setBegin_date(Convert.ToDateTime(reader["begin_date"]));
                    fi.setEnd_date(Convert.ToDateTime(reader["end_date"]));

                }

                reader.Close();

                dbcon.closeConnection();

                return fi;
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
