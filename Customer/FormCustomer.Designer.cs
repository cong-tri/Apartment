namespace KTDK_CanHo_DaoCongTri.Customer
{
    partial class FormCustomer
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
            datagvC = new DataGridView();
            CustomerId = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Dateofbirth = new DataGridViewTextBoxColumn();
            IdentificationNumber = new DataGridViewTextBoxColumn();
            Customersince = new DataGridViewTextBoxColumn();
            label2 = new Label();
            txtSearch = new TextBox();
            panel2 = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            label1 = new Label();
            btnAdd = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)datagvC).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // datagvC
            // 
            datagvC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagvC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagvC.Columns.AddRange(new DataGridViewColumn[] { CustomerId, Name, Phone, Email, Address, Dateofbirth, IdentificationNumber, Customersince });
            datagvC.Dock = DockStyle.Fill;
            datagvC.Location = new Point(167, 63);
            datagvC.Name = "datagvC";
            datagvC.RowHeadersWidth = 51;
            datagvC.Size = new Size(739, 387);
            datagvC.TabIndex = 5;
            // 
            // CustomerId
            // 
            CustomerId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerId.DataPropertyName = "CustomerId";
            CustomerId.HeaderText = "Id";
            CustomerId.MinimumWidth = 6;
            CustomerId.Name = "CustomerId";
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            // 
            // Phone
            // 
            Phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            // 
            // Dateofbirth
            // 
            Dateofbirth.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dateofbirth.DataPropertyName = "Dateofbirth";
            Dateofbirth.HeaderText = "DOB";
            Dateofbirth.MinimumWidth = 6;
            Dateofbirth.Name = "Dateofbirth";
            // 
            // IdentificationNumber
            // 
            IdentificationNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IdentificationNumber.DataPropertyName = "IdentificationNumber";
            IdentificationNumber.HeaderText = "IdentificationNumber";
            IdentificationNumber.MinimumWidth = 6;
            IdentificationNumber.Name = "IdentificationNumber";
            // 
            // Customersince
            // 
            Customersince.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Customersince.DataPropertyName = "Customersince";
            Customersince.HeaderText = "CustomerSince";
            Customersince.MinimumWidth = 6;
            Customersince.Name = "Customersince";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(16, 19);
            label2.Name = "label2";
            label2.Size = new Size(87, 31);
            label2.TabIndex = 2;
            label2.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(109, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(630, 27);
            txtSearch.TabIndex = 1;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(167, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(739, 63);
            panel2.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Historic", 13.8F);
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(12, 201);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 55);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Historic", 13.8F);
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(12, 132);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(149, 55);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 24F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(0, 11);
            label1.Name = "label1";
            label1.Size = new Size(164, 40);
            label1.TabIndex = 6;
            label1.Text = "Customer";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Historic", 13.8F);
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(12, 63);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 55);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 450);
            panel1.TabIndex = 3;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 450);
            Controls.Add(datagvC);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Text = "FormCustomer";
            ((System.ComponentModel.ISupportInitialize)datagvC).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView datagvC;
        private DataGridViewTextBoxColumn CustomerId;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Dateofbirth;
        private DataGridViewTextBoxColumn IdentificationNumber;
        private DataGridViewTextBoxColumn Customersince;
        private Label label2;
        private TextBox txtSearch;
        private Panel panel2;
        private Button btnDelete;
        private Button btnEdit;
        private Label label1;
        private Button btnAdd;
        private Panel panel1;
    }
}