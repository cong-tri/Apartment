namespace KTDK_CanHo_DaoCongTri.Transaction
{
    partial class Frm_transactioncs
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
            TransactionId = new DataGridViewTextBoxColumn();
            ContractId = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            TransactionDate = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            TransactionType = new DataGridViewTextBoxColumn();
            PaymentMethod = new DataGridViewTextBoxColumn();
            IssuedBy = new DataGridViewTextBoxColumn();
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
            panel1.Size = new Size(1034, 61);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(searchkey_tb);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(594, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 61);
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
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(0, 61);
            label3.Name = "label3";
            label3.Size = new Size(1034, 59);
            label3.TabIndex = 3;
            label3.Text = "FINANCIAL TRANSACTION";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TransactionId, ContractId, Amount, TransactionDate, Description, TransactionType, PaymentMethod, IssuedBy });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1034, 395);
            dataGridView1.TabIndex = 4;
            // 
            // TransactionId
            // 
            TransactionId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TransactionId.DataPropertyName = "TransactionId";
            TransactionId.HeaderText = "Id";
            TransactionId.MinimumWidth = 6;
            TransactionId.Name = "TransactionId";
            // 
            // ContractId
            // 
            ContractId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ContractId.DataPropertyName = "ContractId";
            ContractId.HeaderText = "ContractId";
            ContractId.MinimumWidth = 6;
            ContractId.Name = "ContractId";
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            // 
            // TransactionDate
            // 
            TransactionDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TransactionDate.DataPropertyName = "TransactionDate";
            TransactionDate.HeaderText = "TransactionDate";
            TransactionDate.MinimumWidth = 6;
            TransactionDate.Name = "TransactionDate";
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            // 
            // TransactionType
            // 
            TransactionType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TransactionType.DataPropertyName = "TransactionType";
            TransactionType.HeaderText = "TransactionType";
            TransactionType.MinimumWidth = 6;
            TransactionType.Name = "TransactionType";
            // 
            // PaymentMethod
            // 
            PaymentMethod.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PaymentMethod.DataPropertyName = "PaymentMethod";
            PaymentMethod.HeaderText = "PaymentMethod";
            PaymentMethod.MinimumWidth = 6;
            PaymentMethod.Name = "PaymentMethod";
            // 
            // IssuedBy
            // 
            IssuedBy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IssuedBy.DataPropertyName = "IssuedBy";
            IssuedBy.HeaderText = "IssuedBy";
            IssuedBy.MinimumWidth = 6;
            IssuedBy.Name = "IssuedBy";
            // 
            // Frm_transactioncs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 518);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Frm_transactioncs";
            Text = "Frm_transactioncs";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
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
        private DataGridViewTextBoxColumn TransactionId;
        private DataGridViewTextBoxColumn ContractId;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn TransactionDate;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn TransactionType;
        private DataGridViewTextBoxColumn PaymentMethod;
        private DataGridViewTextBoxColumn IssuedBy;
    }
}