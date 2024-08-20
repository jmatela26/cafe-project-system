namespace BintanaSystem
{
    partial class SelectTea
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
            this.Btn_1 = new System.Windows.Forms.Button();
            this.Btn_2 = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_1
            // 
            this.Btn_1.BackColor = System.Drawing.Color.Silver;
            this.Btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_1.Location = new System.Drawing.Point(12, 12);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Size = new System.Drawing.Size(126, 53);
            this.Btn_1.TabIndex = 0;
            this.Btn_1.Text = "Hot Tea (P60)";
            this.Btn_1.UseVisualStyleBackColor = false;
            this.Btn_1.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // Btn_2
            // 
            this.Btn_2.BackColor = System.Drawing.Color.Silver;
            this.Btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_2.Location = new System.Drawing.Point(175, 12);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Size = new System.Drawing.Size(118, 53);
            this.Btn_2.TabIndex = 1;
            this.Btn_2.Text = "Hot Tea (P80)";
            this.Btn_2.UseVisualStyleBackColor = false;
            this.Btn_2.Click += new System.EventHandler(this.Btn_2_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(208, 98);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(85, 35);
            this.Btn_Back.TabIndex = 2;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // SelectTea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 145);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_2);
            this.Controls.Add(this.Btn_1);
            this.Name = "SelectTea";
            this.Text = "SelectTea";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_1;
        private System.Windows.Forms.Button Btn_2;
        private System.Windows.Forms.Button Btn_Back;
    }
}