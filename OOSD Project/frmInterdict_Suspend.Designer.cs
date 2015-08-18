namespace OOSD_Project
{
    partial class frmInterdict_Suspend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInterdict_Suspend));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label33 = new System.Windows.Forms.Label();
            this.employee_no = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.full_name = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.interdict_employee_no = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.interdict_full_name = new System.Windows.Forms.TextBox();
            this.interdict_post = new System.Windows.Forms.TextBox();
            this.interdict_rank = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.interdict_more_notes = new System.Windows.Forms.TextBox();
            this.interdict_reason = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.interdict_rejoined = new System.Windows.Forms.RadioButton();
            this.interdict_not_rejoined = new System.Windows.Forms.RadioButton();
            this.interdict_unattended_date_from = new System.Windows.Forms.DateTimePicker();
            this.interdict_unattended_date_to = new System.Windows.Forms.DateTimePicker();
            this.interdict_date_to = new System.Windows.Forms.DateTimePicker();
            this.interdict_date_from = new System.Windows.Forms.DateTimePicker();
            this.btnCheckInterdictSuspendDetails = new System.Windows.Forms.Button();
            this.erp_interdict_unattended_date_to = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp_interdict_unattended_date_from = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp_interdict_date_to = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp_interdict_unattended_date_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_interdict_unattended_date_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_interdict_date_to)).BeginInit();
            this.SuspendLayout();
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
            this.lblCaption.TabIndex = 70;
            this.lblCaption.Text = "               Interdict/Suspend";
            // 
            // full_name
            // 
            this.full_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_name.Location = new System.Drawing.Point(14, 355);
            this.full_name.Name = "full_name";
            this.full_name.Size = new System.Drawing.Size(250, 29);
            this.full_name.TabIndex = 4;
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
            // interdict_employee_no
            // 
            this.interdict_employee_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interdict_employee_no.FormattingEnabled = true;
            this.interdict_employee_no.Location = new System.Drawing.Point(608, 98);
            this.interdict_employee_no.Name = "interdict_employee_no";
            this.interdict_employee_no.Size = new System.Drawing.Size(200, 32);
            this.interdict_employee_no.TabIndex = 1;
            this.interdict_employee_no.SelectedIndexChanged += new System.EventHandler(this.interdict_employee_no_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(327, 445);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 78);
            this.label11.TabIndex = 89;
            this.label11.Text = "සේවයෙන් ඉවත් කීරීම/\r\nතාවකාලිකව වැඩ තහනම් කීරීම\r\nදින සිට";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(435, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 26);
            this.label1.TabIndex = 93;
            this.label1.Text = "නොපැමිණි දින සිට";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(468, 622);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 26);
            this.label12.TabIndex = 87;
            this.label12.Text = "වැඩිදුර සටහන්";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(527, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 26);
            this.label15.TabIndex = 88;
            this.label15.Text = "තනතුර";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(546, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 26);
            this.label8.TabIndex = 86;
            this.label8.Text = "නිලය";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(415, 353);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(187, 26);
            this.label14.TabIndex = 85;
            this.label14.Text = "නොපැමිණි දින දක්වා";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(531, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 26);
            this.label9.TabIndex = 84;
            this.label9.Text = "හේතුව";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // interdict_full_name
            // 
            this.interdict_full_name.Enabled = false;
            this.interdict_full_name.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.interdict_full_name.Location = new System.Drawing.Point(608, 136);
            this.interdict_full_name.Name = "interdict_full_name";
            this.interdict_full_name.Size = new System.Drawing.Size(300, 33);
            this.interdict_full_name.TabIndex = 2;
            this.interdict_full_name.TextChanged += new System.EventHandler(this.interdict_full_name_TextChanged);
            // 
            // interdict_post
            // 
            this.interdict_post.Enabled = false;
            this.interdict_post.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.interdict_post.Location = new System.Drawing.Point(608, 175);
            this.interdict_post.Name = "interdict_post";
            this.interdict_post.Size = new System.Drawing.Size(150, 33);
            this.interdict_post.TabIndex = 3;
            this.interdict_post.TextChanged += new System.EventHandler(this.interdict_post_TextChanged);
            // 
            // interdict_rank
            // 
            this.interdict_rank.Enabled = false;
            this.interdict_rank.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.interdict_rank.Location = new System.Drawing.Point(608, 214);
            this.interdict_rank.Name = "interdict_rank";
            this.interdict_rank.Size = new System.Drawing.Size(150, 33);
            this.interdict_rank.TabIndex = 4;
            this.interdict_rank.TextChanged += new System.EventHandler(this.interdict_rank_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(478, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 26);
            this.label13.TabIndex = 83;
            this.label13.Text = "සම්පූර්ණ නම";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(475, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 26);
            this.label7.TabIndex = 82;
            this.label7.Text = "සේවක අංකය";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // interdict_more_notes
            // 
            this.interdict_more_notes.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.interdict_more_notes.Location = new System.Drawing.Point(608, 619);
            this.interdict_more_notes.Multiline = true;
            this.interdict_more_notes.Name = "interdict_more_notes";
            this.interdict_more_notes.Size = new System.Drawing.Size(250, 50);
            this.interdict_more_notes.TabIndex = 20;
            // 
            // interdict_reason
            // 
            this.interdict_reason.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.interdict_reason.Location = new System.Drawing.Point(608, 253);
            this.interdict_reason.Multiline = true;
            this.interdict_reason.Name = "interdict_reason";
            this.interdict_reason.Size = new System.Drawing.Size(250, 50);
            this.interdict_reason.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 681);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 60);
            this.panel2.TabIndex = 81;
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
            this.label35.Location = new System.Drawing.Point(-3, 9);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(168, 45);
            this.label35.TabIndex = 76;
            this.label35.Text = "Employee";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(-3, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 708);
            this.panel3.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(327, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 52);
            this.label2.TabIndex = 85;
            this.label2.Text = "තාවකාලිකව වැඩ තහනම් කීරීම\r\nදින දක්වා";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // interdict_rejoined
            // 
            this.interdict_rejoined.AutoSize = true;
            this.interdict_rejoined.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.interdict_rejoined.Location = new System.Drawing.Point(608, 391);
            this.interdict_rejoined.Name = "interdict_rejoined";
            this.interdict_rejoined.Size = new System.Drawing.Size(213, 30);
            this.interdict_rejoined.TabIndex = 12;
            this.interdict_rejoined.TabStop = true;
            this.interdict_rejoined.Text = "නැවත බඳවා ගැනීමක් ";
            this.interdict_rejoined.UseVisualStyleBackColor = true;
            this.interdict_rejoined.CheckedChanged += new System.EventHandler(this.interdict_rejoined_CheckedChanged);
            // 
            // interdict_not_rejoined
            // 
            this.interdict_not_rejoined.AutoSize = true;
            this.interdict_not_rejoined.Checked = true;
            this.interdict_not_rejoined.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.interdict_not_rejoined.Location = new System.Drawing.Point(902, 388);
            this.interdict_not_rejoined.Name = "interdict_not_rejoined";
            this.interdict_not_rejoined.Size = new System.Drawing.Size(249, 30);
            this.interdict_not_rejoined.TabIndex = 13;
            this.interdict_not_rejoined.TabStop = true;
            this.interdict_not_rejoined.Text = "නැවත බඳවා නොගැනීමක් ";
            this.interdict_not_rejoined.UseVisualStyleBackColor = true;
            this.interdict_not_rejoined.CheckedChanged += new System.EventHandler(this.interdict_not_rejoined_CheckedChanged);
            // 
            // interdict_unattended_date_from
            // 
            this.interdict_unattended_date_from.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interdict_unattended_date_from.Location = new System.Drawing.Point(608, 310);
            this.interdict_unattended_date_from.Name = "interdict_unattended_date_from";
            this.interdict_unattended_date_from.Size = new System.Drawing.Size(297, 31);
            this.interdict_unattended_date_from.TabIndex = 94;
            this.interdict_unattended_date_from.ValueChanged += new System.EventHandler(this.interdict_unattended_date_from_ValueChanged);
            // 
            // interdict_unattended_date_to
            // 
            this.interdict_unattended_date_to.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interdict_unattended_date_to.Location = new System.Drawing.Point(608, 349);
            this.interdict_unattended_date_to.Name = "interdict_unattended_date_to";
            this.interdict_unattended_date_to.Size = new System.Drawing.Size(297, 31);
            this.interdict_unattended_date_to.TabIndex = 95;
            this.interdict_unattended_date_to.ValueChanged += new System.EventHandler(this.interdict_unattended_date_to_ValueChanged);
            // 
            // interdict_date_to
            // 
            this.interdict_date_to.Enabled = false;
            this.interdict_date_to.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interdict_date_to.Location = new System.Drawing.Point(608, 547);
            this.interdict_date_to.Name = "interdict_date_to";
            this.interdict_date_to.Size = new System.Drawing.Size(297, 31);
            this.interdict_date_to.TabIndex = 96;
            this.interdict_date_to.ValueChanged += new System.EventHandler(this.interdict_date_to_ValueChanged);
            // 
            // interdict_date_from
            // 
            this.interdict_date_from.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interdict_date_from.Location = new System.Drawing.Point(608, 445);
            this.interdict_date_from.Name = "interdict_date_from";
            this.interdict_date_from.Size = new System.Drawing.Size(297, 31);
            this.interdict_date_from.TabIndex = 97;
            this.interdict_date_from.ValueChanged += new System.EventHandler(this.interdict_date_from_ValueChanged);
            // 
            // btnCheckInterdictSuspendDetails
            // 
            this.btnCheckInterdictSuspendDetails.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckInterdictSuspendDetails.ForeColor = System.Drawing.Color.Black;
            this.btnCheckInterdictSuspendDetails.Location = new System.Drawing.Point(303, 63);
            this.btnCheckInterdictSuspendDetails.Name = "btnCheckInterdictSuspendDetails";
            this.btnCheckInterdictSuspendDetails.Size = new System.Drawing.Size(75, 33);
            this.btnCheckInterdictSuspendDetails.TabIndex = 98;
            this.btnCheckInterdictSuspendDetails.Text = "Check";
            this.btnCheckInterdictSuspendDetails.UseVisualStyleBackColor = true;
            this.btnCheckInterdictSuspendDetails.Click += new System.EventHandler(this.btnCheckInterdictSuspendDetails_Click);
            // 
            // erp_interdict_unattended_date_to
            // 
            this.erp_interdict_unattended_date_to.ContainerControl = this;
            // 
            // erp_interdict_unattended_date_from
            // 
            this.erp_interdict_unattended_date_from.ContainerControl = this;
            // 
            // erp_interdict_date_to
            // 
            this.erp_interdict_date_to.ContainerControl = this;
            // 
            // frmInterdict_Suspend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 741);
            this.Controls.Add(this.btnCheckInterdictSuspendDetails);
            this.Controls.Add(this.interdict_date_from);
            this.Controls.Add(this.interdict_date_to);
            this.Controls.Add(this.interdict_unattended_date_to);
            this.Controls.Add(this.interdict_unattended_date_from);
            this.Controls.Add(this.interdict_not_rejoined);
            this.Controls.Add(this.interdict_rejoined);
            this.Controls.Add(this.interdict_employee_no);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.interdict_full_name);
            this.Controls.Add(this.interdict_post);
            this.Controls.Add(this.interdict_rank);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.interdict_more_notes);
            this.Controls.Add(this.interdict_reason);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInterdict_Suspend";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erp_interdict_unattended_date_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_interdict_unattended_date_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_interdict_date_to)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox employee_no;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.TextBox full_name;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox interdict_employee_no;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox interdict_full_name;
        private System.Windows.Forms.TextBox interdict_post;
        private System.Windows.Forms.TextBox interdict_rank;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox interdict_more_notes;
        private System.Windows.Forms.TextBox interdict_reason;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton interdict_rejoined;
        private System.Windows.Forms.RadioButton interdict_not_rejoined;
        private System.Windows.Forms.DateTimePicker interdict_unattended_date_from;
        private System.Windows.Forms.DateTimePicker interdict_unattended_date_to;
        private System.Windows.Forms.DateTimePicker interdict_date_to;
        private System.Windows.Forms.DateTimePicker interdict_date_from;
        private System.Windows.Forms.Button btnCheckInterdictSuspendDetails;
        private System.Windows.Forms.ErrorProvider erp_interdict_unattended_date_to;
        private System.Windows.Forms.ErrorProvider erp_interdict_unattended_date_from;
        private System.Windows.Forms.ErrorProvider erp_interdict_date_to;
    }
}