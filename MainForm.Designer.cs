namespace BintanaSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Btn_Order = new System.Windows.Forms.Button();
            this.Btn_Tables = new System.Windows.Forms.Button();
            this.Btn_Record = new System.Windows.Forms.Button();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.Btn_Logout = new System.Windows.Forms.Button();
            this.txtBox_User = new System.Windows.Forms.TextBox();
            this.txtBox_Date = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Time = new System.Windows.Forms.TextBox();
            this.Btn_Users = new System.Windows.Forms.Button();
            this.Btn_Inventory = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Order
            // 
            this.Btn_Order.BackColor = System.Drawing.Color.Silver;
            this.Btn_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Order.Location = new System.Drawing.Point(12, 173);
            this.Btn_Order.Name = "Btn_Order";
            this.Btn_Order.Size = new System.Drawing.Size(191, 128);
            this.Btn_Order.TabIndex = 0;
            this.Btn_Order.Text = "Order";
            this.Btn_Order.UseVisualStyleBackColor = false;
            this.Btn_Order.Click += new System.EventHandler(this.Btn_Order_Click);
            // 
            // Btn_Tables
            // 
            this.Btn_Tables.BackColor = System.Drawing.Color.Silver;
            this.Btn_Tables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Tables.Location = new System.Drawing.Point(230, 173);
            this.Btn_Tables.Name = "Btn_Tables";
            this.Btn_Tables.Size = new System.Drawing.Size(191, 128);
            this.Btn_Tables.TabIndex = 1;
            this.Btn_Tables.Text = "Tables";
            this.Btn_Tables.UseVisualStyleBackColor = false;
            this.Btn_Tables.Click += new System.EventHandler(this.Btn_Tables_Click);
            // 
            // Btn_Record
            // 
            this.Btn_Record.BackColor = System.Drawing.Color.Silver;
            this.Btn_Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Record.Location = new System.Drawing.Point(446, 173);
            this.Btn_Record.Name = "Btn_Record";
            this.Btn_Record.Size = new System.Drawing.Size(191, 128);
            this.Btn_Record.TabIndex = 2;
            this.Btn_Record.Text = "Record";
            this.Btn_Record.UseVisualStyleBackColor = false;
            this.Btn_Record.Click += new System.EventHandler(this.Btn_Record_Click);
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Welcome.Location = new System.Drawing.Point(13, 28);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(51, 20);
            this.label_Welcome.TabIndex = 3;
            this.label_Welcome.Text = "User :";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(13, 63);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(99, 20);
            this.label_Date.TabIndex = 4;
            this.label_Date.Text = "Date Today :";
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.BackColor = System.Drawing.Color.Silver;
            this.Btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Logout.Location = new System.Drawing.Point(532, 68);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.Size = new System.Drawing.Size(105, 41);
            this.Btn_Logout.TabIndex = 6;
            this.Btn_Logout.Text = "Logout";
            this.Btn_Logout.UseVisualStyleBackColor = false;
            this.Btn_Logout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // txtBox_User
            // 
            this.txtBox_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_User.Location = new System.Drawing.Point(127, 28);
            this.txtBox_User.Name = "txtBox_User";
            this.txtBox_User.ReadOnly = true;
            this.txtBox_User.Size = new System.Drawing.Size(149, 26);
            this.txtBox_User.TabIndex = 7;
            // 
            // txtBox_Date
            // 
            this.txtBox_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Date.Location = new System.Drawing.Point(127, 64);
            this.txtBox_Date.Name = "txtBox_Date";
            this.txtBox_Date.ReadOnly = true;
            this.txtBox_Date.Size = new System.Drawing.Size(149, 26);
            this.txtBox_Date.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Current Time :";
            // 
            // txtBox_Time
            // 
            this.txtBox_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Time.Location = new System.Drawing.Point(127, 96);
            this.txtBox_Time.Name = "txtBox_Time";
            this.txtBox_Time.ReadOnly = true;
            this.txtBox_Time.Size = new System.Drawing.Size(149, 26);
            this.txtBox_Time.TabIndex = 13;
            this.txtBox_Time.TextChanged += new System.EventHandler(this.txtBox_Time_TextChanged);
            // 
            // Btn_Users
            // 
            this.Btn_Users.BackColor = System.Drawing.Color.Silver;
            this.Btn_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Users.Location = new System.Drawing.Point(358, 21);
            this.Btn_Users.Name = "Btn_Users";
            this.Btn_Users.Size = new System.Drawing.Size(140, 41);
            this.Btn_Users.TabIndex = 14;
            this.Btn_Users.Text = "View Users";
            this.Btn_Users.UseVisualStyleBackColor = false;
            this.Btn_Users.Click += new System.EventHandler(this.Btn_Users_Click);
            // 
            // Btn_Inventory
            // 
            this.Btn_Inventory.BackColor = System.Drawing.Color.Silver;
            this.Btn_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inventory.Location = new System.Drawing.Point(358, 68);
            this.Btn_Inventory.Name = "Btn_Inventory";
            this.Btn_Inventory.Size = new System.Drawing.Size(140, 41);
            this.Btn_Inventory.TabIndex = 15;
            this.Btn_Inventory.Text = "View Inventory";
            this.Btn_Inventory.UseVisualStyleBackColor = false;
            this.Btn_Inventory.Click += new System.EventHandler(this.Btn_Inventory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(653, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 313);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Inventory);
            this.Controls.Add(this.Btn_Users);
            this.Controls.Add(this.txtBox_Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_Date);
            this.Controls.Add(this.txtBox_User);
            this.Controls.Add(this.Btn_Logout);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Welcome);
            this.Controls.Add(this.Btn_Record);
            this.Controls.Add(this.Btn_Tables);
            this.Controls.Add(this.Btn_Order);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Order;
        private System.Windows.Forms.Button Btn_Tables;
        private System.Windows.Forms.Button Btn_Record;
        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Button Btn_Logout;
        private System.Windows.Forms.TextBox txtBox_User;
        private System.Windows.Forms.TextBox txtBox_Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Time;
        private System.Windows.Forms.Button Btn_Users;
        private System.Windows.Forms.Button Btn_Inventory;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}