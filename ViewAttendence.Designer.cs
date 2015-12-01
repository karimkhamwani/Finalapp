namespace FlamingoWF
{
    partial class ViewAttendence
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flamingoWindowsapplicationDbDataSet = new FlamingoWF.flamingoWindowsapplicationDbDataSet();
            this.attendenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendenceTableAdapter = new FlamingoWF.flamingoWindowsapplicationDbDataSetTableAdapters.AttendenceTableAdapter();
            this.fkEmployeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flamingoWindowsapplicationDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendenceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fkEmployeeIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendenceBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(346, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // flamingoWindowsapplicationDbDataSet
            // 
            this.flamingoWindowsapplicationDbDataSet.DataSetName = "flamingoWindowsapplicationDbDataSet";
            this.flamingoWindowsapplicationDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendenceBindingSource
            // 
            this.attendenceBindingSource.DataMember = "Attendence";
            this.attendenceBindingSource.DataSource = this.flamingoWindowsapplicationDbDataSet;
            // 
            // attendenceTableAdapter
            // 
            this.attendenceTableAdapter.ClearBeforeFill = true;
            // 
            // fkEmployeeIdDataGridViewTextBoxColumn
            // 
            this.fkEmployeeIdDataGridViewTextBoxColumn.DataPropertyName = "fk_EmployeeId";
            this.fkEmployeeIdDataGridViewTextBoxColumn.HeaderText = "fk_EmployeeId";
            this.fkEmployeeIdDataGridViewTextBoxColumn.Name = "fkEmployeeIdDataGridViewTextBoxColumn";
            this.fkEmployeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkEmployeeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ViewAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 320);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewAttendence";
            this.Text = "ViewAttendence";
            this.Load += new System.EventHandler(this.ViewAttendence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flamingoWindowsapplicationDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendenceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private flamingoWindowsapplicationDbDataSet flamingoWindowsapplicationDbDataSet;
        private System.Windows.Forms.BindingSource attendenceBindingSource;
        private flamingoWindowsapplicationDbDataSetTableAdapters.AttendenceTableAdapter attendenceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkEmployeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}