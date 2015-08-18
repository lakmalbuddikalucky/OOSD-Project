namespace OOSD_Project
{
    partial class frmTraining
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraining));
            this.training_employee_no = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.training_full_name = new System.Windows.Forms.TextBox();
            this.training_course_name = new System.Windows.Forms.TextBox();
            this.training_course_type = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.training_extended_days = new System.Windows.Forms.TextBox();
            this.training_institute = new System.Windows.Forms.TextBox();
            this.training_result = new System.Windows.Forms.TextBox();
            this.training_payments = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.full_name = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.employee_no = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.training_new_ending_date = new System.Windows.Forms.DateTimePicker();
            this.training_ending_date = new System.Windows.Forms.DateTimePicker();
            this.training_started_date = new System.Windows.Forms.DateTimePicker();
            this.btnCheckTrainingDetails = new System.Windows.Forms.Button();
            this.erp_training_ending_date = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp_training_new_ending_date = new System.Windows.Forms.ErrorProvider(this.components);
            this.training_country = new System.Windows.Forms.ComboBox();
            this.erp_training_started_date = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_training_ending_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_training_new_ending_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_training_started_date)).BeginInit();
            this.SuspendLayout();
            // 
            // training_employee_no
            // 
            this.training_employee_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.training_employee_no.FormattingEnabled = true;
            this.training_employee_no.Location = new System.Drawing.Point(475, 76);
            this.training_employee_no.Name = "training_employee_no";
            this.training_employee_no.Size = new System.Drawing.Size(200, 32);
            this.training_employee_no.TabIndex = 1;
            this.training_employee_no.SelectedIndexChanged += new System.EventHandler(this.training_employee_no_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(826, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 26);
            this.label4.TabIndex = 55;
            this.label4.Text = "නව අවසන් දිනය";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(861, 312);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 26);
            this.label17.TabIndex = 60;
            this.label17.Text = "අවසන් දිනය";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(313, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 26);
            this.label11.TabIndex = 58;
            this.label11.Text = "ආරම්භ කළ දිනය";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(385, 430);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 26);
            this.label16.TabIndex = 59;
            this.label16.Text = "ප්‍රතිපලය";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(362, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 62;
            this.label1.Text = "ගෙවීම්";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(435, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 26);
            this.label10.TabIndex = 61;
            this.label10.Text = "රු.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(581, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 26);
            this.label2.TabIndex = 63;
            this.label2.Text = "දින";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(369, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 26);
            this.label12.TabIndex = 56;
            this.label12.Text = "දීර්ග කීරීම";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(320, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 26);
            this.label15.TabIndex = 57;
            this.label15.Text = "පාඨමාලාවේ නම";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(321, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 26);
            this.label8.TabIndex = 54;
            this.label8.Text = "පාඨමාලා වර්ගය";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(432, 391);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 26);
            this.label14.TabIndex = 53;
            this.label14.Text = "රට";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(376, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 26);
            this.label9.TabIndex = 52;
            this.label9.Text = "ආයතනය";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // training_full_name
            // 
            this.training_full_name.Enabled = false;
            this.training_full_name.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.training_full_name.Location = new System.Drawing.Point(475, 114);
            this.training_full_name.Name = "training_full_name";
            this.training_full_name.Size = new System.Drawing.Size(250, 33);
            this.training_full_name.TabIndex = 2;
            // 
            // training_course_name
            // 
            this.training_course_name.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.training_course_name.Location = new System.Drawing.Point(475, 153);
            this.training_course_name.Name = "training_course_name";
            this.training_course_name.Size = new System.Drawing.Size(150, 33);
            this.training_course_name.TabIndex = 3;
            this.training_course_name.TextChanged += new System.EventHandler(this.training_course_name_TextChanged);
            // 
            // training_course_type
            // 
            this.training_course_type.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.training_course_type.Location = new System.Drawing.Point(475, 192);
            this.training_course_type.Name = "training_course_type";
            this.training_course_type.Size = new System.Drawing.Size(150, 33);
            this.training_course_type.TabIndex = 4;
            this.training_course_type.TextChanged += new System.EventHandler(this.training_course_type_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(345, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 26);
            this.label13.TabIndex = 51;
            this.label13.Text = "සම්පූර්ණ නම";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(342, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 26);
            this.label7.TabIndex = 50;
            this.label7.Text = "සේවක අංකය";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // training_extended_days
            // 
            this.training_extended_days.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.training_extended_days.Location = new System.Drawing.Point(475, 349);
            this.training_extended_days.Name = "training_extended_days";
            this.training_extended_days.Size = new System.Drawing.Size(100, 33);
            this.training_extended_days.TabIndex = 13;
            this.training_extended_days.TextChanged += new System.EventHandler(this.training_extended_days_TextChanged);
            this.training_extended_days.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.training_extended_days_KeyPress);
            // 
            // training_institute
            // 
            this.training_institute.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.training_institute.Location = new System.Drawing.Point(475, 231);
            this.training_institute.Name = "training_institute";
            this.training_institute.Size = new System.Drawing.Size(150, 33);
            this.training_institute.TabIndex = 5;
            this.training_institute.TextChanged += new System.EventHandler(this.training_institute_TextChanged);
            // 
            // training_result
            // 
            this.training_result.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.training_result.Location = new System.Drawing.Point(475, 427);
            this.training_result.Name = "training_result";
            this.training_result.Size = new System.Drawing.Size(150, 33);
            this.training_result.TabIndex = 18;
            // 
            // training_payments
            // 
            this.training_payments.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.training_payments.Location = new System.Drawing.Point(475, 270);
            this.training_payments.Name = "training_payments";
            this.training_payments.Size = new System.Drawing.Size(150, 33);
            this.training_payments.TabIndex = 6;
            this.training_payments.TextChanged += new System.EventHandler(this.training_payments_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 681);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 60);
            this.panel2.TabIndex = 49;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1184, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "තැන්පතු කරන්න ";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Teal;
            this.label35.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.LightGray;
            this.label35.Location = new System.Drawing.Point(2, 8);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(168, 45);
            this.label35.TabIndex = 41;
            this.label35.Text = "Employee";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 708);
            this.panel3.TabIndex = 48;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.full_name);
            this.panel4.Controls.Add(this.label33);
            this.panel4.Controls.Add(this.employee_no);
            this.panel4.Controls.Add(this.label34);
            this.panel4.Location = new System.Drawing.Point(8, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 606);
            this.panel4.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // full_name
            // 
            this.full_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_name.Location = new System.Drawing.Point(14, 355);
            this.full_name.Name = "full_name";
            this.full_name.Size = new System.Drawing.Size(250, 29);
            this.full_name.TabIndex = 4;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(14, 249);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(110, 24);
            this.label33.TabIndex = 1;
            this.label33.Text = "සේවක අංකය";
            // 
            // employee_no
            // 
            this.employee_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_no.FormattingEnabled = true;
            this.employee_no.Location = new System.Drawing.Point(18, 276);
            this.employee_no.Name = "employee_no";
            this.employee_no.Size = new System.Drawing.Size(150, 32);
            this.employee_no.TabIndex = 5;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(14, 323);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(109, 24);
            this.label34.TabIndex = 3;
            this.label34.Text = "සම්පූර්ණ නම";
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.Color.Teal;
            this.lblCaption.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.MintCream;
            this.lblCaption.Location = new System.Drawing.Point(1, -1);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Padding = new System.Windows.Forms.Padding(40, 8, 0, 0);
            this.lblCaption.Size = new System.Drawing.Size(1366, 60);
            this.lblCaption.TabIndex = 35;
            this.lblCaption.Text = "               Training";
            // 
            // training_new_ending_date
            // 
            this.training_new_ending_date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.training_new_ending_date.Location = new System.Drawing.Point(978, 349);
            this.training_new_ending_date.Name = "training_new_ending_date";
            this.training_new_ending_date.Size = new System.Drawing.Size(297, 31);
            this.training_new_ending_date.TabIndex = 155;
            this.training_new_ending_date.ValueChanged += new System.EventHandler(this.training_new_ending_date_ValueChanged);
            // 
            // training_ending_date
            // 
            this.training_ending_date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.training_ending_date.Location = new System.Drawing.Point(978, 311);
            this.training_ending_date.Name = "training_ending_date";
            this.training_ending_date.Size = new System.Drawing.Size(297, 31);
            this.training_ending_date.TabIndex = 156;
            this.training_ending_date.ValueChanged += new System.EventHandler(this.training_ending_date_ValueChanged);
            // 
            // training_started_date
            // 
            this.training_started_date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.training_started_date.Location = new System.Drawing.Point(475, 311);
            this.training_started_date.Name = "training_started_date";
            this.training_started_date.Size = new System.Drawing.Size(297, 31);
            this.training_started_date.TabIndex = 157;
            this.training_started_date.ValueChanged += new System.EventHandler(this.training_started_date_ValueChanged);
            // 
            // btnCheckTrainingDetails
            // 
            this.btnCheckTrainingDetails.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckTrainingDetails.ForeColor = System.Drawing.Color.Black;
            this.btnCheckTrainingDetails.Location = new System.Drawing.Point(475, 466);
            this.btnCheckTrainingDetails.Name = "btnCheckTrainingDetails";
            this.btnCheckTrainingDetails.Size = new System.Drawing.Size(75, 33);
            this.btnCheckTrainingDetails.TabIndex = 158;
            this.btnCheckTrainingDetails.Text = "Check";
            this.btnCheckTrainingDetails.UseVisualStyleBackColor = true;
            this.btnCheckTrainingDetails.Click += new System.EventHandler(this.btnCheckTrainingDetails_Click);
            // 
            // erp_training_ending_date
            // 
            this.erp_training_ending_date.ContainerControl = this;
            // 
            // erp_training_new_ending_date
            // 
            this.erp_training_new_ending_date.ContainerControl = this;
            // 
            // training_country
            // 
            this.training_country.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.training_country.FormattingEnabled = true;
            this.training_country.Items.AddRange(new object[] {
            "Afghanistan",
            " Albania",
            " Algeria",
            " Andorra",
            " Angola",
            " Antigua & Deps",
            " Argentina",
            " Armenia",
            " Australia",
            " Austria",
            " Azerbaijan",
            " Bahamas",
            " Bahrain",
            " Bangladesh",
            " Barbados",
            " Belarus",
            " Belgium",
            " Belize",
            " Benin",
            " Bhutan",
            " Bolivia",
            " Bosnia Herzegovina",
            " Botswana",
            " Brazil",
            " Brunei",
            " Bulgaria",
            " Burkina",
            " Burundi",
            " Cambodia",
            " Cameroon",
            " Canada",
            " Cape Verde",
            " Central African Rep",
            " Chad",
            " Chile",
            " China",
            " Colombia",
            " Comoros",
            " Congo",
            " Congo {Democratic Rep}",
            " Costa Rica",
            " Croatia",
            " Cuba",
            " Cyprus",
            " Czech Republic",
            " Denmark",
            " Djibouti",
            " Dominica",
            " Dominican Republic",
            " East Timor",
            " Ecuador",
            " Egypt",
            " El Salvador",
            " Equatorial Guinea",
            " Eritrea",
            " Estonia",
            " Ethiopia",
            " Fiji",
            " Finland",
            " France",
            " Gabon",
            " Gambia",
            " Georgia",
            " Germany",
            " Ghana",
            " Greece",
            " Grenada",
            " Guatemala",
            " Guinea",
            " Guinea-Bissau",
            " Guyana",
            " Haiti",
            " Honduras",
            " Hungary",
            " Iceland",
            " India",
            " Indonesia",
            " Iran",
            " Iraq",
            " Ireland {Republic}",
            " Israel",
            " Italy",
            " Ivory Coast",
            " Jamaica",
            " Japan",
            " Jordan",
            " Kazakhstan",
            " Kenya",
            " Kiribati",
            " Korea North",
            " Korea South",
            " Kosovo",
            " Kuwait",
            " Kyrgyzstan",
            " Laos",
            " Latvia",
            " Lebanon",
            " Lesotho",
            " Liberia",
            " Libya",
            " Liechtenstein",
            " Lithuania",
            " Luxembourg",
            " Macedonia",
            " Madagascar",
            " Malawi",
            " Malaysia",
            " Maldives",
            " Mali",
            " Malta",
            " Marshall Islands",
            " Mauritania",
            " Mauritius",
            " Mexico",
            " Micronesia",
            " Moldova",
            " Monaco",
            " Mongolia",
            " Montenegro",
            " Morocco",
            " Mozambique",
            " Myanmar, {Burma}",
            " Namibia",
            " Nauru",
            " Nepal",
            " Netherlands",
            " New Zealand",
            " Nicaragua",
            " Niger",
            " Nigeria",
            " Norway",
            " Oman",
            " Pakistan",
            " Palau",
            " Panama",
            " Papua New Guinea",
            " Paraguay",
            " Peru",
            " Philippines",
            " Poland",
            " Portugal",
            " Qatar",
            " Romania",
            " Russian Federation",
            " Rwanda",
            " St Kitts & Nevis",
            " St Lucia",
            " Saint Vincent & the Grenadines",
            " Samoa",
            " San Marino",
            " Sao Tome & Principe",
            " Saudi Arabia",
            " Senegal",
            " Serbia",
            " Seychelles",
            " Sierra Leone",
            " Singapore",
            " Slovakia",
            " Slovenia",
            " Solomon Islands",
            " Somalia",
            " South Africa",
            " South Sudan",
            " Spain",
            " Sri Lanka",
            " Sudan",
            " Suriname",
            " Swaziland",
            " Sweden",
            " Switzerland",
            " Syria",
            " Taiwan",
            " Tajikistan",
            " Tanzania",
            " Thailand",
            " Togo",
            " Tonga",
            " Trinidad & Tobago",
            " Tunisia",
            " Turkey",
            " Turkmenistan",
            " Tuvalu",
            " Uganda",
            " Ukraine",
            " United Arab Emirates",
            " United Kingdom",
            " United States",
            " Uruguay",
            " Uzbekistan",
            " Vanuatu",
            " Vatican City",
            " Venezuela",
            " Vietnam",
            " Yemen",
            " Zambia",
            " Zimbabwe"});
            this.training_country.Location = new System.Drawing.Point(475, 390);
            this.training_country.Name = "training_country";
            this.training_country.Size = new System.Drawing.Size(150, 31);
            this.training_country.TabIndex = 159;
            this.training_country.SelectedIndexChanged += new System.EventHandler(this.training_country_SelectedIndexChanged);
            // 
            // erp_training_started_date
            // 
            this.erp_training_started_date.ContainerControl = this;
            // 
            // frmTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 741);
            this.Controls.Add(this.training_country);
            this.Controls.Add(this.btnCheckTrainingDetails);
            this.Controls.Add(this.training_started_date);
            this.Controls.Add(this.training_ending_date);
            this.Controls.Add(this.training_new_ending_date);
            this.Controls.Add(this.training_employee_no);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.training_full_name);
            this.Controls.Add(this.training_course_name);
            this.Controls.Add(this.training_course_type);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.training_extended_days);
            this.Controls.Add(this.training_institute);
            this.Controls.Add(this.training_result);
            this.Controls.Add(this.training_payments);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTraining";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_training_ending_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_training_new_ending_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_training_started_date)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox training_employee_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox training_full_name;
        private System.Windows.Forms.TextBox training_course_name;
        private System.Windows.Forms.TextBox training_course_type;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox training_extended_days;
        private System.Windows.Forms.TextBox training_institute;
        private System.Windows.Forms.TextBox training_result;
        private System.Windows.Forms.TextBox training_payments;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox full_name;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox employee_no;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.DateTimePicker training_new_ending_date;
        private System.Windows.Forms.DateTimePicker training_ending_date;
        private System.Windows.Forms.DateTimePicker training_started_date;
        private System.Windows.Forms.Button btnCheckTrainingDetails;
        private System.Windows.Forms.ErrorProvider erp_training_ending_date;
        private System.Windows.Forms.ErrorProvider erp_training_new_ending_date;
        private System.Windows.Forms.ComboBox training_country;
        private System.Windows.Forms.ErrorProvider erp_training_started_date;
    }
}