namespace KTDK_CanHo_DaoCongTri.User
{
    partial class FormEditUser
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
            panel1 = new Panel();
            txtCustomerId = new TextBox();
            label9 = new Label();
            txtLastLoginDate = new TextBox();
            label7 = new Label();
            btnSave = new Button();
            btnExit = new Button();
            label8 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtFullName = new TextBox();
            label5 = new Label();
            txtRole = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUserName = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtCustomerId);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtLastLoginDate);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtRole);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 450);
            panel1.TabIndex = 1;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(167, 95);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(112, 27);
            txtCustomerId.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Enabled = false;
            label9.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold | FontStyle.Underline);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(34, 93);
            label9.Name = "label9";
            label9.Size = new Size(123, 28);
            label9.TabIndex = 22;
            label9.Text = "CustomerId";
            // 
            // txtLastLoginDate
            // 
            txtLastLoginDate.Location = new Point(165, 334);
            txtLastLoginDate.Name = "txtLastLoginDate";
            txtLastLoginDate.Size = new Size(156, 27);
            txtLastLoginDate.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Font = new Font("Segoe UI Historic", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(67, 9);
            label7.Name = "label7";
            label7.Size = new Size(271, 50);
            label7.TabIndex = 20;
            label7.Text = "Add - Edit User";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Historic", 13.8F);
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(55, 376);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(145, 41);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Historic", 13.8F);
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(264, 376);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(143, 41);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold | FontStyle.Underline);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(12, 334);
            label8.Name = "label8";
            label8.Size = new Size(149, 28);
            label8.TabIndex = 14;
            label8.Text = "LastLoginDate";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(165, 294);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(242, 27);
            txtEmail.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold | FontStyle.Underline);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(93, 294);
            label6.Name = "label6";
            label6.Size = new Size(64, 28);
            label6.TabIndex = 10;
            label6.Text = "Email";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(165, 253);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(193, 27);
            txtFullName.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold | FontStyle.Underline);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(55, 253);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 8;
            label5.Text = "FullName";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(165, 212);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(156, 27);
            txtRole.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold | FontStyle.Underline);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(101, 212);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 6;
            label4.Text = "Role";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(167, 171);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(191, 27);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold | FontStyle.Underline);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(53, 171);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(167, 130);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(154, 27);
            txtUserName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold | FontStyle.Underline);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(45, 130);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 2;
            label2.Text = "UserName";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(167, 60);
            txtId.Name = "txtId";
            txtId.Size = new Size(66, 27);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold | FontStyle.Underline);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(80, 58);
            label1.Name = "label1";
            label1.Size = new Size(74, 28);
            label1.TabIndex = 0;
            label1.Text = "UserId";
            // 
            // FormEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 450);
            Controls.Add(panel1);
            MaximumSize = new Size(485, 497);
            MinimumSize = new Size(485, 497);
            Name = "FormEditUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtCustomerId;
        private Label label9;
        private TextBox txtLastLoginDate;
        private Label label7;
        private Button btnSave;
        private Button btnExit;
        private Label label8;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtFullName;
        private Label label5;
        private TextBox txtRole;
        private Label label4;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUserName;
        private Label label2;
        private TextBox txtId;
        private Label label1;
    }
}