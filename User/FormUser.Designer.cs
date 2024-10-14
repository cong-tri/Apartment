namespace KTDK_CanHo_DaoCongTri.User
{
    partial class FormUser
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
            datagv = new DataGridView();
            UserId = new DataGridViewTextBoxColumn();
            CustomerId = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            Fullname = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            LastloginDate = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            txtSearch = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            btnExit = new Button();
            label1 = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)datagv).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // datagv
            // 
            datagv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagv.Columns.AddRange(new DataGridViewColumn[] { UserId, CustomerId, Username, Password, Role, Fullname, Email, LastloginDate });
            datagv.Dock = DockStyle.Fill;
            datagv.Location = new Point(151, 59);
            datagv.Name = "datagv";
            datagv.RowHeadersWidth = 51;
            datagv.Size = new Size(762, 400);
            datagv.TabIndex = 5;
            // 
            // UserId
            // 
            UserId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserId.DataPropertyName = "UserId";
            UserId.HeaderText = "UserId";
            UserId.MinimumWidth = 6;
            UserId.Name = "UserId";
            // 
            // CustomerId
            // 
            CustomerId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerId.DataPropertyName = "CustomerId";
            CustomerId.HeaderText = "CustomerId";
            CustomerId.MinimumWidth = 6;
            CustomerId.Name = "CustomerId";
            // 
            // Username
            // 
            Username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Username.DataPropertyName = "Username";
            Username.HeaderText = "UserName";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            // 
            // Role
            // 
            Role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Role.DataPropertyName = "Role";
            Role.HeaderText = "Role";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            // 
            // Fullname
            // 
            Fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Fullname.DataPropertyName = "Fullname";
            Fullname.HeaderText = "FullName";
            Fullname.MinimumWidth = 6;
            Fullname.Name = "Fullname";
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // LastloginDate
            // 
            LastloginDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LastloginDate.DataPropertyName = "LastloginDate";
            LastloginDate.HeaderText = "LastLoginDate";
            LastloginDate.MinimumWidth = 6;
            LastloginDate.Name = "LastloginDate";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(151, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(762, 59);
            panel2.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(95, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(600, 27);
            txtSearch.TabIndex = 1;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(6, 15);
            label2.Name = "label2";
            label2.Size = new Size(87, 31);
            label2.TabIndex = 0;
            label2.Text = "Search:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(151, 459);
            panel1.TabIndex = 3;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Historic", 13.8F);
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(12, 263);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(121, 51);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 24F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuBar;
            label1.Location = new Point(25, 8);
            label1.Name = "label1";
            label1.Size = new Size(89, 40);
            label1.TabIndex = 5;
            label1.Text = "User";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Historic", 13.8F);
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(12, 194);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 51);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Historic", 13.8F);
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(12, 127);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(121, 51);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Historic", 13.8F);
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(12, 59);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 48);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 459);
            Controls.Add(datagv);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormUser";
            Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)datagv).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView datagv;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn CustomerId;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn Fullname;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn LastloginDate;
        private Panel panel2;
        private TextBox txtSearch;
        private Label label2;
        private Panel panel1;
        private Button btnExit;
        private Label label1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}