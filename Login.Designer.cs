namespace FlamingoWF
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ForgetPasswordButton = new System.Windows.Forms.Button();
            this.Login_password = new System.Windows.Forms.TextBox();
            this.Login_username = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.s = new System.Windows.Forms.GroupBox();
            this.Login_role = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(114, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(114, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(180, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Welcome to Flamingo";
            // 
            // ForgetPasswordButton
            // 
            this.ForgetPasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ForgetPasswordButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ForgetPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ForgetPasswordButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPasswordButton.Location = new System.Drawing.Point(284, 241);
            this.ForgetPasswordButton.Name = "ForgetPasswordButton";
            this.ForgetPasswordButton.Size = new System.Drawing.Size(117, 41);
            this.ForgetPasswordButton.TabIndex = 4;
            this.ForgetPasswordButton.Text = "ForgetPassword";
            this.ForgetPasswordButton.UseVisualStyleBackColor = false;
            this.ForgetPasswordButton.Click += new System.EventHandler(this.ForgetPasswordButton_Click);
            // 
            // Login_password
            // 
            this.Login_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_password.Location = new System.Drawing.Point(177, 66);
            this.Login_password.Name = "Login_password";
            this.Login_password.PasswordChar = '*';
            this.Login_password.Size = new System.Drawing.Size(234, 20);
            this.Login_password.TabIndex = 3;
            // 
            // Login_username
            // 
            this.Login_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login_username.Location = new System.Drawing.Point(177, 31);
            this.Login_username.Name = "Login_username";
            this.Login_username.Size = new System.Drawing.Size(234, 20);
            this.Login_username.TabIndex = 2;
            this.Login_username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(407, 241);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(84, 41);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel1.Text = "Login";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(564, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(-4, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Note :To Proceed Please Enter Username and Password";
            // 
            // s
            // 
            this.s.Controls.Add(this.Login_role);
            this.s.Controls.Add(this.label5);
            this.s.Controls.Add(this.pictureBox1);
            this.s.Controls.Add(this.label1);
            this.s.Controls.Add(this.label2);
            this.s.Controls.Add(this.Login_username);
            this.s.Controls.Add(this.Login_password);
            this.s.Location = new System.Drawing.Point(68, 64);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(446, 151);
            this.s.TabIndex = 11;
            this.s.TabStop = false;
            // 
            // Login_role
            // 
            this.Login_role.FormattingEnabled = true;
            this.Login_role.Items.AddRange(new object[] {
            "Admin",
            "Regular"});
            this.Login_role.Location = new System.Drawing.Point(177, 99);
            this.Login_role.Name = "Login_role";
            this.Login_role.Size = new System.Drawing.Size(234, 21);
            this.Login_role.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(116, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Role";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlamingoWF.Properties.Resources.User_blue_icon;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CreateUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateUserButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUserButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateUserButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CreateUserButton.Location = new System.Drawing.Point(74, 241);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(187, 41);
            this.CreateUserButton.TabIndex = 12;
            this.CreateUserButton.Text = "Create New User";
            this.CreateUserButton.UseVisualStyleBackColor = false;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(564, 384);
            this.Controls.Add(this.CreateUserButton);
            this.Controls.Add(this.s);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ForgetPasswordButton);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ForgetPasswordButton;
        private System.Windows.Forms.TextBox Login_password;
        private System.Windows.Forms.TextBox Login_username;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox s;
        private System.Windows.Forms.Button CreateUserButton;
        private System.Windows.Forms.ComboBox Login_role;
        private System.Windows.Forms.Label label5;
    }
}