namespace FlamingoWF
{
    partial class Orderinpending
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
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.websiteProjectFlamingoDataSet1 = new FlamingoWF.WebsiteProjectFlamingoDataSet1();
            this.ordersTableAdapter = new FlamingoWF.WebsiteProjectFlamingoDataSet1TableAdapters.OrdersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.websiteProjectFlamingoDataSet2 = new FlamingoWF.WebsiteProjectFlamingoDataSet2();
            this.ordersTableAdapter1 = new FlamingoWF.WebsiteProjectFlamingoDataSet2TableAdapters.OrdersTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flamingoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAttendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAttendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderInPendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDeliveredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grandTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasBeenProcessedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.extraRequirementsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteProjectFlamingoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteProjectFlamingoDataSet2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.websiteProjectFlamingoDataSet1;
            // 
            // websiteProjectFlamingoDataSet1
            // 
            this.websiteProjectFlamingoDataSet1.DataSetName = "WebsiteProjectFlamingoDataSet1";
            this.websiteProjectFlamingoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.grandTotalDataGridViewTextBoxColumn,
            this.hasBeenProcessedDataGridViewCheckBoxColumn,
            this.extraRequirementsDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.Details,
            this.Column1});
            this.dataGridView1.DataSource = this.ordersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1372, 545);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.websiteProjectFlamingoDataSet2;
            // 
            // websiteProjectFlamingoDataSet2
            // 
            this.websiteProjectFlamingoDataSet2.DataSetName = "WebsiteProjectFlamingoDataSet2";
            this.websiteProjectFlamingoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flamingoToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flamingoToolStripMenuItem
            // 
            this.flamingoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feedbackToolStripMenuItem,
            this.feedbackToolStripMenuItem1});
            this.flamingoToolStripMenuItem.Name = "flamingoToolStripMenuItem";
            this.flamingoToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.flamingoToolStripMenuItem.Text = "Flamingo";
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.feedbackToolStripMenuItem.Text = "Main Menu";
            this.feedbackToolStripMenuItem.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
            // 
            // feedbackToolStripMenuItem1
            // 
            this.feedbackToolStripMenuItem1.Name = "feedbackToolStripMenuItem1";
            this.feedbackToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.feedbackToolStripMenuItem1.Text = "Feedback";
            this.feedbackToolStripMenuItem1.Click += new System.EventHandler(this.feedbackToolStripMenuItem1_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.attendenceToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.deleteEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            this.deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            this.deleteEmployeeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteEmployeeToolStripMenuItem.Text = "Delete Employee";
            this.deleteEmployeeToolStripMenuItem.Click += new System.EventHandler(this.deleteEmployeeToolStripMenuItem_Click);
            // 
            // attendenceToolStripMenuItem
            // 
            this.attendenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markAttendenceToolStripMenuItem,
            this.viewAttendenceToolStripMenuItem});
            this.attendenceToolStripMenuItem.Name = "attendenceToolStripMenuItem";
            this.attendenceToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.attendenceToolStripMenuItem.Text = "Attendence";
            // 
            // markAttendenceToolStripMenuItem
            // 
            this.markAttendenceToolStripMenuItem.Name = "markAttendenceToolStripMenuItem";
            this.markAttendenceToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.markAttendenceToolStripMenuItem.Text = "Mark Attendence";
            this.markAttendenceToolStripMenuItem.Click += new System.EventHandler(this.markAttendenceToolStripMenuItem_Click);
            // 
            // viewAttendenceToolStripMenuItem
            // 
            this.viewAttendenceToolStripMenuItem.Name = "viewAttendenceToolStripMenuItem";
            this.viewAttendenceToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.viewAttendenceToolStripMenuItem.Text = "View Attendence";
            this.viewAttendenceToolStripMenuItem.Click += new System.EventHandler(this.viewAttendenceToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineOrderToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // onlineOrderToolStripMenuItem
            // 
            this.onlineOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderInPendingToolStripMenuItem,
            this.orderDeliveredToolStripMenuItem});
            this.onlineOrderToolStripMenuItem.Name = "onlineOrderToolStripMenuItem";
            this.onlineOrderToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.onlineOrderToolStripMenuItem.Text = "Online Order";
            // 
            // orderInPendingToolStripMenuItem
            // 
            this.orderInPendingToolStripMenuItem.Name = "orderInPendingToolStripMenuItem";
            this.orderInPendingToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.orderInPendingToolStripMenuItem.Text = "Order in pending";
            this.orderInPendingToolStripMenuItem.Click += new System.EventHandler(this.orderInPendingToolStripMenuItem_Click);
            // 
            // orderDeliveredToolStripMenuItem
            // 
            this.orderDeliveredToolStripMenuItem.Name = "orderDeliveredToolStripMenuItem";
            this.orderDeliveredToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.orderDeliveredToolStripMenuItem.Text = "Order Delivered";
            this.orderDeliveredToolStripMenuItem.Click += new System.EventHandler(this.orderDeliveredToolStripMenuItem_Click);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grandTotalDataGridViewTextBoxColumn
            // 
            this.grandTotalDataGridViewTextBoxColumn.DataPropertyName = "GrandTotal";
            this.grandTotalDataGridViewTextBoxColumn.HeaderText = "GrandTotal";
            this.grandTotalDataGridViewTextBoxColumn.Name = "grandTotalDataGridViewTextBoxColumn";
            this.grandTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hasBeenProcessedDataGridViewCheckBoxColumn
            // 
            this.hasBeenProcessedDataGridViewCheckBoxColumn.DataPropertyName = "HasBeenProcessed";
            this.hasBeenProcessedDataGridViewCheckBoxColumn.HeaderText = "HasBeenProcessed";
            this.hasBeenProcessedDataGridViewCheckBoxColumn.Name = "hasBeenProcessedDataGridViewCheckBoxColumn";
            this.hasBeenProcessedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // extraRequirementsDataGridViewTextBoxColumn
            // 
            this.extraRequirementsDataGridViewTextBoxColumn.DataPropertyName = "ExtraRequirements";
            this.extraRequirementsDataGridViewTextBoxColumn.HeaderText = "ExtraRequirements";
            this.extraRequirementsDataGridViewTextBoxColumn.Name = "extraRequirementsDataGridViewTextBoxColumn";
            this.extraRequirementsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Details
            // 
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Text = "More Details";
            this.Details.UseColumnTextForButtonValue = true;
            this.Details.Width = 120;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Delete Order";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Delete Order";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Orderinpending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1370, 572);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Orderinpending";
            this.Text = "Orderinpending";
            this.Load += new System.EventHandler(this.Orderinpending_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteProjectFlamingoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteProjectFlamingoDataSet2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WebsiteProjectFlamingoDataSet1 websiteProjectFlamingoDataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private WebsiteProjectFlamingoDataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WebsiteProjectFlamingoDataSet2 websiteProjectFlamingoDataSet2;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private WebsiteProjectFlamingoDataSet2TableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flamingoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAttendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAttendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderInPendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDeliveredToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grandTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasBeenProcessedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraRequirementsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;

    }
}