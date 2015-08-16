namespace OOSD_Project
{
    partial class frmResignation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResignation));
            this.resignation_employee_no = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.full_name = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.employee_no = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.resignation_full_name = new System.Windows.Forms.TextBox();
            this.resignation_post = new System.Windows.Forms.TextBox();
            this.resignation_rank = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.resignation_letter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resignation_reason = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_resignation_browse = new System.Windows.Forms.Button();
            this.resignation_letter_submitted_date = new System.Windows.Forms.DateTimePicker();
            this.resignation_date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // resignation_employee_no
            // 
            this.resignation_employee_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resignation_employee_no.FormattingEnabled = true;
            this.resignation_employee_no.Location = new System.Drawing.Point(606, 98);
            this.resignation_employee_no.Name = "resignation_employee_no";
            this.resignation_employee_no.Size = new System.Drawing.Size(200, 32);
            this.resignation_employee_no.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(425, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 151;
            this.label1.Text = "ඉල්ලා අස්වීමේ දිනය";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1184, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "තැන්පතු කරන්න ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(339, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 26);
            this.label3.TabIndex = 149;
            this.label3.Text = "ඉල්ලා අස්වීමේ ලිපිය අමුණන්න";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(525, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 26);
            this.label15.TabIndex = 150;
            this.label15.Text = "තනතුර";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(544, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 26);
            this.label8.TabIndex = 147;
            this.label8.Text = "නිලය";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(529, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 26);
            this.label9.TabIndex = 145;
            this.label9.Text = "හේතුව";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resignation_full_name
            // 
            this.resignation_full_name.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.resignation_full_name.Location = new System.Drawing.Point(606, 136);
            this.resignation_full_name.Name = "resignation_full_name";
            this.resignation_full_name.Size = new System.Drawing.Size(300, 33);
            this.resignation_full_name.TabIndex = 129;
            // 
            // resignation_post
            // 
            this.resignation_post.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.resignation_post.Location = new System.Drawing.Point(606, 175);
            this.resignation_post.Name = "resignation_post";
            this.resignation_post.Size = new System.Drawing.Size(150, 33);
            this.resignation_post.TabIndex = 130;
            // 
            // resignation_rank
            // 
            this.resignation_rank.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.resignation_rank.Location = new System.Drawing.Point(606, 214);
            this.resignation_rank.Name = "resignation_rank";
            this.resignation_rank.Size = new System.Drawing.Size(150, 33);
            this.resignation_rank.TabIndex = 131;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(476, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 26);
            this.label13.TabIndex = 144;
            this.label13.Text = "සම්පූර්ණ නම";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resignation_letter
            // 
            this.resignation_letter.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.resignation_letter.Location = new System.Drawing.Point(606, 389);
            this.resignation_letter.Name = "resignation_letter";
            this.resignation_letter.Size = new System.Drawing.Size(300, 33);
            this.resignation_letter.TabIndex = 134;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(473, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 26);
            this.label7.TabIndex = 143;
            this.label7.Text = "සේවක අංකය";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resignation_reason
            // 
            this.resignation_reason.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.resignation_reason.Location = new System.Drawing.Point(606, 333);
            this.resignation_reason.Multiline = true;
            this.resignation_reason.Name = "resignation_reason";
            this.resignation_reason.Size = new System.Drawing.Size(250, 50);
            this.resignation_reason.TabIndex = 133;
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
            this.label35.TabIndex = 140;
            this.label35.Text = "Employee";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 681);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 60);
            this.panel2.TabIndex = 142;
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
            this.lblCaption.TabIndex = 139;
            this.lblCaption.Text = "               Resignation";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(-3, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 708);
            this.panel3.TabIndex = 141;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(311, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 26);
            this.label2.TabIndex = 151;
            this.label2.Text = "ඉල්ලා අස්වීමේ ලිපිය භාරදුන් දිනය";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_resignation_browse
            // 
            this.btn_resignation_browse.Location = new System.Drawing.Point(912, 391);
            this.btn_resignation_browse.Name = "btn_resignation_browse";
            this.btn_resignation_browse.Size = new System.Drawing.Size(63, 29);
            this.btn_resignation_browse.TabIndex = 152;
            this.btn_resignation_browse.Text = "Browse";
            this.btn_resignation_browse.UseVisualStyleBackColor = true;
            // 
            // resignation_letter_submitted_date
            // 
            this.resignation_letter_submitted_date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resignation_letter_submitted_date.Location = new System.Drawing.Point(606, 255);
            this.resignation_letter_submitted_date.Name = "resignation_letter_submitted_date";
            this.resignation_letter_submitted_date.Size = new System.Drawing.Size(297, 31);
            this.resignation_letter_submitted_date.TabIndex = 153;
            // 
            // resignation_date
            // 
            this.resignation_date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resignation_date.Location = new System.Drawing.Point(606, 294);
            this.resignation_date.Name = "resignation_date";
            this.resignation_date.Size = new System.Drawing.Size(297, 31);
            this.resignation_date.TabIndex = 154;
            // 
            // frmResignation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 741);
            this.Controls.Add(this.resignation_date);
            this.Controls.Add(this.resignation_letter_submitted_date);
            this.Controls.Add(this.btn_resignation_browse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resignation_employee_no);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resignation_full_name);
            this.Controls.Add(this.resignation_post);
            this.Controls.Add(this.resignation_rank);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.resignation_letter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resignation_reason);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmResignation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox resignation_employee_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox full_name;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox employee_no;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox resignation_full_name;
        private System.Windows.Forms.TextBox resignation_post;
        private System.Windows.Forms.TextBox resignation_rank;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox resignation_letter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox resignation_reason;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_resignation_browse;
        private System.Windows.Forms.DateTimePicker resignation_letter_submitted_date;
        private System.Windows.Forms.DateTimePicker resignation_date;
    }
}