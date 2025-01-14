namespace hootelv
{
    partial class admin_rooms
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rooms_deletebtn = new System.Windows.Forms.Button();
            this.rooms_updatebtn = new System.Windows.Forms.Button();
            this.rooms_importbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.rooms_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rooms_status = new System.Windows.Forms.ComboBox();
            this.rooms_roomname = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.rooms_roomtype = new System.Windows.Forms.ComboBox();
            this.rooms_roomID = new System.Windows.Forms.TextBox();
            this.rooms_picture = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rooms_addbtn = new System.Windows.Forms.Button();
            this.rooms_Clearbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rooms_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.No;
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 315);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 37);
            this.label2.TabIndex = 29;
            this.label2.Text = "\'s Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.rooms_Clearbtn);
            this.panel2.Controls.Add(this.rooms_deletebtn);
            this.panel2.Controls.Add(this.rooms_updatebtn);
            this.panel2.Controls.Add(this.rooms_addbtn);
            this.panel2.Controls.Add(this.rooms_importbtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.rooms_price);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rooms_status);
            this.panel2.Controls.Add(this.rooms_roomname);
            this.panel2.Controls.Add(this.labelRole);
            this.panel2.Controls.Add(this.labelPassword);
            this.panel2.Controls.Add(this.rooms_roomtype);
            this.panel2.Controls.Add(this.rooms_roomID);
            this.panel2.Location = new System.Drawing.Point(3, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 418);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rooms_deletebtn
            // 
            this.rooms_deletebtn.BackColor = System.Drawing.Color.Red;
            this.rooms_deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rooms_deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_deletebtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_deletebtn.ForeColor = System.Drawing.Color.White;
            this.rooms_deletebtn.Location = new System.Drawing.Point(293, 327);
            this.rooms_deletebtn.Name = "rooms_deletebtn";
            this.rooms_deletebtn.Size = new System.Drawing.Size(95, 46);
            this.rooms_deletebtn.TabIndex = 42;
            this.rooms_deletebtn.Text = "Delete";
            this.rooms_deletebtn.UseVisualStyleBackColor = false;
            this.rooms_deletebtn.Click += new System.EventHandler(this.rooms_deletebtn_Click);
            // 
            // rooms_updatebtn
            // 
            this.rooms_updatebtn.BackColor = System.Drawing.Color.Orange;
            this.rooms_updatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rooms_updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_updatebtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_updatebtn.ForeColor = System.Drawing.Color.White;
            this.rooms_updatebtn.Location = new System.Drawing.Point(189, 327);
            this.rooms_updatebtn.Name = "rooms_updatebtn";
            this.rooms_updatebtn.Size = new System.Drawing.Size(98, 46);
            this.rooms_updatebtn.TabIndex = 41;
            this.rooms_updatebtn.Text = "Update";
            this.rooms_updatebtn.UseVisualStyleBackColor = false;
            this.rooms_updatebtn.Click += new System.EventHandler(this.rooms_updatebtn_Click);
            // 
            // rooms_importbtn
            // 
            this.rooms_importbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rooms_importbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.rooms_importbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rooms_importbtn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rooms_importbtn.FlatAppearance.BorderSize = 0;
            this.rooms_importbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_importbtn.ForeColor = System.Drawing.Color.SeaShell;
            this.rooms_importbtn.Location = new System.Drawing.Point(700, 299);
            this.rooms_importbtn.Name = "rooms_importbtn";
            this.rooms_importbtn.Size = new System.Drawing.Size(261, 89);
            this.rooms_importbtn.TabIndex = 37;
            this.rooms_importbtn.Text = "Import";
            this.rooms_importbtn.UseVisualStyleBackColor = false;
            this.rooms_importbtn.Click += new System.EventHandler(this.rooms_importbtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.rooms_picture);
            this.panel3.Location = new System.Drawing.Point(698, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 249);
            this.panel3.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(395, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Price(DH):";
            // 
            // rooms_price
            // 
            this.rooms_price.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_price.Location = new System.Drawing.Point(492, 98);
            this.rooms_price.Name = "rooms_price";
            this.rooms_price.Size = new System.Drawing.Size(178, 28);
            this.rooms_price.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(395, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(27, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Room Name:";
            // 
            // rooms_status
            // 
            this.rooms_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rooms_status.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_status.FormattingEnabled = true;
            this.rooms_status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Occupied"});
            this.rooms_status.Location = new System.Drawing.Point(492, 167);
            this.rooms_status.Name = "rooms_status";
            this.rooms_status.Size = new System.Drawing.Size(178, 27);
            this.rooms_status.TabIndex = 29;
            // 
            // rooms_roomname
            // 
            this.rooms_roomname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_roomname.Location = new System.Drawing.Point(147, 239);
            this.rooms_roomname.Name = "rooms_roomname";
            this.rooms_roomname.Size = new System.Drawing.Size(219, 28);
            this.rooms_roomname.TabIndex = 28;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelRole.Location = new System.Drawing.Point(27, 170);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(53, 19);
            this.labelRole.TabIndex = 27;
            this.labelRole.Text = "Type:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelPassword.Location = new System.Drawing.Point(27, 101);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(84, 19);
            this.labelPassword.TabIndex = 26;
            this.labelPassword.Text = "Room ID:";
            // 
            // rooms_roomtype
            // 
            this.rooms_roomtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rooms_roomtype.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_roomtype.FormattingEnabled = true;
            this.rooms_roomtype.Items.AddRange(new object[] {
            "Single Room",
            "Double Room"});
            this.rooms_roomtype.Location = new System.Drawing.Point(147, 167);
            this.rooms_roomtype.Name = "rooms_roomtype";
            this.rooms_roomtype.Size = new System.Drawing.Size(168, 27);
            this.rooms_roomtype.TabIndex = 25;
            // 
            // rooms_roomID
            // 
            this.rooms_roomID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_roomID.Location = new System.Drawing.Point(147, 101);
            this.rooms_roomID.Name = "rooms_roomID";
            this.rooms_roomID.Size = new System.Drawing.Size(148, 28);
            this.rooms_roomID.TabIndex = 24;
            // 
            // rooms_picture
            // 
            this.rooms_picture.Location = new System.Drawing.Point(2, 3);
            this.rooms_picture.Name = "rooms_picture";
            this.rooms_picture.Size = new System.Drawing.Size(255, 243);
            this.rooms_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rooms_picture.TabIndex = 0;
            this.rooms_picture.TabStop = false;
            this.rooms_picture.Click += new System.EventHandler(this.rooms_picture_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(23, 72);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(938, 243);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(377, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 39);
            this.label1.TabIndex = 28;
            this.label1.Text = "Room";
            // 
            // rooms_addbtn
            // 
            this.rooms_addbtn.BackColor = System.Drawing.Color.LimeGreen;
            this.rooms_addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rooms_addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_addbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_addbtn.ForeColor = System.Drawing.Color.White;
            this.rooms_addbtn.Location = new System.Drawing.Point(82, 327);
            this.rooms_addbtn.Name = "rooms_addbtn";
            this.rooms_addbtn.Size = new System.Drawing.Size(101, 46);
            this.rooms_addbtn.TabIndex = 40;
            this.rooms_addbtn.Text = "Add";
            this.rooms_addbtn.UseVisualStyleBackColor = false;
            this.rooms_addbtn.Click += new System.EventHandler(this.rooms_addbtn_Click);
            // 
            // rooms_Clearbtn
            // 
            this.rooms_Clearbtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rooms_Clearbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rooms_Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_Clearbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_Clearbtn.ForeColor = System.Drawing.Color.White;
            this.rooms_Clearbtn.Location = new System.Drawing.Point(394, 327);
            this.rooms_Clearbtn.Name = "rooms_Clearbtn";
            this.rooms_Clearbtn.Size = new System.Drawing.Size(101, 46);
            this.rooms_Clearbtn.TabIndex = 43;
            this.rooms_Clearbtn.Text = "Clear";
            this.rooms_Clearbtn.UseVisualStyleBackColor = false;
            this.rooms_Clearbtn.Click += new System.EventHandler(this.rooms_Clearbtn_Click);
            // 
            // admin_rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "admin_rooms";
            this.Size = new System.Drawing.Size(1001, 752);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rooms_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.ComboBox rooms_roomtype;
        private System.Windows.Forms.TextBox rooms_roomID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rooms_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox rooms_status;
        private System.Windows.Forms.TextBox rooms_roomname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button rooms_importbtn;
        private System.Windows.Forms.PictureBox rooms_picture;
        private System.Windows.Forms.Button rooms_deletebtn;
        private System.Windows.Forms.Button rooms_updatebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rooms_addbtn;
        private System.Windows.Forms.Button rooms_Clearbtn;
    }
}
