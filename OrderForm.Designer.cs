namespace BintanaSystem
{
    partial class OrderForm
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
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Place = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboBox_TableNo = new System.Windows.Forms.ComboBox();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.dataGrid_Orders = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_OrderNo = new System.Windows.Forms.TextBox();
            this.txtBox_User = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBox_Total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Orders)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.Silver;
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.Location = new System.Drawing.Point(640, 7);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(191, 82);
            this.Btn_Add.TabIndex = 0;
            this.Btn_Add.Text = "Add Order";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Silver;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(640, 105);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(191, 81);
            this.Btn_Delete.TabIndex = 1;
            this.Btn_Delete.Text = "Delete Order";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Place
            // 
            this.Btn_Place.BackColor = System.Drawing.Color.Silver;
            this.Btn_Place.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Place.Location = new System.Drawing.Point(640, 257);
            this.Btn_Place.Name = "Btn_Place";
            this.Btn_Place.Size = new System.Drawing.Size(191, 80);
            this.Btn_Place.TabIndex = 2;
            this.Btn_Place.Text = "Place Order";
            this.Btn_Place.UseVisualStyleBackColor = false;
            this.Btn_Place.Click += new System.EventHandler(this.Btn_Place_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(626, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Table Number :";
            // 
            // cmboBox_TableNo
            // 
            this.cmboBox_TableNo.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmboBox_TableNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBox_TableNo.FormattingEnabled = true;
            this.cmboBox_TableNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmboBox_TableNo.Location = new System.Drawing.Point(748, 211);
            this.cmboBox_TableNo.Name = "cmboBox_TableNo";
            this.cmboBox_TableNo.Size = new System.Drawing.Size(83, 28);
            this.cmboBox_TableNo.TabIndex = 7;
            this.cmboBox_TableNo.SelectedIndexChanged += new System.EventHandler(this.cmboBox_TableNo_SelectedIndexChanged);
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.Color.Silver;
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(706, 362);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(125, 44);
            this.Btn_Back.TabIndex = 9;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // dataGrid_Orders
            // 
            this.dataGrid_Orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Orders.Location = new System.Drawing.Point(12, 44);
            this.dataGrid_Orders.Name = "dataGrid_Orders";
            this.dataGrid_Orders.ReadOnly = true;
            this.dataGrid_Orders.Size = new System.Drawing.Size(608, 323);
            this.dataGrid_Orders.TabIndex = 10;
            this.dataGrid_Orders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Orders_CellClick);
            this.dataGrid_Orders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Orders_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Order Number :";
            // 
            // txtBox_OrderNo
            // 
            this.txtBox_OrderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_OrderNo.Location = new System.Drawing.Point(135, 7);
            this.txtBox_OrderNo.Name = "txtBox_OrderNo";
            this.txtBox_OrderNo.ReadOnly = true;
            this.txtBox_OrderNo.Size = new System.Drawing.Size(57, 26);
            this.txtBox_OrderNo.TabIndex = 12;
            // 
            // txtBox_User
            // 
            this.txtBox_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_User.Location = new System.Drawing.Point(507, 10);
            this.txtBox_User.Name = "txtBox_User";
            this.txtBox_User.ReadOnly = true;
            this.txtBox_User.Size = new System.Drawing.Size(113, 26);
            this.txtBox_User.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "User :";
            // 
            // txtBox_Total
            // 
            this.txtBox_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Total.Location = new System.Drawing.Point(520, 386);
            this.txtBox_Total.Name = "txtBox_Total";
            this.txtBox_Total.Size = new System.Drawing.Size(100, 26);
            this.txtBox_Total.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Grand Total :";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 425);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_Total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_User);
            this.Controls.Add(this.txtBox_OrderNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGrid_Orders);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.cmboBox_TableNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Place);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Add);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Place;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboBox_TableNo;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.DataGridView dataGrid_Orders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_OrderNo;
        private System.Windows.Forms.TextBox txtBox_User;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtBox_Total;
        private System.Windows.Forms.Label label4;
    }
}