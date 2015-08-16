using MySql.Data.MySqlClient;
using OOSD_Project.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOSD_Project
{
    public partial class frmNotifications : Form
    {
        private static frmNotifications form;
        public frmNotifications()
        {
            InitializeComponent();

            loadNotifications();
        }

        public static frmNotifications getForm()
        {
            if (form == null)
            {
                form = new frmNotifications();
            }
            return form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain formMain = new frmMain();
            formMain.Show();
            this.Hide();
        }



        public void loadNotifications()
        {
            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT idnotification AS Notification_ID, title AS Title, content AS Content, date AS Date, employee_name AS Employee, employee_number AS Employee_Number FROM notification WHERE date=@dt";
                cmd.Parameters.Add("@dt", MySql.Data.MySqlClient.MySqlDbType.Date).Value = DateTime.Today; 
                cmd.Connection = dbcon.connection;


                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);

                BindingSource bs = new BindingSource();
                bs.DataSource = dbdataset;
                dataGridView1.DataSource = bs;
                sda.Update(dbdataset);
                    
                dbcon.closeConnection();


            }
            else
            {
                return;
            }

            //}
            //catch (MySqlException e)
            //{
            //int errorcode = e.Number;
            //}
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Console.Write(dataGridView1.CurrentCell.RowIndex+"\n");

            if (dataGridView1.CurrentCell.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];

                not_title.Text = row.Cells["Title"].Value.ToString();
                not_emp_no.Text = row.Cells["Employee_Number"].Value.ToString();
                not_content.Text = row.Cells["Content"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


    }
}
