namespace BintanaSystem
{
    partial class SelectRoastBeef
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
            this.Btn_Rice = new System.Windows.Forms.Button();
            this.Btn_MPandBread = new System.Windows.Forms.Button();
            this.Btn_All = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Rice
            // 
            this.Btn_Rice.BackColor = System.Drawing.Color.Silver;
            this.Btn_Rice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Rice.Location = new System.Drawing.Point(26, 18);
            this.Btn_Rice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Rice.Name = "Btn_Rice";
            this.Btn_Rice.Size = new System.Drawing.Size(213, 91);
            this.Btn_Rice.TabIndex = 0;
            this.Btn_Rice.Text = "w/ Rice";
            this.Btn_Rice.UseVisualStyleBackColor = false;
            this.Btn_Rice.Click += new System.EventHandler(this.Btn_Rice_Click);
            // 
            // Btn_MPandBread
            // 
            this.Btn_MPandBread.BackColor = System.Drawing.Color.Silver;
            this.Btn_MPandBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MPandBread.Location = new System.Drawing.Point(248, 18);
            this.Btn_MPandBread.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_MPandBread.Name = "Btn_MPandBread";
            this.Btn_MPandBread.Size = new System.Drawing.Size(213, 91);
            this.Btn_MPandBread.TabIndex = 1;
            this.Btn_MPandBread.Text = "w/ Mashed Potato and Bread";
            this.Btn_MPandBread.UseVisualStyleBackColor = false;
            this.Btn_MPandBread.Click += new System.EventHandler(this.Btn_MPandBread_Click);
            // 
            // Btn_All
            // 
            this.Btn_All.BackColor = System.Drawing.Color.Silver;
            this.Btn_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_All.Location = new System.Drawing.Point(470, 18);
            this.Btn_All.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_All.Name = "Btn_All";
            this.Btn_All.Size = new System.Drawing.Size(213, 91);
            this.Btn_All.TabIndex = 2;
            this.Btn_All.Text = "w/ Rice, Mashed Potato and Bread";
            this.Btn_All.UseVisualStyleBackColor = false;
            this.Btn_All.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(573, 152);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 31);
            this.button4.TabIndex = 3;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SelectRoastBeef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 197);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Btn_All);
            this.Controls.Add(this.Btn_MPandBread);
            this.Controls.Add(this.Btn_Rice);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SelectRoastBeef";
            this.Text = "SelectBeef";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Rice;
        private System.Windows.Forms.Button Btn_MPandBread;
        private System.Windows.Forms.Button Btn_All;
        private System.Windows.Forms.Button button4;
    }
}