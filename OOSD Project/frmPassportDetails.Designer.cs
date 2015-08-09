namespace OOSD_Project
{
    partial class frmPassportDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPassportDetails));
            this.lblCaption = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.full_name = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.employee_no = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passport_renewal_day = new System.Windows.Forms.ComboBox();
            this.passport_issued_day = new System.Windows.Forms.ComboBox();
            this.passport_renewal_month = new System.Windows.Forms.ComboBox();
            this.passport_issued_month = new System.Windows.Forms.ComboBox();
            this.passport_renewal_year = new System.Windows.Forms.ComboBox();
            this.passport_issued_year = new System.Windows.Forms.ComboBox();
            this.passport_status_deactive = new System.Windows.Forms.RadioButton();
            this.passport_status_active = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passport_post = new System.Windows.Forms.TextBox();
            this.passport_rank = new System.Windows.Forms.TextBox();
            this.passport_issued_place = new System.Windows.Forms.TextBox();
            this.passport_no = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.Color.Teal;
            this.lblCaption.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.MintCream;
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Padding = new System.Windows.Forms.Padding(40, 8, 0, 0);
            this.lblCaption.Size = new System.Drawing.Size(1382, 60);
            this.lblCaption.TabIndex = 2;
            this.lblCaption.Text = "                Passport Details";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 708);
            this.panel3.TabIndex = 18;
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
            this.panel4.Size = new System.Drawing.Size(284, 633);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.passport_renewal_day);
            this.panel1.Controls.Add(this.passport_issued_day);
            this.panel1.Controls.Add(this.passport_renewal_month);
            this.panel1.Controls.Add(this.passport_issued_month);
            this.panel1.Controls.Add(this.passport_renewal_year);
            this.panel1.Controls.Add(this.passport_issued_year);
            this.panel1.Controls.Add(this.passport_status_deactive);
            this.panel1.Controls.Add(this.passport_status_active);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.passport_post);
            this.panel1.Controls.Add(this.passport_rank);
            this.panel1.Controls.Add(this.passport_issued_place);
            this.panel1.Controls.Add(this.passport_no);
            this.panel1.Location = new System.Drawing.Point(299, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 600);
            this.panel1.TabIndex = 19;
            // 
            // passport_renewal_day
            // 
            this.passport_renewal_day.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.passport_renewal_day.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passport_renewal_day.FormattingEnabled = true;
            this.passport_renewal_day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.passport_renewal_day.Location = new System.Drawing.Point(477, 224);
            this.passport_renewal_day.Name = "passport_renewal_day";
            this.passport_renewal_day.Size = new System.Drawing.Size(91, 34);
            this.passport_renewal_day.TabIndex = 37;
            this.passport_renewal_day.Text = "    දිනය";
            // 
            // passport_issued_day
            // 
            this.passport_issued_day.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.passport_issued_day.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passport_issued_day.FormattingEnabled = true;
            this.passport_issued_day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.passport_issued_day.Location = new System.Drawing.Point(477, 184);
            this.passport_issued_day.Name = "passport_issued_day";
            this.passport_issued_day.Size = new System.Drawing.Size(91, 34);
            this.passport_issued_day.TabIndex = 37;
            this.passport_issued_day.Text = "    දිනය";
            // 
            // passport_renewal_month
            // 
            this.passport_renewal_month.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.passport_renewal_month.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passport_renewal_month.FormattingEnabled = true;
            this.passport_renewal_month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.passport_renewal_month.Location = new System.Drawing.Point(380, 224);
            this.passport_renewal_month.Name = "passport_renewal_month";
            this.passport_renewal_month.Size = new System.Drawing.Size(91, 34);
            this.passport_renewal_month.TabIndex = 36;
            this.passport_renewal_month.Text = "   මාසය";
            // 
            // passport_issued_month
            // 
            this.passport_issued_month.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.passport_issued_month.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passport_issued_month.FormattingEnabled = true;
            this.passport_issued_month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.passport_issued_month.Location = new System.Drawing.Point(380, 184);
            this.passport_issued_month.Name = "passport_issued_month";
            this.passport_issued_month.Size = new System.Drawing.Size(91, 34);
            this.passport_issued_month.TabIndex = 36;
            this.passport_issued_month.Text = "   මාසය";
            // 
            // passport_renewal_year
            // 
            this.passport_renewal_year.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.passport_renewal_year.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passport_renewal_year.FormattingEnabled = true;
            this.passport_renewal_year.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946"});
            this.passport_renewal_year.Location = new System.Drawing.Point(271, 224);
            this.passport_renewal_year.Name = "passport_renewal_year";
            this.passport_renewal_year.Size = new System.Drawing.Size(103, 34);
            this.passport_renewal_year.TabIndex = 35;
            this.passport_renewal_year.Text = "   වර්ෂය";
            // 
            // passport_issued_year
            // 
            this.passport_issued_year.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.passport_issued_year.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passport_issued_year.FormattingEnabled = true;
            this.passport_issued_year.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946"});
            this.passport_issued_year.Location = new System.Drawing.Point(271, 184);
            this.passport_issued_year.Name = "passport_issued_year";
            this.passport_issued_year.Size = new System.Drawing.Size(103, 34);
            this.passport_issued_year.TabIndex = 35;
            this.passport_issued_year.Text = "   වර්ෂය";
            // 
            // passport_status_deactive
            // 
            this.passport_status_deactive.AutoSize = true;
            this.passport_status_deactive.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.passport_status_deactive.Location = new System.Drawing.Point(410, 264);
            this.passport_status_deactive.Name = "passport_status_deactive";
            this.passport_status_deactive.Size = new System.Drawing.Size(74, 30);
            this.passport_status_deactive.TabIndex = 34;
            this.passport_status_deactive.TabStop = true;
            this.passport_status_deactive.Text = "අක්‍රීය";
            this.passport_status_deactive.UseVisualStyleBackColor = true;
            // 
            // passport_status_active
            // 
            this.passport_status_active.AutoSize = true;
            this.passport_status_active.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.passport_status_active.Location = new System.Drawing.Point(271, 264);
            this.passport_status_active.Name = "passport_status_active";
            this.passport_status_active.Size = new System.Drawing.Size(77, 30);
            this.passport_status_active.TabIndex = 33;
            this.passport_status_active.TabStop = true;
            this.passport_status_active.Text = "සක්‍රීය";
            this.passport_status_active.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label9.Location = new System.Drawing.Point(189, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "තත්වය";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label8.Location = new System.Drawing.Point(124, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 26);
            this.label8.TabIndex = 25;
            this.label8.Text = "අළුත් කළ දිනය";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label6.Location = new System.Drawing.Point(187, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 26);
            this.label6.TabIndex = 26;
            this.label6.Text = "තනතුර";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label7.Location = new System.Drawing.Point(116, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 26);
            this.label7.TabIndex = 27;
            this.label7.Text = "නිකුත් කළ දිනය";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label5.Location = new System.Drawing.Point(206, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 26);
            this.label5.TabIndex = 28;
            this.label5.Text = "නිලය";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label3.Location = new System.Drawing.Point(90, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 26);
            this.label3.TabIndex = 29;
            this.label3.Text = "නිකුත් කළ ස්ථානය";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label1.Location = new System.Drawing.Point(25, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "විදේශ ගමන් බලපත්‍ර අංකය ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passport_post
            // 
            this.passport_post.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.passport_post.Location = new System.Drawing.Point(271, 67);
            this.passport_post.Name = "passport_post";
            this.passport_post.Size = new System.Drawing.Size(282, 33);
            this.passport_post.TabIndex = 23;
            // 
            // passport_rank
            // 
            this.passport_rank.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.passport_rank.Location = new System.Drawing.Point(271, 28);
            this.passport_rank.Name = "passport_rank";
            this.passport_rank.Size = new System.Drawing.Size(282, 33);
            this.passport_rank.TabIndex = 21;
            // 
            // passport_issued_place
            // 
            this.passport_issued_place.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.passport_issued_place.Location = new System.Drawing.Point(271, 145);
            this.passport_issued_place.Name = "passport_issued_place";
            this.passport_issued_place.Size = new System.Drawing.Size(282, 33);
            this.passport_issued_place.TabIndex = 19;
            // 
            // passport_no
            // 
            this.passport_no.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.passport_no.Location = new System.Drawing.Point(271, 106);
            this.passport_no.Name = "passport_no";
            this.passport_no.Size = new System.Drawing.Size(282, 33);
            this.passport_no.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(948, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "තැන්පතු කරන්න ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPrev);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 610);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 60);
            this.panel2.TabIndex = 20;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(97, 10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 42);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrev.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(12, 10);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 42);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Teal;
            this.label35.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.LightGray;
            this.label35.Location = new System.Drawing.Point(12, 9);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(168, 45);
            this.label35.TabIndex = 21;
            this.label35.Text = "Employee";
            // 
            // frmPassportDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1062, 670);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPassportDetails";
            this.Text = "Passport Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox full_name;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox employee_no;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton passport_status_deactive;
        private System.Windows.Forms.RadioButton passport_status_active;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passport_post;
        private System.Windows.Forms.TextBox passport_rank;
        private System.Windows.Forms.TextBox passport_issued_place;
        private System.Windows.Forms.TextBox passport_no;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox passport_renewal_day;
        private System.Windows.Forms.ComboBox passport_issued_day;
        private System.Windows.Forms.ComboBox passport_renewal_month;
        private System.Windows.Forms.ComboBox passport_issued_month;
        private System.Windows.Forms.ComboBox passport_renewal_year;
        private System.Windows.Forms.ComboBox passport_issued_year;
    }
}