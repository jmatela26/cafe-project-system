namespace BintanaSystem
{
    partial class SelectCoffee
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
            this.Btn_V60 = new System.Windows.Forms.Button();
            this.Btn_FP = new System.Windows.Forms.Button();
            this.Btn_Phin = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_V60
            // 
            this.Btn_V60.BackColor = System.Drawing.Color.Silver;
            this.Btn_V60.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_V60.Location = new System.Drawing.Point(12, 12);
            this.Btn_V60.Name = "Btn_V60";
            this.Btn_V60.Size = new System.Drawing.Size(99, 63);
            this.Btn_V60.TabIndex = 0;
            this.Btn_V60.Text = "V60";
            this.Btn_V60.UseVisualStyleBackColor = false;
            this.Btn_V60.Click += new System.EventHandler(this.Btn_V60_Click);
            // 
            // Btn_FP
            // 
            this.Btn_FP.BackColor = System.Drawing.Color.Silver;
            this.Btn_FP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FP.Location = new System.Drawing.Point(133, 12);
            this.Btn_FP.Name = "Btn_FP";
            this.Btn_FP.Size = new System.Drawing.Size(99, 63);
            this.Btn_FP.TabIndex = 1;
            this.Btn_FP.Text = "French Press";
            this.Btn_FP.UseVisualStyleBackColor = false;
            this.Btn_FP.Click += new System.EventHandler(this.Btn_FP_Click);
            // 
            // Btn_Phin
            // 
            this.Btn_Phin.BackColor = System.Drawing.Color.Silver;
            this.Btn_Phin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Phin.Location = new System.Drawing.Point(254, 12);
            this.Btn_Phin.Name = "Btn_Phin";
            this.Btn_Phin.Size = new System.Drawing.Size(99, 63);
            this.Btn_Phin.TabIndex = 2;
            this.Btn_Phin.Text = "Phin";
            this.Btn_Phin.UseVisualStyleBackColor = false;
            this.Btn_Phin.Click += new System.EventHandler(this.Btn_Phin_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(267, 99);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(86, 28);
            this.Btn_Back.TabIndex = 3;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // SelectCoffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 139);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Phin);
            this.Controls.Add(this.Btn_FP);
            this.Controls.Add(this.Btn_V60);
            this.Name = "SelectCoffee";
            this.Text = "CoffeeSelect";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_V60;
        private System.Windows.Forms.Button Btn_FP;
        private System.Windows.Forms.Button Btn_Phin;
        private System.Windows.Forms.Button Btn_Back;
    }
}