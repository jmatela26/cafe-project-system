namespace BintanaSystem
{
    partial class Register
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
            this.Btn_Register = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_User = new System.Windows.Forms.TextBox();
            this.txtBox_Pass = new System.Windows.Forms.TextBox();
            this.txtBox_Pass2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_StaffID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbo_Security = new System.Windows.Forms.ComboBox();
            this.label_Sec = new System.Windows.Forms.Label();
            this.txtBox_Security = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Register
            // 
            this.Btn_Register.BackColor = System.Drawing.Color.Silver;
            this.Btn_Register.Location = new System.Drawing.Point(194, 345);
            this.Btn_Register.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(170, 63);
            this.Btn_Register.TabIndex = 6;
            this.Btn_Register.Text = "Register";
            this.Btn_Register.UseVisualStyleBackColor = false;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(412, 427);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(140, 57);
            this.Btn_Cancel.TabIndex = 7;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Re-enter password :";
            // 
            // txtBox_User
            // 
            this.txtBox_User.Location = new System.Drawing.Point(216, 72);
            this.txtBox_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_User.Name = "txtBox_User";
            this.txtBox_User.Size = new System.Drawing.Size(260, 26);
            this.txtBox_User.TabIndex = 1;
            // 
            // txtBox_Pass
            // 
            this.txtBox_Pass.Location = new System.Drawing.Point(216, 122);
            this.txtBox_Pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_Pass.Name = "txtBox_Pass";
            this.txtBox_Pass.PasswordChar = '*';
            this.txtBox_Pass.Size = new System.Drawing.Size(260, 26);
            this.txtBox_Pass.TabIndex = 2;
            // 
            // txtBox_Pass2
            // 
            this.txtBox_Pass2.Location = new System.Drawing.Point(216, 178);
            this.txtBox_Pass2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_Pass2.Name = "txtBox_Pass2";
            this.txtBox_Pass2.PasswordChar = '*';
            this.txtBox_Pass2.Size = new System.Drawing.Size(260, 26);
            this.txtBox_Pass2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Staff ID Number :";
            // 
            // txtBox_StaffID
            // 
            this.txtBox_StaffID.Location = new System.Drawing.Point(216, 18);
            this.txtBox_StaffID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_StaffID.Name = "txtBox_StaffID";
            this.txtBox_StaffID.ReadOnly = true;
            this.txtBox_StaffID.Size = new System.Drawing.Size(148, 26);
            this.txtBox_StaffID.TabIndex = 10;
            this.txtBox_StaffID.TextChanged += new System.EventHandler(this.txtBox_StaffID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Security Level :";
            // 
            // cmbo_Security
            // 
            this.cmbo_Security.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbo_Security.FormattingEnabled = true;
            this.cmbo_Security.ItemHeight = 20;
            this.cmbo_Security.Items.AddRange(new object[] {
            "Staff",
            "Administrator"});
            this.cmbo_Security.Location = new System.Drawing.Point(216, 231);
            this.cmbo_Security.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbo_Security.Name = "cmbo_Security";
            this.cmbo_Security.Size = new System.Drawing.Size(66, 28);
            this.cmbo_Security.TabIndex = 4;
            this.cmbo_Security.SelectedIndexChanged += new System.EventHandler(this.cmbo_Security_SelectedIndexChanged);
            // 
            // label_Sec
            // 
            this.label_Sec.AutoSize = true;
            this.label_Sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sec.Location = new System.Drawing.Point(42, 288);
            this.label_Sec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Sec.Name = "label_Sec";
            this.label_Sec.Size = new System.Drawing.Size(147, 20);
            this.label_Sec.TabIndex = 13;
            this.label_Sec.Text = "Security Password :";
            this.label_Sec.Visible = false;
            // 
            // txtBox_Security
            // 
            this.txtBox_Security.Location = new System.Drawing.Point(216, 283);
            this.txtBox_Security.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_Security.Name = "txtBox_Security";
            this.txtBox_Security.PasswordChar = '*';
            this.txtBox_Security.Size = new System.Drawing.Size(148, 26);
            this.txtBox_Security.TabIndex = 5;
            this.txtBox_Security.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(556, 489);
            this.Controls.Add(this.txtBox_Security);
            this.Controls.Add(this.label_Sec);
            this.Controls.Add(this.cmbo_Security);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBox_StaffID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_Pass2);
            this.Controls.Add(this.txtBox_Pass);
            this.Controls.Add(this.txtBox_User);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Register);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_User;
        private System.Windows.Forms.TextBox txtBox_Pass;
        private System.Windows.Forms.TextBox txtBox_Pass2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_StaffID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbo_Security;
        private System.Windows.Forms.Label label_Sec;
        private System.Windows.Forms.TextBox txtBox_Security;
    }
}