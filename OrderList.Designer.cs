namespace BintanaSystem
{
    partial class OrderList
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
            this.Btn_RiceMeals = new System.Windows.Forms.Button();
            this.Btn_ALaCarte = new System.Windows.Forms.Button();
            this.Btn_LightDishes = new System.Windows.Forms.Button();
            this.Btn_Drinks = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Desserts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_RiceMeals
            // 
            this.Btn_RiceMeals.BackColor = System.Drawing.Color.Silver;
            this.Btn_RiceMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RiceMeals.Location = new System.Drawing.Point(34, 12);
            this.Btn_RiceMeals.Name = "Btn_RiceMeals";
            this.Btn_RiceMeals.Size = new System.Drawing.Size(250, 150);
            this.Btn_RiceMeals.TabIndex = 0;
            this.Btn_RiceMeals.Text = "Rice Meals";
            this.Btn_RiceMeals.UseVisualStyleBackColor = false;
            this.Btn_RiceMeals.Click += new System.EventHandler(this.Btn_RiceMeals_Click);
            // 
            // Btn_ALaCarte
            // 
            this.Btn_ALaCarte.BackColor = System.Drawing.Color.Silver;
            this.Btn_ALaCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ALaCarte.Location = new System.Drawing.Point(290, 12);
            this.Btn_ALaCarte.Name = "Btn_ALaCarte";
            this.Btn_ALaCarte.Size = new System.Drawing.Size(250, 150);
            this.Btn_ALaCarte.TabIndex = 1;
            this.Btn_ALaCarte.Text = "A La Carte";
            this.Btn_ALaCarte.UseVisualStyleBackColor = false;
            this.Btn_ALaCarte.Click += new System.EventHandler(this.Btn_ALaCarte_Click);
            // 
            // Btn_LightDishes
            // 
            this.Btn_LightDishes.BackColor = System.Drawing.Color.Silver;
            this.Btn_LightDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LightDishes.Location = new System.Drawing.Point(546, 12);
            this.Btn_LightDishes.Name = "Btn_LightDishes";
            this.Btn_LightDishes.Size = new System.Drawing.Size(250, 150);
            this.Btn_LightDishes.TabIndex = 2;
            this.Btn_LightDishes.Text = "Light Dishes";
            this.Btn_LightDishes.UseVisualStyleBackColor = false;
            this.Btn_LightDishes.Click += new System.EventHandler(this.Btn_LightDishes_Click);
            // 
            // Btn_Drinks
            // 
            this.Btn_Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Drinks.Location = new System.Drawing.Point(290, 168);
            this.Btn_Drinks.Name = "Btn_Drinks";
            this.Btn_Drinks.Size = new System.Drawing.Size(250, 150);
            this.Btn_Drinks.TabIndex = 3;
            this.Btn_Drinks.Text = "Drinks";
            this.Btn_Drinks.UseVisualStyleBackColor = true;
            this.Btn_Drinks.Click += new System.EventHandler(this.Btn_Drinks_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(666, 265);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(130, 53);
            this.Btn_Back.TabIndex = 4;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Btn_Desserts
            // 
            this.Btn_Desserts.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Desserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Desserts.Location = new System.Drawing.Point(34, 168);
            this.Btn_Desserts.Name = "Btn_Desserts";
            this.Btn_Desserts.Size = new System.Drawing.Size(250, 150);
            this.Btn_Desserts.TabIndex = 5;
            this.Btn_Desserts.Text = "Desserts";
            this.Btn_Desserts.UseVisualStyleBackColor = false;
            this.Btn_Desserts.Click += new System.EventHandler(this.Btn_Desserts_Click);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 356);
            this.Controls.Add(this.Btn_Desserts);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Drinks);
            this.Controls.Add(this.Btn_LightDishes);
            this.Controls.Add(this.Btn_ALaCarte);
            this.Controls.Add(this.Btn_RiceMeals);
            this.Name = "OrderList";
            this.Text = "OrderList";
            this.Load += new System.EventHandler(this.OrderList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_RiceMeals;
        private System.Windows.Forms.Button Btn_ALaCarte;
        private System.Windows.Forms.Button Btn_LightDishes;
        private System.Windows.Forms.Button Btn_Drinks;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Desserts;
    }
}