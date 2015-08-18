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
    class RemunerationHandler
    {

        public static bool addRemuneration(Remuneration r)
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO remuneration (rank, post, salary_grade, salary_slip_no, basic_salary, transport_allowance, fuel_allowance, mobile_phone_allowance, housing_allowance, other_allowance, salary_increase_date, salary_increase_amount, current_total_salary, employee_idemployee) VALUES (N'" + r.rank + "', N'" + r.post + "', N'" + r.salary_grade + "', N'" + r.salary_slip_no + "', " + r.basic_salary + ", " + r.transport_allowance + ", " + r.fuel_allowance + ", " + r.mobile_phone_allowance + ", " + r.housing_allowance + ", " + r.other_allowance + ", '" + r.getsalary_increase_date().ToString("yyyy-MM-dd") + "', " + r.salary_increase_amount + ", " + r.current_total_salary + ", " + Employee.employee_id + ")";
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


        public static Remuneration getRemuneration()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM remuneration WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                Remuneration r = null;

                if (reader.Read())
                {
                    r = new Remuneration();

                    r.r_id = int.Parse(reader["idremuneration"].ToString());
                    r.rank = reader["rank"].ToString();
                    r.post = reader["post"].ToString();
                    r.salary_grade = reader["salary_grade"].ToString();
                    r.salary_slip_no = reader["salary_slip_no"].ToString();
                    r.basic_salary = (float)Convert.ToDouble(reader["basic_salary"].ToString());
                    r.transport_allowance = (float)Convert.ToDouble(reader["transport_allowance"].ToString());
                    r.fuel_allowance = (float)Convert.ToDouble(reader["fuel_allowance"].ToString());
                    r.mobile_phone_allowance = (float)Convert.ToDouble(reader["mobile_phone_allowance"].ToString());
                    r.housing_allowance = (float)Convert.ToDouble(reader["housing_allowance"].ToString());
                    r.other_allowance = (float)Convert.ToDouble(reader["other_allowance"].ToString());
                    r.salary_increase_amount = (float)Convert.ToDouble(reader["salary_increase_amount"].ToString());
                    r.current_total_salary = (float)Convert.ToDouble(reader["current_total_salary"].ToString());


                    r.setsalary_increase_date(Convert.ToDateTime(reader["salary_increase_date"]));

                }

                reader.Close();

                dbcon.closeConnection();

                return r;
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


        public static bool updateRemuneration(Remuneration r)
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "UPDATE remuneration SET salary_grade=N'" + r.salary_grade + "', salary_slip_no=" + r.salary_slip_no + ", basic_salary=" + r.basic_salary + ", transport_allowance=" + r.transport_allowance + ", fuel_allowance=" + r.fuel_allowance + ", mobile_phone_allowance=" + r.mobile_phone_allowance + ", housing_allowance=" + r.housing_allowance + ", other_allowance=" + r.other_allowance + ", salary_increase_date='" + r.getsalary_increase_date().ToString("yyyy-MM-dd") + "', salary_increase_amount=" + r.salary_increase_amount + ", current_total_salary=" + r.current_total_salary + " WHERE employee_idemployee=" + Employee.employee_id + " AND idremuneration=" + r.r_id;
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

    }
}
