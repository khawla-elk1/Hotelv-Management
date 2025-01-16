namespace hootelv
{
    partial class AdminMainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ROOMS = new System.Windows.Forms.Button();
            this.CUSTOMERS = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DASHBOARD = new System.Windows.Forms.Button();
            this.admin_customers1 = new hootelv.admin_customers();
            this.admin_rooms1 = new hootelv.admin_rooms();
            this.admin_addUser1 = new hootelv.admin_addUser();
            this.admin_dashboard1 = new hootelv.admin_dashboard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Image = global::hootelv.Properties.Resources.proxy_image__2_1;
            this.pictureBox1.Location = new System.Drawing.Point(-29, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ROOMS
            // 
            this.ROOMS.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ROOMS.BackColor = System.Drawing.Color.Orange;
            this.ROOMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ROOMS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ROOMS.FlatAppearance.BorderSize = 0;
            this.ROOMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ROOMS.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROOMS.ForeColor = System.Drawing.Color.SeaShell;
            this.ROOMS.Location = new System.Drawing.Point(3, 336);
            this.ROOMS.Name = "ROOMS";
            this.ROOMS.Size = new System.Drawing.Size(287, 78);
            this.ROOMS.TabIndex = 3;
            this.ROOMS.Text = "ROOMS";
            this.ROOMS.UseVisualStyleBackColor = false;
            this.ROOMS.Click += new System.EventHandler(this.button3_Click);
            // 
            // CUSTOMERS
            // 
            this.CUSTOMERS.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CUSTOMERS.BackColor = System.Drawing.Color.Orange;
            this.CUSTOMERS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CUSTOMERS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CUSTOMERS.FlatAppearance.BorderSize = 0;
            this.CUSTOMERS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CUSTOMERS.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUSTOMERS.ForeColor = System.Drawing.Color.SeaShell;
            this.CUSTOMERS.Location = new System.Drawing.Point(0, 420);
            this.CUSTOMERS.Name = "CUSTOMERS";
            this.CUSTOMERS.Size = new System.Drawing.Size(290, 79);
            this.CUSTOMERS.TabIndex = 4;
            this.CUSTOMERS.Text = "CUSTOMERS";
            this.CUSTOMERS.UseVisualStyleBackColor = false;
            this.CUSTOMERS.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SeaShell;
            this.button2.Location = new System.Drawing.Point(0, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 82);
            this.button2.TabIndex = 5;
            this.button2.Text = "ADD USER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // logoutbutton
            // 
            this.logoutbutton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.logoutbutton.BackColor = System.Drawing.Color.Orange;
            this.logoutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoutbutton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logoutbutton.FlatAppearance.BorderSize = 0;
            this.logoutbutton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbutton.ForeColor = System.Drawing.Color.SeaShell;
            this.logoutbutton.Location = new System.Drawing.Point(25, 633);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(236, 68);
            this.logoutbutton.TabIndex = 6;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = false;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.DASHBOARD);
            this.panel1.Controls.Add(this.logoutbutton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.CUSTOMERS);
            this.panel1.Controls.Add(this.ROOMS);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 920);
            this.panel1.TabIndex = 1;
            // 
            // DASHBOARD
            // 
            this.DASHBOARD.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DASHBOARD.BackColor = System.Drawing.Color.Orange;
            this.DASHBOARD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DASHBOARD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DASHBOARD.FlatAppearance.BorderSize = 0;
            this.DASHBOARD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DASHBOARD.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DASHBOARD.ForeColor = System.Drawing.Color.SeaShell;
            this.DASHBOARD.Location = new System.Drawing.Point(0, 164);
            this.DASHBOARD.Name = "DASHBOARD";
            this.DASHBOARD.Size = new System.Drawing.Size(290, 78);
            this.DASHBOARD.TabIndex = 7;
            this.DASHBOARD.Text = "DASHBOARD";
            this.DASHBOARD.UseVisualStyleBackColor = false;
            this.DASHBOARD.Click += new System.EventHandler(this.DASHBOARD_Click_1);
            // 
            // admin_customers1
            // 
            this.admin_customers1.Location = new System.Drawing.Point(295, 201);
            this.admin_customers1.Name = "admin_customers1";
            this.admin_customers1.Size = new System.Drawing.Size(1107, 806);
            this.admin_customers1.TabIndex = 2;
            // 
            // admin_rooms1
            // 
            this.admin_rooms1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin_rooms1.Location = new System.Drawing.Point(305, 83);
            this.admin_rooms1.Name = "admin_rooms1";
            this.admin_rooms1.Size = new System.Drawing.Size(1117, 823);
            this.admin_rooms1.TabIndex = 3;
            // 
            // admin_addUser1
            // 
            this.admin_addUser1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin_addUser1.Location = new System.Drawing.Point(326, 83);
            this.admin_addUser1.Name = "admin_addUser1";
            this.admin_addUser1.Size = new System.Drawing.Size(1248, 845);
            this.admin_addUser1.TabIndex = 4;
            // 
            // admin_dashboard1
            // 
            this.admin_dashboard1.Location = new System.Drawing.Point(285, -6);
            this.admin_dashboard1.Name = "admin_dashboard1";
            this.admin_dashboard1.Size = new System.Drawing.Size(1231, 801);
            this.admin_dashboard1.TabIndex = 5;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1528, 918);
            this.Controls.Add(this.admin_dashboard1);
            this.Controls.Add(this.admin_addUser1);
            this.Controls.Add(this.admin_rooms1);
            this.Controls.Add(this.admin_customers1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ROOMS;
        private System.Windows.Forms.Button CUSTOMERS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Panel panel1;
        private admin_customers admin_customers1;
        private admin_rooms admin_rooms1;
        private admin_addUser admin_addUser1;
        private admin_dashboard admin_dashboard1;
        private System.Windows.Forms.Button DASHBOARD;
    }
}