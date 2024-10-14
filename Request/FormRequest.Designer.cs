namespace KTDK_CanHo_DaoCongTri.Request
{
    partial class FormRequest
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
            RequestId = new DataGridViewTextBoxColumn();
            ApartmentId = new DataGridViewTextBoxColumn();
            EmployeeId = new DataGridViewTextBoxColumn();
            RequestDescription = new DataGridViewTextBoxColumn();
            RequestDate = new DataGridViewTextBoxColumn();
            RequestStatus = new DataGridViewTextBoxColumn();
            RequestCompletionDate = new DataGridViewTextBoxColumn();
            RequestCost = new DataGridViewTextBoxColumn();
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
            panel2.Size = new Size(872, 325);
            panel2.TabIndex = 3;
            // 
            // dataGrv
            // 
            dataGrv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrv.Columns.AddRange(new DataGridViewColumn[] { RequestId, ApartmentId, EmployeeId, RequestDescription, RequestDate, RequestStatus, RequestCompletionDate, RequestCost });
            dataGrv.Dock = DockStyle.Fill;
            dataGrv.Location = new Point(0, 0);
            dataGrv.Name = "dataGrv";
            dataGrv.RowHeadersWidth = 51;
            dataGrv.Size = new Size(872, 325);
            dataGrv.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(872, 125);
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
            panel3.Size = new Size(872, 125);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(488, 0);
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
            // RequestId
            // 
            RequestId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RequestId.DataPropertyName = "RequestId";
            RequestId.HeaderText = "Id";
            RequestId.MinimumWidth = 6;
            RequestId.Name = "RequestId";
            // 
            // ApartmentId
            // 
            ApartmentId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ApartmentId.DataPropertyName = "ApartmentId";
            ApartmentId.HeaderText = "ApartmentId";
            ApartmentId.MinimumWidth = 6;
            ApartmentId.Name = "ApartmentId";
            // 
            // EmployeeId
            // 
            EmployeeId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeId.DataPropertyName = "EmployeeId";
            EmployeeId.HeaderText = "EmployeeId";
            EmployeeId.MinimumWidth = 6;
            EmployeeId.Name = "EmployeeId";
            // 
            // RequestDescription
            // 
            RequestDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RequestDescription.DataPropertyName = "RequestDescription";
            RequestDescription.HeaderText = "Description";
            RequestDescription.MinimumWidth = 6;
            RequestDescription.Name = "RequestDescription";
            // 
            // RequestDate
            // 
            RequestDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RequestDate.DataPropertyName = "RequestDate";
            RequestDate.HeaderText = "Date";
            RequestDate.MinimumWidth = 6;
            RequestDate.Name = "RequestDate";
            // 
            // RequestStatus
            // 
            RequestStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RequestStatus.DataPropertyName = "RequestStatus";
            RequestStatus.HeaderText = "Status";
            RequestStatus.MinimumWidth = 6;
            RequestStatus.Name = "RequestStatus";
            // 
            // RequestCompletionDate
            // 
            RequestCompletionDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RequestCompletionDate.DataPropertyName = "RequestCompletionDate";
            RequestCompletionDate.HeaderText = "CompletionDate";
            RequestCompletionDate.MinimumWidth = 6;
            RequestCompletionDate.Name = "RequestCompletionDate";
            // 
            // RequestCost
            // 
            RequestCost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RequestCost.DataPropertyName = "RequestCost";
            RequestCost.HeaderText = "Cost";
            RequestCost.MinimumWidth = 6;
            RequestCost.Name = "RequestCost";
            // 
            // FormRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRequest";
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
        private DataGridViewTextBoxColumn RequestId;
        private DataGridViewTextBoxColumn ApartmentId;
        private DataGridViewTextBoxColumn EmployeeId;
        private DataGridViewTextBoxColumn RequestDescription;
        private DataGridViewTextBoxColumn RequestDate;
        private DataGridViewTextBoxColumn RequestStatus;
        private DataGridViewTextBoxColumn RequestCompletionDate;
        private DataGridViewTextBoxColumn RequestCost;
    }
}