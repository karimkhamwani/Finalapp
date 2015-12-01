namespace FlamingoWF
{
    partial class SearchByorderId
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
            this.SearchByorderid_EnterOrderid = new System.Windows.Forms.TextBox();
            this.Proceed = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
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
            this.orderOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderInPendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDeliveredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Order Id";
            // 
            // SearchByorderid_EnterOrderid
            // 
            this.SearchByorderid_EnterOrderid.Location = new System.Drawing.Point(136, 72);
            this.SearchByorderid_EnterOrderid.Name = "SearchByorderid_EnterOrderid";
            this.SearchByorderid_EnterOrderid.Size = new System.Drawing.Size(100, 20);
            this.SearchByorderid_EnterOrderid.TabIndex = 1;
            // 
            // Proceed
            // 
            this.Proceed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Proceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Proceed.Location = new System.Drawing.Point(161, 185);
            this.Proceed.Name = "Proceed";
            this.Proceed.Size = new System.Drawing.Size(75, 29);
            this.Proceed.TabIndex = 2;
            this.Proceed.Text = "Procced";
            this.Proceed.UseVisualStyleBackColor = false;
            this.Proceed.Click += new System.EventHandler(this.Proceed_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 230);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(265, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Search";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(80, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flamingoToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(265, 24);
            this.menuStrip1.TabIndex = 5;
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
            // 
            // viewAttendenceToolStripMenuItem
            // 
            this.viewAttendenceToolStripMenuItem.Name = "viewAttendenceToolStripMenuItem";
            this.viewAttendenceToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.viewAttendenceToolStripMenuItem.Text = "View Attendence";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderOnlineToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // orderOnlineToolStripMenuItem
            // 
            this.orderOnlineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderInPendingToolStripMenuItem,
            this.orderDeliveredToolStripMenuItem});
            this.orderOnlineToolStripMenuItem.Name = "orderOnlineToolStripMenuItem";
            this.orderOnlineToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.orderOnlineToolStripMenuItem.Text = "Order Online";
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
            // SearchByorderId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(265, 252);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Proceed);
            this.Controls.Add(this.SearchByorderid_EnterOrderid);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SearchByorderId";
            this.Text = "SearchByorderId";
            this.Load += new System.EventHandler(this.SearchByorderId_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchByorderid_EnterOrderid;
        private System.Windows.Forms.Button Proceed;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flamingoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAttendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAttendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderInPendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDeliveredToolStripMenuItem;
    }
}