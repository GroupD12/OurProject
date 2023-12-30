namespace OurProject
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logoutform = new System.Windows.Forms.Button();
            this.reportform = new System.Windows.Forms.Button();
            this.doctorform = new System.Windows.Forms.Button();
            this.bookingform = new System.Windows.Forms.Button();
            this.patientform = new System.Windows.Forms.Button();
            this.userform = new System.Windows.Forms.Button();
            this.homeform = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new ReaLTaiizor.Controls.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 102);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 35F);
            this.bigLabel1.ForeColor = System.Drawing.Color.White;
            this.bigLabel1.Location = new System.Drawing.Point(227, 26);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(620, 62);
            this.bigLabel1.TabIndex = 10;
            this.bigLabel1.Text = "Doctor Appointment System";
            this.bigLabel1.Click += new System.EventHandler(this.bigLabel1_Click);
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(862, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 1;
            this.nightControlBox1.Click += new System.EventHandler(this.nightControlBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.logoutform);
            this.panel3.Controls.Add(this.reportform);
            this.panel3.Controls.Add(this.doctorform);
            this.panel3.Controls.Add(this.bookingform);
            this.panel3.Controls.Add(this.patientform);
            this.panel3.Controls.Add(this.userform);
            this.panel3.Controls.Add(this.homeform);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 483);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // logoutform
            // 
            this.logoutform.BackColor = System.Drawing.Color.White;
            this.logoutform.FlatAppearance.BorderSize = 0;
            this.logoutform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutform.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutform.ForeColor = System.Drawing.Color.Black;
            this.logoutform.Image = ((System.Drawing.Image)(resources.GetObject("logoutform.Image")));
            this.logoutform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutform.Location = new System.Drawing.Point(12, 408);
            this.logoutform.Name = "logoutform";
            this.logoutform.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.logoutform.Size = new System.Drawing.Size(136, 37);
            this.logoutform.TabIndex = 15;
            this.logoutform.Text = "       Logout";
            this.logoutform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutform.UseVisualStyleBackColor = false;
            this.logoutform.Click += new System.EventHandler(this.button7_Click);
            // 
            // reportform
            // 
            this.reportform.BackColor = System.Drawing.Color.White;
            this.reportform.FlatAppearance.BorderSize = 0;
            this.reportform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportform.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportform.ForeColor = System.Drawing.Color.Black;
            this.reportform.Image = ((System.Drawing.Image)(resources.GetObject("reportform.Image")));
            this.reportform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportform.Location = new System.Drawing.Point(12, 349);
            this.reportform.Name = "reportform";
            this.reportform.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.reportform.Size = new System.Drawing.Size(136, 37);
            this.reportform.TabIndex = 14;
            this.reportform.Text = "       Report";
            this.reportform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportform.UseVisualStyleBackColor = false;
            this.reportform.Click += new System.EventHandler(this.button5_Click);
            // 
            // doctorform
            // 
            this.doctorform.BackColor = System.Drawing.Color.White;
            this.doctorform.FlatAppearance.BorderSize = 0;
            this.doctorform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorform.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorform.ForeColor = System.Drawing.Color.Black;
            this.doctorform.Image = ((System.Drawing.Image)(resources.GetObject("doctorform.Image")));
            this.doctorform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorform.Location = new System.Drawing.Point(12, 216);
            this.doctorform.Name = "doctorform";
            this.doctorform.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.doctorform.Size = new System.Drawing.Size(136, 37);
            this.doctorform.TabIndex = 10;
            this.doctorform.Text = "      Doctor";
            this.doctorform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorform.UseVisualStyleBackColor = false;
            this.doctorform.Click += new System.EventHandler(this.button4_Click);
            // 
            // bookingform
            // 
            this.bookingform.BackColor = System.Drawing.Color.White;
            this.bookingform.FlatAppearance.BorderSize = 0;
            this.bookingform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingform.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingform.ForeColor = System.Drawing.Color.Black;
            this.bookingform.Image = ((System.Drawing.Image)(resources.GetObject("bookingform.Image")));
            this.bookingform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingform.Location = new System.Drawing.Point(12, 279);
            this.bookingform.Name = "bookingform";
            this.bookingform.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bookingform.Size = new System.Drawing.Size(136, 37);
            this.bookingform.TabIndex = 13;
            this.bookingform.Text = "      Booking";
            this.bookingform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingform.UseVisualStyleBackColor = false;
            this.bookingform.Click += new System.EventHandler(this.button6_Click);
            // 
            // patientform
            // 
            this.patientform.BackColor = System.Drawing.Color.White;
            this.patientform.FlatAppearance.BorderSize = 0;
            this.patientform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientform.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientform.ForeColor = System.Drawing.Color.Black;
            this.patientform.Image = ((System.Drawing.Image)(resources.GetObject("patientform.Image")));
            this.patientform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientform.Location = new System.Drawing.Point(12, 151);
            this.patientform.Name = "patientform";
            this.patientform.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.patientform.Size = new System.Drawing.Size(136, 37);
            this.patientform.TabIndex = 8;
            this.patientform.Text = "      Patient";
            this.patientform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientform.UseVisualStyleBackColor = false;
            this.patientform.Click += new System.EventHandler(this.button3_Click);
            // 
            // userform
            // 
            this.userform.BackColor = System.Drawing.Color.White;
            this.userform.FlatAppearance.BorderSize = 0;
            this.userform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userform.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userform.ForeColor = System.Drawing.Color.Black;
            this.userform.Image = ((System.Drawing.Image)(resources.GetObject("userform.Image")));
            this.userform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userform.Location = new System.Drawing.Point(12, 84);
            this.userform.Name = "userform";
            this.userform.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.userform.Size = new System.Drawing.Size(136, 37);
            this.userform.TabIndex = 12;
            this.userform.Text = "      Users";
            this.userform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userform.UseVisualStyleBackColor = false;
            this.userform.Click += new System.EventHandler(this.userform_Click);
            // 
            // homeform
            // 
            this.homeform.BackColor = System.Drawing.Color.White;
            this.homeform.FlatAppearance.BorderSize = 0;
            this.homeform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeform.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeform.ForeColor = System.Drawing.Color.Black;
            this.homeform.Image = ((System.Drawing.Image)(resources.GetObject("homeform.Image")));
            this.homeform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeform.Location = new System.Drawing.Point(12, 20);
            this.homeform.Name = "homeform";
            this.homeform.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.homeform.Size = new System.Drawing.Size(136, 37);
            this.homeform.TabIndex = 11;
            this.homeform.Text = "      Home";
            this.homeform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeform.UseVisualStyleBackColor = false;
            this.homeform.Click += new System.EventHandler(this.button2_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button10.Location = new System.Drawing.Point(502, 158);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(171, 99);
            this.button10.TabIndex = 18;
            this.button10.Text = "     All Doctors";
            this.button10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button9.Location = new System.Drawing.Point(246, 319);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(171, 99);
            this.button9.TabIndex = 20;
            this.button9.Text = "     All People";
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button11.Location = new System.Drawing.Point(749, 158);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(171, 99);
            this.button11.TabIndex = 21;
            this.button11.Text = "     All Patients";
            this.button11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button12.Location = new System.Drawing.Point(246, 158);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(171, 99);
            this.button12.TabIndex = 22;
            this.button12.Text = "     All Users";
            this.button12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button13.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button13.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button13.Location = new System.Drawing.Point(154, 101);
            this.button13.Name = "button13";
            this.button13.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button13.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button13.Size = new System.Drawing.Size(847, 484);
            this.button13.TabIndex = 23;
            this.button13.TextAlignment = System.Drawing.StringAlignment.Center;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button8.Location = new System.Drawing.Point(502, 319);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(171, 99);
            this.button8.TabIndex = 19;
            this.button8.Text = "     All Booking";
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 585);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button patientform;
        private System.Windows.Forms.Button reportform;
        private System.Windows.Forms.Button doctorform;
        private System.Windows.Forms.Button bookingform;
        private System.Windows.Forms.Button userform;
        private System.Windows.Forms.Button homeform;
        private System.Windows.Forms.Button logoutform;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private ReaLTaiizor.Controls.Button button13;
        private System.Windows.Forms.Button button8;
    }
}

