namespace BintanaSystem
{
    partial class SelectBurgerSteak
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
            this.Btn_1Pc = new System.Windows.Forms.Button();
            this.Btn_2Pc = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_1Pc
            // 
            this.Btn_1Pc.BackColor = System.Drawing.Color.Silver;
            this.Btn_1Pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_1Pc.Location = new System.Drawing.Point(24, 19);
            this.Btn_1Pc.Name = "Btn_1Pc";
            this.Btn_1Pc.Size = new System.Drawing.Size(106, 49);
            this.Btn_1Pc.TabIndex = 0;
            this.Btn_1Pc.Text = "1 Pc";
            this.Btn_1Pc.UseVisualStyleBackColor = false;
            this.Btn_1Pc.Click += new System.EventHandler(this.Btn_1Pc_Click);
            // 
            // Btn_2Pc
            // 
            this.Btn_2Pc.BackColor = System.Drawing.Color.Silver;
            this.Btn_2Pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_2Pc.Location = new System.Drawing.Point(162, 19);
            this.Btn_2Pc.Name = "Btn_2Pc";
            this.Btn_2Pc.Size = new System.Drawing.Size(106, 49);
            this.Btn_2Pc.TabIndex = 1;
            this.Btn_2Pc.Text = "2 Pcs";
            this.Btn_2Pc.UseVisualStyleBackColor = false;
            this.Btn_2Pc.Click += new System.EventHandler(this.Btn_2Pc_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(173, 101);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(95, 31);
            this.Btn_Back.TabIndex = 2;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // SelectBurgerSteak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(290, 144);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_2Pc);
            this.Controls.Add(this.Btn_1Pc);
            this.Name = "SelectBurgerSteak";
            this.Text = "BurgerSelect";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_1Pc;
        private System.Windows.Forms.Button Btn_2Pc;
        private System.Windows.Forms.Button Btn_Back;
    }
}