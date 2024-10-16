namespace KTDK_CanHo_DaoCongTri.Contract
{
    partial class FormContract
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
            panel2 = new Panel();
            label2 = new Label();
            searchkey_tb = new TextBox();
            label1 = new Label();
            delete_btn = new Button();
            update_btn = new Button();
            add_btn = new Button();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            ContractId = new DataGridViewTextBoxColumn();
            ApartmentId = new DataGridViewTextBoxColumn();
            CustomerId = new DataGridViewTextBoxColumn();
            Startdate = new DataGridViewTextBoxColumn();
            Enddate = new DataGridViewTextBoxColumn();
            MonthlyRent = new DataGridViewTextBoxColumn();
            DepositAmount = new DataGridViewTextBoxColumn();
            ContractStatus = new DataGridViewTextBoxColumn();
            RenewalOption = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(delete_btn);
            panel1.Controls.Add(update_btn);
            panel1.Controls.Add(add_btn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 61);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(searchkey_tb);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(860, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 55);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(415, -3);
            label2.Name = "label2";
            label2.Size = new Size(25, 28);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // searchkey_tb
            // 
            searchkey_tb.Location = new Point(91, 14);
            searchkey_tb.Name = "searchkey_tb";
            searchkey_tb.Size = new Size(294, 27);
            searchkey_tb.TabIndex = 1;
            searchkey_tb.KeyPress += searchkey_tb_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 1;
            label1.Text = "SEARCH";
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(281, 12);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(94, 38);
            delete_btn.TabIndex = 3;
            delete_btn.Text = "DELETE";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(165, 12);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(94, 38);
            update_btn.TabIndex = 2;
            update_btn.Text = "UPDATE";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // add_btn
            // 
            add_btn.Location = new Point(45, 12);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(94, 38);
            add_btn.TabIndex = 1;
            add_btn.Text = "ADD";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(589, 70);
            label3.Name = "label3";
            label3.Size = new Size(134, 31);
            label3.TabIndex = 2;
            label3.Text = "CONTRACT";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ContractId, ApartmentId, CustomerId, Startdate, Enddate, MonthlyRent, DepositAmount, ContractStatus, RenewalOption });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1300, 511);
            dataGridView1.TabIndex = 3;
            // 
            // ContractId
            // 
            ContractId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ContractId.DataPropertyName = "ContractId";
            ContractId.HeaderText = "Id";
            ContractId.MinimumWidth = 6;
            ContractId.Name = "ContractId";
            // 
            // ApartmentId
            // 
            ApartmentId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ApartmentId.DataPropertyName = "ApartmentId";
            ApartmentId.HeaderText = "ApartmentId";
            ApartmentId.MinimumWidth = 6;
            ApartmentId.Name = "ApartmentId";
            // 
            // CustomerId
            // 
            CustomerId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerId.DataPropertyName = "CustomerId";
            CustomerId.HeaderText = "CustomerId";
            CustomerId.MinimumWidth = 6;
            CustomerId.Name = "CustomerId";
            // 
            // Startdate
            // 
            Startdate.DataPropertyName = "Startdate";
            Startdate.HeaderText = "Startdate";
            Startdate.MinimumWidth = 6;
            Startdate.Name = "Startdate";
            Startdate.Width = 125;
            // 
            // Enddate
            // 
            Enddate.DataPropertyName = "Enddate";
            Enddate.HeaderText = "Enddate";
            Enddate.MinimumWidth = 6;
            Enddate.Name = "Enddate";
            Enddate.Width = 125;
            // 
            // MonthlyRent
            // 
            MonthlyRent.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MonthlyRent.DataPropertyName = "MonthlyRent";
            MonthlyRent.HeaderText = "MonthlyRent";
            MonthlyRent.MinimumWidth = 6;
            MonthlyRent.Name = "MonthlyRent";
            // 
            // DepositAmount
            // 
            DepositAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DepositAmount.DataPropertyName = "DepositAmount";
            DepositAmount.HeaderText = "Amount";
            DepositAmount.MinimumWidth = 6;
            DepositAmount.Name = "DepositAmount";
            // 
            // ContractStatus
            // 
            ContractStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ContractStatus.DataPropertyName = "ContractStatus";
            ContractStatus.HeaderText = "Status";
            ContractStatus.MinimumWidth = 6;
            ContractStatus.Name = "ContractStatus";
            // 
            // RenewalOption
            // 
            RenewalOption.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RenewalOption.DataPropertyName = "RenewalOption";
            RenewalOption.HeaderText = "Option";
            RenewalOption.MinimumWidth = 6;
            RenewalOption.Name = "RenewalOption";
            // 
            // FormContract
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 615);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "FormContract";
            Text = "FormContract";
            Load += FormContract_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private TextBox searchkey_tb;
        private Label label1;
        private Button delete_btn;
        private Button update_btn;
        private Button add_btn;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ContractId;
        private DataGridViewTextBoxColumn ApartmentId;
        private DataGridViewTextBoxColumn CustomerId;
        private DataGridViewTextBoxColumn Startdate;
        private DataGridViewTextBoxColumn Enddate;
        private DataGridViewTextBoxColumn MonthlyRent;
        private DataGridViewTextBoxColumn DepositAmount;
        private DataGridViewTextBoxColumn ContractStatus;
        private DataGridViewTextBoxColumn RenewalOption;
    }
}