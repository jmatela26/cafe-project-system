namespace BintanaSystem
{
    partial class ALaCarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ALaCarte));
            this.Btn_ALC1 = new System.Windows.Forms.Button();
            this.Btn_ALC2 = new System.Windows.Forms.Button();
            this.Btn_ALC3 = new System.Windows.Forms.Button();
            this.Btn_ALC4 = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_ALC1
            // 
            this.Btn_ALC1.BackColor = System.Drawing.Color.Silver;
            this.Btn_ALC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ALC1.Location = new System.Drawing.Point(12, 12);
            this.Btn_ALC1.Name = "Btn_ALC1";
            this.Btn_ALC1.Size = new System.Drawing.Size(250, 100);
            this.Btn_ALC1.TabIndex = 0;
            this.Btn_ALC1.Text = "Pakbet";
            this.Btn_ALC1.UseVisualStyleBackColor = false;
            this.Btn_ALC1.Click += new System.EventHandler(this.Btn_ALC1_Click);
            // 
            // Btn_ALC2
            // 
            this.Btn_ALC2.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_ALC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ALC2.Location = new System.Drawing.Point(268, 118);
            this.Btn_ALC2.Name = "Btn_ALC2";
            this.Btn_ALC2.Size = new System.Drawing.Size(250, 100);
            this.Btn_ALC2.TabIndex = 1;
            this.Btn_ALC2.Text = "Boneless Bangus (Good for 2)";
            this.Btn_ALC2.UseVisualStyleBackColor = false;
            this.Btn_ALC2.Click += new System.EventHandler(this.Btn_ALC2_Click);
            // 
            // Btn_ALC3
            // 
            this.Btn_ALC3.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_ALC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ALC3.Location = new System.Drawing.Point(12, 118);
            this.Btn_ALC3.Name = "Btn_ALC3";
            this.Btn_ALC3.Size = new System.Drawing.Size(250, 100);
            this.Btn_ALC3.TabIndex = 2;
            this.Btn_ALC3.Text = "Kare-kare (Good for 2)";
            this.Btn_ALC3.UseVisualStyleBackColor = false;
            this.Btn_ALC3.Click += new System.EventHandler(this.Btn_ALC3_Click);
            // 
            // Btn_ALC4
            // 
            this.Btn_ALC4.BackColor = System.Drawing.Color.Silver;
            this.Btn_ALC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ALC4.Location = new System.Drawing.Point(268, 12);
            this.Btn_ALC4.Name = "Btn_ALC4";
            this.Btn_ALC4.Size = new System.Drawing.Size(250, 100);
            this.Btn_ALC4.TabIndex = 3;
            this.Btn_ALC4.Text = "Spicy Wings and Fries (Good for 2)";
            this.Btn_ALC4.UseVisualStyleBackColor = false;
            this.Btn_ALC4.Click += new System.EventHandler(this.Btn_ALC4_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.Location = new System.Drawing.Point(603, 311);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(128, 38);
            this.Btn_Cancel.TabIndex = 4;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(581, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ALaCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_ALC4);
            this.Controls.Add(this.Btn_ALC3);
            this.Controls.Add(this.Btn_ALC2);
            this.Controls.Add(this.Btn_ALC1);
            this.Name = "ALaCarte";
            this.Text = "ALaCarte";
            this.Load += new System.EventHandler(this.ALaCarte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ALC1;
        private System.Windows.Forms.Button Btn_ALC2;
        private System.Windows.Forms.Button Btn_ALC3;
        private System.Windows.Forms.Button Btn_ALC4;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}