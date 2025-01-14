namespace hootelv
{
    partial class staffMainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.staff_bookRoom1 = new hootelv.staff_bookRoom();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logoutbutton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(-4, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 947);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(93, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome !";
            // 
            // button5
            // 
            this.button5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button5.Location = new System.Drawing.Point(20, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(290, 87);
            this.button5.TabIndex = 9;
            this.button5.Text = "DASHBOARD";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Location = new System.Drawing.Point(20, 460);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(290, 87);
            this.button4.TabIndex = 8;
            this.button4.Text = "CUSTOMERS";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hootelv.Properties.Resources.usr;
            this.pictureBox1.Location = new System.Drawing.Point(22, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.logoutbutton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.logoutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoutbutton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logoutbutton.FlatAppearance.BorderSize = 0;
            this.logoutbutton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbutton.ForeColor = System.Drawing.Color.SeaShell;
            this.logoutbutton.Location = new System.Drawing.Point(16, 710);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(294, 147);
            this.logoutbutton.TabIndex = 6;
            this.logoutbutton.Text = "LOGOUT";
            this.logoutbutton.UseVisualStyleBackColor = false;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(20, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 82);
            this.button2.TabIndex = 5;
            this.button2.Text = "BOOK ROOM";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(20, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(290, 87);
            this.button3.TabIndex = 3;
            this.button3.Text = "AVAILABLE ROOMS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // staff_bookRoom1
            // 
            this.staff_bookRoom1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.staff_bookRoom1.Location = new System.Drawing.Point(309, -42);
            this.staff_bookRoom1.Name = "staff_bookRoom1";
            this.staff_bookRoom1.Size = new System.Drawing.Size(1228, 890);
            this.staff_bookRoom1.TabIndex = 5;
            this.staff_bookRoom1.Load += new System.EventHandler(this.staff_bookRoom1_Load);
            // 
            // staffMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1552, 948);
            this.Controls.Add(this.staff_bookRoom1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staffMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "staffMainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private staff_bookRoom staff_bookRoom1;
    }
}