namespace OOSD_Project
{
    partial class frmPension_Death
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPension_Death));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label33 = new System.Windows.Forms.Label();
            this.employee_no = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.full_name = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pension_employee_no = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pension_full_name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pension_notes = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pension_informed_date = new System.Windows.Forms.DateTimePicker();
            this.pension_died_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.pension_retired = new System.Windows.Forms.CheckBox();
            this.pension_dead = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.lblCaption.TabIndex = 84;
            this.lblCaption.Text = "               Pension && Deaths";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(470, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 26);
            this.label3.TabIndex = 98;
            this.label3.Text = "දැනුම් දුන් දිනය";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // pension_employee_no
            // 
            this.pension_employee_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pension_employee_no.FormattingEnabled = true;
            this.pension_employee_no.Location = new System.Drawing.Point(145, 51);
            this.pension_employee_no.Name = "pension_employee_no";
            this.pension_employee_no.Size = new System.Drawing.Size(200, 32);
            this.pension_employee_no.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(65, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 26);
            this.label9.TabIndex = 90;
            this.label9.Text = "සටහන්";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pension_full_name
            // 
            this.pension_full_name.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.pension_full_name.Location = new System.Drawing.Point(145, 89);
            this.pension_full_name.Name = "pension_full_name";
            this.pension_full_name.Size = new System.Drawing.Size(300, 33);
            this.pension_full_name.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(15, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 26);
            this.label13.TabIndex = 89;
            this.label13.Text = "සම්පූර්ණ නම";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 26);
            this.label7.TabIndex = 88;
            this.label7.Text = "සේවක අංකය";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pension_notes
            // 
            this.pension_notes.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.pension_notes.Location = new System.Drawing.Point(145, 168);
            this.pension_notes.Multiline = true;
            this.pension_notes.Name = "pension_notes";
            this.pension_notes.Size = new System.Drawing.Size(297, 142);
            this.pension_notes.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 681);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 60);
            this.panel2.TabIndex = 87;
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
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Teal;
            this.label35.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.LightGray;
            this.label35.Location = new System.Drawing.Point(-3, 9);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(168, 45);
            this.label35.TabIndex = 85;
            this.label35.Text = "Employee";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(-3, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 708);
            this.panel3.TabIndex = 86;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pension_informed_date);
            this.groupBox1.Controls.Add(this.pension_died_date);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pension_employee_no);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pension_notes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.pension_full_name);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.groupBox1.Location = new System.Drawing.Point(325, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 293);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            // 
            // pension_informed_date
            // 
            this.pension_informed_date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pension_informed_date.Location = new System.Drawing.Point(612, 128);
            this.pension_informed_date.Name = "pension_informed_date";
            this.pension_informed_date.Size = new System.Drawing.Size(294, 31);
            this.pension_informed_date.TabIndex = 103;
            // 
            // pension_died_date
            // 
            this.pension_died_date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pension_died_date.Location = new System.Drawing.Point(145, 130);
            this.pension_died_date.Name = "pension_died_date";
            this.pension_died_date.Size = new System.Drawing.Size(300, 31);
            this.pension_died_date.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 26);
            this.label6.TabIndex = 59;
            this.label6.Text = "මියගිය දිනය";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pension_retired
            // 
            this.pension_retired.AutoSize = true;
            this.pension_retired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pension_retired.Location = new System.Drawing.Point(325, 89);
            this.pension_retired.Name = "pension_retired";
            this.pension_retired.Size = new System.Drawing.Size(99, 29);
            this.pension_retired.TabIndex = 103;
            this.pension_retired.Text = "විශ්‍රාමික";
            this.pension_retired.UseVisualStyleBackColor = true;
            // 
            // pension_dead
            // 
            this.pension_dead.AutoSize = true;
            this.pension_dead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pension_dead.Location = new System.Drawing.Point(325, 124);
            this.pension_dead.Name = "pension_dead";
            this.pension_dead.Size = new System.Drawing.Size(109, 29);
            this.pension_dead.TabIndex = 104;
            this.pension_dead.Text = "මියගොස්";
            this.pension_dead.UseVisualStyleBackColor = true;
            // 
            // frmPension_Death
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 741);
            this.Controls.Add(this.pension_dead);
            this.Controls.Add(this.pension_retired);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPension_Death";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox employee_no;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox full_name;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox pension_employee_no;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pension_full_name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pension_notes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker pension_informed_date;
        private System.Windows.Forms.DateTimePicker pension_died_date;
        private System.Windows.Forms.CheckBox pension_retired;
        private System.Windows.Forms.CheckBox pension_dead;
    }
}