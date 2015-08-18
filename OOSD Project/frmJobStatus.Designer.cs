namespace OOSD_Project
{
    partial class frmJobStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobStatus));
            this.job_employee_no = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.job_full_name = new System.Windows.Forms.TextBox();
            this.job_post = new System.Windows.Forms.TextBox();
            this.job_rank = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.full_name = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.employee_no = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.job_probation_to_permanent_status = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.job_employee_type = new System.Windows.Forms.ComboBox();
            this.job_probation_time = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.job_contract_to_permanent_started_date = new System.Windows.Forms.DateTimePicker();
            this.job_probation_to_permanent_started_date = new System.Windows.Forms.DateTimePicker();
            this.job_probation_ended_date = new System.Windows.Forms.DateTimePicker();
            this.job_probation_started_date = new System.Windows.Forms.DateTimePicker();
            this.job_contract_ended_date = new System.Windows.Forms.DateTimePicker();
            this.job_contract_started_date = new System.Windows.Forms.DateTimePicker();
            this.erp_job_contract_started_date = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp_job_contract_ended_date = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp_job_probation_started_date = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp_job_probation_ended_date = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp_job_probation_to_permanent_started_date = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp_job_contract_to_permanent_started_date = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCheckJobStatusDetails = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp_job_contract_started_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_job_contract_ended_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_job_probation_started_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_job_probation_ended_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_job_probation_to_permanent_started_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_job_contract_to_permanent_started_date)).BeginInit();
            this.SuspendLayout();
            // 
            // job_employee_no
            // 
            this.job_employee_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_employee_no.FormattingEnabled = true;
            this.job_employee_no.Location = new System.Drawing.Point(643, 96);
            this.job_employee_no.Name = "job_employee_no";
            this.job_employee_no.Size = new System.Drawing.Size(200, 32);
            this.job_employee_no.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(352, 542);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(285, 26);
            this.label11.TabIndex = 126;
            this.label11.Text = "පරිවාස කාලයේ සිට ස්ථිර වූ දිනය";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(324, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 26);
            this.label1.TabIndex = 127;
            this.label1.Text = "කොන්ත්‍රාත් කාලය ආරම්භ කළ දිනය";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(562, 176);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 26);
            this.label15.TabIndex = 125;
            this.label15.Text = "තනතුර";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(581, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 26);
            this.label8.TabIndex = 123;
            this.label8.Text = "නිලය";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(394, 384);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(243, 26);
            this.label14.TabIndex = 121;
            this.label14.Text = "පරිවාස කාලය ආරම්භ දිනය";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(507, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 26);
            this.label9.TabIndex = 120;
            this.label9.Text = "සේවක වර්ගය";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // job_full_name
            // 
            this.job_full_name.Enabled = false;
            this.job_full_name.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.job_full_name.Location = new System.Drawing.Point(643, 134);
            this.job_full_name.Name = "job_full_name";
            this.job_full_name.Size = new System.Drawing.Size(300, 33);
            this.job_full_name.TabIndex = 2;
            // 
            // job_post
            // 
            this.job_post.Enabled = false;
            this.job_post.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.job_post.Location = new System.Drawing.Point(643, 173);
            this.job_post.Name = "job_post";
            this.job_post.Size = new System.Drawing.Size(150, 33);
            this.job_post.TabIndex = 3;
            // 
            // job_rank
            // 
            this.job_rank.Enabled = false;
            this.job_rank.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.job_rank.Location = new System.Drawing.Point(643, 212);
            this.job_rank.Name = "job_rank";
            this.job_rank.Size = new System.Drawing.Size(150, 33);
            this.job_rank.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(513, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 26);
            this.label13.TabIndex = 119;
            this.label13.Text = "සම්පූර්ණ නම";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(510, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 26);
            this.label7.TabIndex = 118;
            this.label7.Text = "සේවක අංකය";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Teal;
            this.label35.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.LightGray;
            this.label35.Location = new System.Drawing.Point(-3, 9);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(168, 45);
            this.label35.TabIndex = 115;
            this.label35.Text = "Employee";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 681);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 60);
            this.panel2.TabIndex = 117;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.full_name);
            this.panel4.Controls.Add(this.label33);
            this.panel4.Controls.Add(this.employee_no);
            this.panel4.Controls.Add(this.label34);
            this.panel4.Location = new System.Drawing.Point(8, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 607);
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
            this.lblCaption.Location = new System.Drawing.Point(-3, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Padding = new System.Windows.Forms.Padding(40, 8, 0, 0);
            this.lblCaption.Size = new System.Drawing.Size(1366, 60);
            this.lblCaption.TabIndex = 114;
            this.lblCaption.Text = "               Job Status";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(-3, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 708);
            this.panel3.TabIndex = 116;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(329, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 26);
            this.label3.TabIndex = 127;
            this.label3.Text = "කොන්ත්‍රාත් කාලය අවසන් කළ දිනය";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(399, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 26);
            this.label4.TabIndex = 121;
            this.label4.Text = "පරිවාස කාලය අවසන් දිනය";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // job_probation_to_permanent_status
            // 
            this.job_probation_to_permanent_status.AutoSize = true;
            this.job_probation_to_permanent_status.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.job_probation_to_permanent_status.Location = new System.Drawing.Point(643, 506);
            this.job_probation_to_permanent_status.Name = "job_probation_to_permanent_status";
            this.job_probation_to_permanent_status.Size = new System.Drawing.Size(312, 30);
            this.job_probation_to_permanent_status.TabIndex = 19;
            this.job_probation_to_permanent_status.Text = "පරිවාස කාලයේ සිට ස්ථිර සේවයට";
            this.job_probation_to_permanent_status.UseVisualStyleBackColor = true;
            this.job_probation_to_permanent_status.CheckedChanged += new System.EventHandler(this.job_probation_to_permanent_status_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(315, 582);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 26);
            this.label5.TabIndex = 126;
            this.label5.Text = "කොන්ත්‍රාත් පදනමේ සිට ස්ථිර වූ දිනය";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // job_employee_type
            // 
            this.job_employee_type.Enabled = false;
            this.job_employee_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_employee_type.FormattingEnabled = true;
            this.job_employee_type.Items.AddRange(new object[] {
            "ස්ථිර",
            "තාවකාලික",
            "ස්ථාවර",
            "අභ්‍යාසලාභී"});
            this.job_employee_type.Location = new System.Drawing.Point(643, 251);
            this.job_employee_type.Name = "job_employee_type";
            this.job_employee_type.Size = new System.Drawing.Size(200, 32);
            this.job_employee_type.TabIndex = 5;
            // 
            // job_probation_time
            // 
            this.job_probation_time.Enabled = false;
            this.job_probation_time.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.job_probation_time.Location = new System.Drawing.Point(643, 458);
            this.job_probation_time.Name = "job_probation_time";
            this.job_probation_time.Size = new System.Drawing.Size(150, 33);
            this.job_probation_time.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(507, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 26);
            this.label6.TabIndex = 125;
            this.label6.Text = "පරිවාස කාලය";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // job_contract_to_permanent_started_date
            // 
            this.job_contract_to_permanent_started_date.Enabled = false;
            this.job_contract_to_permanent_started_date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_contract_to_permanent_started_date.Location = new System.Drawing.Point(643, 579);
            this.job_contract_to_permanent_started_date.Name = "job_contract_to_permanent_started_date";
            this.job_contract_to_permanent_started_date.Size = new System.Drawing.Size(295, 31);
            this.job_contract_to_permanent_started_date.TabIndex = 128;
            this.job_contract_to_permanent_started_date.ValueChanged += new System.EventHandler(this.job_contract_to_permanent_started_date_ValueChanged);
            // 
            // job_probation_to_permanent_started_date
            // 
            this.job_probation_to_permanent_started_date.Enabled = false;
            this.job_probation_to_permanent_started_date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_probation_to_permanent_started_date.Location = new System.Drawing.Point(643, 542);
            this.job_probation_to_permanent_started_date.Name = "job_probation_to_permanent_started_date";
            this.job_probation_to_permanent_started_date.Size = new System.Drawing.Size(295, 31);
            this.job_probation_to_permanent_started_date.TabIndex = 129;
            this.job_probation_to_permanent_started_date.ValueChanged += new System.EventHandler(this.job_probation_to_permanent_started_date_ValueChanged);
            // 
            // job_probation_ended_date
            // 
            this.job_probation_ended_date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_probation_ended_date.Location = new System.Drawing.Point(643, 424);
            this.job_probation_ended_date.Name = "job_probation_ended_date";
            this.job_probation_ended_date.Size = new System.Drawing.Size(295, 31);
            this.job_probation_ended_date.TabIndex = 130;
            this.job_probation_ended_date.ValueChanged += new System.EventHandler(this.job_probation_ended_date_ValueChanged);
            // 
            // job_probation_started_date
            // 
            this.job_probation_started_date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_probation_started_date.Location = new System.Drawing.Point(643, 384);
            this.job_probation_started_date.Name = "job_probation_started_date";
            this.job_probation_started_date.Size = new System.Drawing.Size(295, 31);
            this.job_probation_started_date.TabIndex = 131;
            this.job_probation_started_date.ValueChanged += new System.EventHandler(this.job_probation_started_date_ValueChanged);
            // 
            // job_contract_ended_date
            // 
            this.job_contract_ended_date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_contract_ended_date.Location = new System.Drawing.Point(643, 347);
            this.job_contract_ended_date.Name = "job_contract_ended_date";
            this.job_contract_ended_date.Size = new System.Drawing.Size(295, 31);
            this.job_contract_ended_date.TabIndex = 132;
            this.job_contract_ended_date.ValueChanged += new System.EventHandler(this.job_contract_ended_date_ValueChanged);
            // 
            // job_contract_started_date
            // 
            this.job_contract_started_date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_contract_started_date.Location = new System.Drawing.Point(643, 310);
            this.job_contract_started_date.Name = "job_contract_started_date";
            this.job_contract_started_date.Size = new System.Drawing.Size(295, 31);
            this.job_contract_started_date.TabIndex = 133;
            this.job_contract_started_date.ValueChanged += new System.EventHandler(this.job_contract_started_date_ValueChanged);
            // 
            // erp_job_contract_started_date
            // 
            this.erp_job_contract_started_date.ContainerControl = this;
            // 
            // erp_job_contract_ended_date
            // 
            this.erp_job_contract_ended_date.ContainerControl = this;
            // 
            // erp_job_probation_started_date
            // 
            this.erp_job_probation_started_date.ContainerControl = this;
            // 
            // erp_job_probation_ended_date
            // 
            this.erp_job_probation_ended_date.ContainerControl = this;
            // 
            // erp_job_probation_to_permanent_started_date
            // 
            this.erp_job_probation_to_permanent_started_date.ContainerControl = this;
            // 
            // erp_job_contract_to_permanent_started_date
            // 
            this.erp_job_contract_to_permanent_started_date.ContainerControl = this;
            // 
            // btnCheckJobStatusDetails
            // 
            this.btnCheckJobStatusDetails.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckJobStatusDetails.ForeColor = System.Drawing.Color.Black;
            this.btnCheckJobStatusDetails.Location = new System.Drawing.Point(643, 616);
            this.btnCheckJobStatusDetails.Name = "btnCheckJobStatusDetails";
            this.btnCheckJobStatusDetails.Size = new System.Drawing.Size(75, 33);
            this.btnCheckJobStatusDetails.TabIndex = 159;
            this.btnCheckJobStatusDetails.Text = "Check";
            this.btnCheckJobStatusDetails.UseVisualStyleBackColor = true;
            this.btnCheckJobStatusDetails.Click += new System.EventHandler(this.btnCheckJobStatusDetails_Click);
            // 
            // frmJobStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 741);
            this.Controls.Add(this.btnCheckJobStatusDetails);
            this.Controls.Add(this.job_contract_started_date);
            this.Controls.Add(this.job_contract_ended_date);
            this.Controls.Add(this.job_probation_started_date);
            this.Controls.Add(this.job_probation_ended_date);
            this.Controls.Add(this.job_probation_to_permanent_started_date);
            this.Controls.Add(this.job_contract_to_permanent_started_date);
            this.Controls.Add(this.job_probation_to_permanent_status);
            this.Controls.Add(this.job_employee_type);
            this.Controls.Add(this.job_employee_no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.job_full_name);
            this.Controls.Add(this.job_probation_time);
            this.Controls.Add(this.job_post);
            this.Controls.Add(this.job_rank);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmJobStatus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erp_job_contract_started_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_job_contract_ended_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_job_probation_started_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_job_probation_ended_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_job_probation_to_permanent_started_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_job_contract_to_permanent_started_date)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox job_employee_no;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox job_full_name;
        private System.Windows.Forms.TextBox job_post;
        private System.Windows.Forms.TextBox job_rank;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox full_name;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox employee_no;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox job_probation_to_permanent_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox job_employee_type;
        private System.Windows.Forms.TextBox job_probation_time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker job_contract_to_permanent_started_date;
        private System.Windows.Forms.DateTimePicker job_probation_to_permanent_started_date;
        private System.Windows.Forms.DateTimePicker job_probation_ended_date;
        private System.Windows.Forms.DateTimePicker job_probation_started_date;
        private System.Windows.Forms.DateTimePicker job_contract_ended_date;
        private System.Windows.Forms.DateTimePicker job_contract_started_date;
        private System.Windows.Forms.ErrorProvider erp_job_contract_started_date;
        private System.Windows.Forms.ErrorProvider erp_job_contract_ended_date;
        private System.Windows.Forms.ErrorProvider erp_job_probation_started_date;
        private System.Windows.Forms.ErrorProvider erp_job_probation_ended_date;
        private System.Windows.Forms.ErrorProvider erp_job_probation_to_permanent_started_date;
        private System.Windows.Forms.ErrorProvider erp_job_contract_to_permanent_started_date;
        private System.Windows.Forms.Button btnCheckJobStatusDetails;
    }
}