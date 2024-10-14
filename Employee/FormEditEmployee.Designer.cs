namespace KTDK_CanHo_DaoCongTri.Employee
{
    partial class FormEditEmployee
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
            panel2 = new Panel();
            txtDepartment = new TextBox();
            txtDate = new TextBox();
            txtSalary = new TextBox();
            cmbPosition = new ComboBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            panel1 = new Panel();
            label8 = new Label();
            label1 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            btnSave = new Button();
            btnClose = new Button();
            lblHead = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(txtDate);
            panel2.Controls.Add(txtSalary);
            panel2.Controls.Add(cmbPosition);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(txtId);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(256, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 509);
            panel2.TabIndex = 15;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(104, 430);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(383, 27);
            txtDepartment.TabIndex = 12;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(104, 303);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(383, 27);
            txtDate.TabIndex = 11;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(104, 367);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(383, 27);
            txtSalary.TabIndex = 9;
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "Human Resources (HR)", "Finance and Accounting", "Marketing and Sales", "Operations", "Research and Development (R&D)", "Information Technology (IT)", "Customer Service", "Legal", "Administration", "Strategic Planning" });
            cmbPosition.Location = new Point(104, 125);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(383, 28);
            cmbPosition.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(104, 245);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(383, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(104, 184);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(383, 27);
            txtPhone.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(104, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(383, 27);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(104, 15);
            txtId.Name = "txtId";
            txtId.Size = new Size(383, 27);
            txtId.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 509);
            panel1.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(58, 424);
            label8.Name = "label8";
            label8.Size = new Size(144, 31);
            label8.TabIndex = 14;
            label8.Text = "Department";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(58, 360);
            label1.Name = "label1";
            label1.Size = new Size(80, 31);
            label1.TabIndex = 13;
            label1.Text = "Salary";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(58, 297);
            label7.Name = "label7";
            label7.Size = new Size(110, 31);
            label7.TabIndex = 12;
            label7.Text = "HireDate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(58, 241);
            label6.Name = "label6";
            label6.Size = new Size(73, 31);
            label6.TabIndex = 11;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(58, 180);
            label5.Name = "label5";
            label5.Size = new Size(82, 31);
            label5.TabIndex = 10;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(58, 125);
            label4.Name = "label4";
            label4.Size = new Size(102, 31);
            label4.TabIndex = 9;
            label4.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(58, 67);
            label3.Name = "label3";
            label3.Size = new Size(77, 31);
            label3.TabIndex = 8;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(58, 11);
            label2.Name = "label2";
            label2.Size = new Size(35, 31);
            label2.TabIndex = 7;
            label2.Text = "Id";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnClose);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 559);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 125);
            panel3.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(457, 28);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(271, 72);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(58, 28);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(271, 72);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblHead
            // 
            lblHead.BackColor = SystemColors.Highlight;
            lblHead.BorderStyle = BorderStyle.Fixed3D;
            lblHead.Dock = DockStyle.Top;
            lblHead.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHead.ForeColor = SystemColors.ButtonHighlight;
            lblHead.Location = new Point(0, 0);
            lblHead.Name = "lblHead";
            lblHead.Size = new Size(800, 50);
            lblHead.TabIndex = 12;
            lblHead.Text = "Create New Employee";
            lblHead.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormEditEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 684);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(lblHead);
            MaximumSize = new Size(818, 731);
            MinimumSize = new Size(818, 731);
            Name = "FormEditEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEdit";
            Load += FormEditEmployee_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txtSalary;
        private ComboBox cmbPosition;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtName;
        private TextBox txtId;
        private Panel panel1;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Button btnSave;
        private Button btnClose;
        private Label lblHead;
        private TextBox txtDate;
        private TextBox txtDepartment;
        private Label label8;
    }
}