namespace FlamingoWF
{
    partial class Feedback
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
            this.feedBacksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.websiteProjectFlamingoDataSet4 = new FlamingoWF.WebsiteProjectFlamingoDataSet4();
            this.feedBacksTableAdapter = new FlamingoWF.WebsiteProjectFlamingoDataSet4TableAdapters.FeedBacksTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flamingoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.websiteProjectFlamingoDataSet5 = new FlamingoWF.WebsiteProjectFlamingoDataSet5();
            this.feedBacksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.feedBacksTableAdapter1 = new FlamingoWF.WebsiteProjectFlamingoDataSet5TableAdapters.FeedBacksTableAdapter();
            this.feedBackIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualityOfFoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleanlinessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overallQualityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.feedBacksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteProjectFlamingoDataSet4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteProjectFlamingoDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBacksBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // feedBacksBindingSource
            // 
            this.feedBacksBindingSource.DataMember = "FeedBacks";
            this.feedBacksBindingSource.DataSource = this.websiteProjectFlamingoDataSet4;
            // 
            // websiteProjectFlamingoDataSet4
            // 
            this.websiteProjectFlamingoDataSet4.DataSetName = "WebsiteProjectFlamingoDataSet4";
            this.websiteProjectFlamingoDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedBacksTableAdapter
            // 
            this.feedBacksTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flamingoToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flamingoToolStripMenuItem
            // 
            this.flamingoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.feedbackToolStripMenuItem});
            this.flamingoToolStripMenuItem.Name = "flamingoToolStripMenuItem";
            this.flamingoToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.flamingoToolStripMenuItem.Text = "Flamingo";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem.Text = "Main menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            this.feedbackToolStripMenuItem.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
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
            this.orderInPendingToolStripMenuItem.Text = "Order in Pending";
            this.orderInPendingToolStripMenuItem.Click += new System.EventHandler(this.orderInPendingToolStripMenuItem_Click);
            // 
            // orderDeliveredToolStripMenuItem
            // 
            this.orderDeliveredToolStripMenuItem.Name = "orderDeliveredToolStripMenuItem";
            this.orderDeliveredToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.orderDeliveredToolStripMenuItem.Text = "Order Delivered";
            this.orderDeliveredToolStripMenuItem.Click += new System.EventHandler(this.orderDeliveredToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 396);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feedBackIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.qualityOfFoodDataGridViewTextBoxColumn,
            this.cleanlinessDataGridViewTextBoxColumn,
            this.overallQualityDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.feedBacksBindingSource1;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(748, 396);
            this.dataGridView2.TabIndex = 3;
            // 
            // websiteProjectFlamingoDataSet5
            // 
            this.websiteProjectFlamingoDataSet5.DataSetName = "WebsiteProjectFlamingoDataSet5";
            this.websiteProjectFlamingoDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedBacksBindingSource1
            // 
            this.feedBacksBindingSource1.DataMember = "FeedBacks";
            this.feedBacksBindingSource1.DataSource = this.websiteProjectFlamingoDataSet5;
            // 
            // feedBacksTableAdapter1
            // 
            this.feedBacksTableAdapter1.ClearBeforeFill = true;
            // 
            // feedBackIdDataGridViewTextBoxColumn
            // 
            this.feedBackIdDataGridViewTextBoxColumn.DataPropertyName = "FeedBackId";
            this.feedBackIdDataGridViewTextBoxColumn.HeaderText = "FeedBackId";
            this.feedBackIdDataGridViewTextBoxColumn.Name = "feedBackIdDataGridViewTextBoxColumn";
            this.feedBackIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // qualityOfFoodDataGridViewTextBoxColumn
            // 
            this.qualityOfFoodDataGridViewTextBoxColumn.DataPropertyName = "QualityOfFood";
            this.qualityOfFoodDataGridViewTextBoxColumn.HeaderText = "QualityOfFood";
            this.qualityOfFoodDataGridViewTextBoxColumn.Name = "qualityOfFoodDataGridViewTextBoxColumn";
            // 
            // cleanlinessDataGridViewTextBoxColumn
            // 
            this.cleanlinessDataGridViewTextBoxColumn.DataPropertyName = "cleanliness";
            this.cleanlinessDataGridViewTextBoxColumn.HeaderText = "cleanliness";
            this.cleanlinessDataGridViewTextBoxColumn.Name = "cleanlinessDataGridViewTextBoxColumn";
            // 
            // overallQualityDataGridViewTextBoxColumn
            // 
            this.overallQualityDataGridViewTextBoxColumn.DataPropertyName = "OverallQuality";
            this.overallQualityDataGridViewTextBoxColumn.HeaderText = "OverallQuality";
            this.overallQualityDataGridViewTextBoxColumn.Name = "overallQualityDataGridViewTextBoxColumn";
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 420);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Feedback";
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.Feedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.feedBacksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteProjectFlamingoDataSet4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteProjectFlamingoDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBacksBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WebsiteProjectFlamingoDataSet4 websiteProjectFlamingoDataSet4;
        private System.Windows.Forms.BindingSource feedBacksBindingSource;
        private WebsiteProjectFlamingoDataSet4TableAdapters.FeedBacksTableAdapter feedBacksTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flamingoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderInPendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDeliveredToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAttendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAttendenceToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private WebsiteProjectFlamingoDataSet5 websiteProjectFlamingoDataSet5;
        private System.Windows.Forms.BindingSource feedBacksBindingSource1;
        private WebsiteProjectFlamingoDataSet5TableAdapters.FeedBacksTableAdapter feedBacksTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedBackIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualityOfFoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleanlinessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overallQualityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
    }
}