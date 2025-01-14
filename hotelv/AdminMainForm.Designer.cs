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
            this.admin_addUser1 = new hootelv.admin_addUser();
            this.admin_rooms1 = new hootelv.admin_rooms();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin_addUser1
            // 
            this.admin_addUser1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin_addUser1.Location = new System.Drawing.Point(340, 35);
            this.admin_addUser1.Name = "admin_addUser1";
            this.admin_addUser1.Size = new System.Drawing.Size(1193, 713);
            this.admin_addUser1.TabIndex = 2;
            // 
            // admin_rooms1
            // 
            this.admin_rooms1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin_rooms1.Location = new System.Drawing.Point(340, 106);
            this.admin_rooms1.Name = "admin_rooms1";
            this.admin_rooms1.Size = new System.Drawing.Size(1157, 778);
            this.admin_rooms1.TabIndex = 3;
            this.admin_rooms1.Load += new System.EventHandler(this.admin_rooms1_Load);
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
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(0, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "DASHBOARD";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.SeaShell;
            this.button3.Location = new System.Drawing.Point(3, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(287, 78);
            this.button3.TabIndex = 3;
            this.button3.Text = "ROOMS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button4.BackColor = System.Drawing.Color.Orange;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.SeaShell;
            this.button4.Location = new System.Drawing.Point(0, 420);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(290, 79);
            this.button4.TabIndex = 4;
            this.button4.Text = "CUSTOMERS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.logoutbutton.Location = new System.Drawing.Point(25, 762);
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
            this.panel1.Controls.Add(this.logoutbutton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 890);
            this.panel1.TabIndex = 1;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1490, 873);
            this.Controls.Add(this.admin_rooms1);
            this.Controls.Add(this.admin_addUser1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private admin_addUser admin_addUser1;
        private admin_rooms admin_rooms1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Panel panel1;
    }
}