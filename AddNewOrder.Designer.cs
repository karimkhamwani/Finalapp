namespace FlamingoWF
{
    partial class AddNewOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddNewOrder_Category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddNewOrder_Items = new System.Windows.Forms.ComboBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.AddNeworder_Quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddnewOrder_Amount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Addneworder_orderid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Category";
            // 
            // AddNewOrder_Category
            // 
            this.AddNewOrder_Category.FormattingEnabled = true;
            this.AddNewOrder_Category.Location = new System.Drawing.Point(145, 50);
            this.AddNewOrder_Category.Name = "AddNewOrder_Category";
            this.AddNewOrder_Category.Size = new System.Drawing.Size(121, 21);
            this.AddNewOrder_Category.TabIndex = 2;
            this.AddNewOrder_Category.Text = "Select Category";
            this.AddNewOrder_Category.SelectedIndexChanged += new System.EventHandler(this.AddNewOrder_Category_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(23, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Items";
            // 
            // AddNewOrder_Items
            // 
            this.AddNewOrder_Items.FormattingEnabled = true;
            this.AddNewOrder_Items.Location = new System.Drawing.Point(145, 113);
            this.AddNewOrder_Items.Name = "AddNewOrder_Items";
            this.AddNewOrder_Items.Size = new System.Drawing.Size(121, 21);
            this.AddNewOrder_Items.TabIndex = 4;
            this.AddNewOrder_Items.Text = "Select Items";
            this.AddNewOrder_Items.SelectedIndexChanged += new System.EventHandler(this.AddNewOrder_Items_SelectedIndexChanged);
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Quantity.Location = new System.Drawing.Point(23, 176);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(54, 15);
            this.Quantity.TabIndex = 5;
            this.Quantity.Text = "Quantity";
            // 
            // AddNeworder_Quantity
            // 
            this.AddNeworder_Quantity.Location = new System.Drawing.Point(145, 169);
            this.AddNeworder_Quantity.Name = "AddNeworder_Quantity";
            this.AddNeworder_Quantity.Size = new System.Drawing.Size(121, 20);
            this.AddNeworder_Quantity.TabIndex = 6;
            this.AddNeworder_Quantity.TextChanged += new System.EventHandler(this.AddNeworder_Quantity_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(26, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount";
            // 
            // AddnewOrder_Amount
            // 
            this.AddnewOrder_Amount.Enabled = false;
            this.AddnewOrder_Amount.Location = new System.Drawing.Point(145, 224);
            this.AddnewOrder_Amount.Name = "AddnewOrder_Amount";
            this.AddnewOrder_Amount.Size = new System.Drawing.Size(121, 20);
            this.AddnewOrder_Amount.TabIndex = 8;
            this.AddnewOrder_Amount.TextChanged += new System.EventHandler(this.AddnewOrder_Amount_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(177, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add to order List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(82, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Addneworder_orderid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddNewOrder_Category);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AddnewOrder_Amount);
            this.groupBox1.Controls.Add(this.AddNewOrder_Items);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Quantity);
            this.groupBox1.Controls.Add(this.AddNeworder_Quantity);
            this.groupBox1.Location = new System.Drawing.Point(17, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 253);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // Addneworder_orderid
            // 
            this.Addneworder_orderid.Location = new System.Drawing.Point(145, 13);
            this.Addneworder_orderid.Name = "Addneworder_orderid";
            this.Addneworder_orderid.Size = new System.Drawing.Size(121, 20);
            this.Addneworder_orderid.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(26, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Order Id";
            // 
            // AddNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(372, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AddNewOrder";
            this.Text = "AddNewOrder";
            this.Load += new System.EventHandler(this.AddNewOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AddNewOrder_Category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AddNewOrder_Items;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox AddNeworder_Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddnewOrder_Amount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Addneworder_orderid;
        private System.Windows.Forms.Label label5;
    }
}