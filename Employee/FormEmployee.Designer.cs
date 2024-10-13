namespace KTDK_CanHo_DaoCongTri.Employee
{
    partial class FormEmployee
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
            dataGrv = new DataGridView();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            txtSearch = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            EmployeeId = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            EmployeePosition = new DataGridViewTextBoxColumn();
            EmployeeEmail = new DataGridViewTextBoxColumn();
            EmployeePhone = new DataGridViewTextBoxColumn();
            EmployeeHireDate = new DataGridViewTextBoxColumn();
            EmployeeSalary = new DataGridViewTextBoxColumn();
            EmployeeDepartment = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrv).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGrv);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(875, 325);
            panel2.TabIndex = 3;
            // 
            // dataGrv
            // 
            dataGrv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrv.Columns.AddRange(new DataGridViewColumn[] { EmployeeId, EmployeeName, EmployeePosition, EmployeeEmail, EmployeePhone, EmployeeHireDate, EmployeeSalary, EmployeeDepartment });
            dataGrv.Dock = DockStyle.Fill;
            dataGrv.Location = new Point(0, 0);
            dataGrv.Name = "dataGrv";
            dataGrv.RowHeadersWidth = 51;
            dataGrv.Size = new Size(875, 325);
            dataGrv.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 125);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnAdd);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(875, 125);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(491, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(384, 125);
            panel4.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(169, 46);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(212, 38);
            txtSearch.TabIndex = 1;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 44);
            label1.Name = "label1";
            label1.Size = new Size(100, 38);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Highlight;
            btnDelete.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(287, 29);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 67);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.Highlight;
            btnEdit.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(145, 29);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(126, 67);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Highlight;
            btnAdd.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(12, 29);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 67);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // EmployeeId
            // 
            EmployeeId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeId.DataPropertyName = "EmployeeId";
            EmployeeId.HeaderText = "Id";
            EmployeeId.MinimumWidth = 6;
            EmployeeId.Name = "EmployeeId";
            // 
            // EmployeeName
            // 
            EmployeeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeName.DataPropertyName = "EmployeeName";
            EmployeeName.HeaderText = "Name";
            EmployeeName.MinimumWidth = 6;
            EmployeeName.Name = "EmployeeName";
            // 
            // EmployeePosition
            // 
            EmployeePosition.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeePosition.DataPropertyName = "EmployeePosition";
            EmployeePosition.HeaderText = "Position";
            EmployeePosition.MinimumWidth = 6;
            EmployeePosition.Name = "EmployeePosition";
            // 
            // EmployeeEmail
            // 
            EmployeeEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeEmail.DataPropertyName = "EmployeeEmail";
            EmployeeEmail.HeaderText = "Email";
            EmployeeEmail.MinimumWidth = 6;
            EmployeeEmail.Name = "EmployeeEmail";
            // 
            // EmployeePhone
            // 
            EmployeePhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeePhone.DataPropertyName = "EmployeePhone";
            EmployeePhone.HeaderText = "Phone";
            EmployeePhone.MinimumWidth = 6;
            EmployeePhone.Name = "EmployeePhone";
            // 
            // EmployeeHireDate
            // 
            EmployeeHireDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeHireDate.DataPropertyName = "EmployeeHireDate";
            EmployeeHireDate.HeaderText = "HireDate";
            EmployeeHireDate.MinimumWidth = 6;
            EmployeeHireDate.Name = "EmployeeHireDate";
            // 
            // EmployeeSalary
            // 
            EmployeeSalary.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeSalary.DataPropertyName = "EmployeeSalary";
            EmployeeSalary.HeaderText = "Salary";
            EmployeeSalary.MinimumWidth = 6;
            EmployeeSalary.Name = "EmployeeSalary";
            // 
            // EmployeeDepartment
            // 
            EmployeeDepartment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeDepartment.DataPropertyName = "EmployeeDepartment";
            EmployeeDepartment.HeaderText = "Department";
            EmployeeDepartment.MinimumWidth = 6;
            EmployeeDepartment.Name = "EmployeeDepartment";
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormEmployee";
            Text = "FormEmployee";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrv).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGrv;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtSearch;
        private Label label1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridViewTextBoxColumn EmployeeId;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn EmployeePosition;
        private DataGridViewTextBoxColumn EmployeeEmail;
        private DataGridViewTextBoxColumn EmployeePhone;
        private DataGridViewTextBoxColumn EmployeeHireDate;
        private DataGridViewTextBoxColumn EmployeeSalary;
        private DataGridViewTextBoxColumn EmployeeDepartment;
    }
}