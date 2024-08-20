namespace BintanaSystem
{
    partial class OrderEdit
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_User = new System.Windows.Forms.TextBox();
            this.txtBox_OrderNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid_Orders = new System.Windows.Forms.DataGridView();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_TableNo = new System.Windows.Forms.TextBox();
            this.Btn_Paid = new System.Windows.Forms.Button();
            this.Btn_OrderComplete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Orders)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(635, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "User :";
            // 
            // txtBox_User
            // 
            this.txtBox_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_User.Location = new System.Drawing.Point(692, 14);
            this.txtBox_User.Name = "txtBox_User";
            this.txtBox_User.ReadOnly = true;
            this.txtBox_User.Size = new System.Drawing.Size(113, 26);
            this.txtBox_User.TabIndex = 24;
            // 
            // txtBox_OrderNo
            // 
            this.txtBox_OrderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_OrderNo.Location = new System.Drawing.Point(135, 14);
            this.txtBox_OrderNo.Name = "txtBox_OrderNo";
            this.txtBox_OrderNo.ReadOnly = true;
            this.txtBox_OrderNo.Size = new System.Drawing.Size(57, 26);
            this.txtBox_OrderNo.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Order Number :";
            // 
            // dataGrid_Orders
            // 
            this.dataGrid_Orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Orders.Location = new System.Drawing.Point(12, 48);
            this.dataGrid_Orders.Name = "dataGrid_Orders";
            this.dataGrid_Orders.ReadOnly = true;
            this.dataGrid_Orders.Size = new System.Drawing.Size(608, 367);
            this.dataGrid_Orders.TabIndex = 21;
            this.dataGrid_Orders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Orders_CellClick);
            this.dataGrid_Orders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Orders_CellContentClick);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(692, 405);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(125, 44);
            this.Btn_Back.TabIndex = 20;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(639, 131);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(166, 55);
            this.Btn_Delete.TabIndex = 16;
            this.Btn_Delete.Text = "Delete Order";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.Silver;
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.Location = new System.Drawing.Point(639, 69);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(166, 56);
            this.Btn_Add.TabIndex = 15;
            this.Btn_Add.Text = "Add Order";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Table Number :";
            // 
            // txtBox_TableNo
            // 
            this.txtBox_TableNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_TableNo.Location = new System.Drawing.Point(358, 14);
            this.txtBox_TableNo.Name = "txtBox_TableNo";
            this.txtBox_TableNo.ReadOnly = true;
            this.txtBox_TableNo.Size = new System.Drawing.Size(45, 26);
            this.txtBox_TableNo.TabIndex = 27;
            // 
            // Btn_Paid
            // 
            this.Btn_Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Paid.Location = new System.Drawing.Point(639, 325);
            this.Btn_Paid.Name = "Btn_Paid";
            this.Btn_Paid.Size = new System.Drawing.Size(166, 55);
            this.Btn_Paid.TabIndex = 28;
            this.Btn_Paid.Text = "Pay";
            this.Btn_Paid.UseVisualStyleBackColor = true;
            this.Btn_Paid.Click += new System.EventHandler(this.Btn_Paid_Click);
            // 
            // Btn_OrderComplete
            // 
            this.Btn_OrderComplete.BackColor = System.Drawing.Color.Silver;
            this.Btn_OrderComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OrderComplete.Location = new System.Drawing.Point(639, 231);
            this.Btn_OrderComplete.Name = "Btn_OrderComplete";
            this.Btn_OrderComplete.Size = new System.Drawing.Size(166, 55);
            this.Btn_OrderComplete.TabIndex = 29;
            this.Btn_OrderComplete.Text = "Order Complete";
            this.Btn_OrderComplete.UseVisualStyleBackColor = false;
            this.Btn_OrderComplete.Click += new System.EventHandler(this.Btn_OrderComplete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Grand Total :";
            // 
            // txtBox_Total
            // 
            this.txtBox_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Total.Location = new System.Drawing.Point(520, 423);
            this.txtBox_Total.Name = "txtBox_Total";
            this.txtBox_Total.Size = new System.Drawing.Size(100, 26);
            this.txtBox_Total.TabIndex = 30;
            // 
            // OrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 460);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_Total);
            this.Controls.Add(this.Btn_OrderComplete);
            this.Controls.Add(this.Btn_Paid);
            this.Controls.Add(this.txtBox_TableNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_User);
            this.Controls.Add(this.txtBox_OrderNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGrid_Orders);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Add);
            this.Name = "OrderEdit";
            this.Text = "OrderEdit";
            this.Load += new System.EventHandler(this.OrderEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_User;
        private System.Windows.Forms.TextBox txtBox_OrderNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGrid_Orders;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_TableNo;
        private System.Windows.Forms.Button Btn_Paid;
        private System.Windows.Forms.Button Btn_OrderComplete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_Total;
    }
}