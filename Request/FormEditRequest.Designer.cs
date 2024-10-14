namespace KTDK_CanHo_DaoCongTri.Request
{
    partial class FormEditRequest
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
            cmbEmp = new ComboBox();
            cmbStatus = new ComboBox();
            cmbApartment = new ComboBox();
            txtCost = new TextBox();
            txtCompleDate = new TextBox();
            txtDesc = new TextBox();
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
            textBox1 = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(cmbEmp);
            panel2.Controls.Add(cmbStatus);
            panel2.Controls.Add(cmbApartment);
            panel2.Controls.Add(txtCost);
            panel2.Controls.Add(txtCompleDate);
            panel2.Controls.Add(txtDesc);
            panel2.Controls.Add(txtId);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(256, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 484);
            panel2.TabIndex = 19;
            // 
            // cmbEmp
            // 
            cmbEmp.FormattingEnabled = true;
            cmbEmp.Location = new Point(104, 131);
            cmbEmp.Name = "cmbEmp";
            cmbEmp.Size = new Size(383, 28);
            cmbEmp.TabIndex = 15;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Prepare Progress", "In Progress", "Finish Progress" });
            cmbStatus.Location = new Point(104, 303);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(383, 28);
            cmbStatus.TabIndex = 14;
            // 
            // cmbApartment
            // 
            cmbApartment.FormattingEnabled = true;
            cmbApartment.Location = new Point(104, 73);
            cmbApartment.Name = "cmbApartment";
            cmbApartment.Size = new Size(383, 28);
            cmbApartment.TabIndex = 13;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(104, 430);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(383, 27);
            txtCost.TabIndex = 12;
            // 
            // txtCompleDate
            // 
            txtCompleDate.Location = new Point(104, 367);
            txtCompleDate.Name = "txtCompleDate";
            txtCompleDate.Size = new Size(383, 27);
            txtCompleDate.TabIndex = 9;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(104, 184);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(383, 27);
            txtDesc.TabIndex = 3;
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
            panel1.Size = new Size(250, 484);
            panel1.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(58, 424);
            label8.Name = "label8";
            label8.Size = new Size(61, 31);
            label8.TabIndex = 14;
            label8.Text = "Cost";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(58, 360);
            label1.Name = "label1";
            label1.Size = new Size(190, 31);
            label1.TabIndex = 13;
            label1.Text = "CompletionDate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(58, 297);
            label7.Name = "label7";
            label7.Size = new Size(80, 31);
            label7.TabIndex = 12;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(58, 241);
            label6.Name = "label6";
            label6.Size = new Size(64, 31);
            label6.TabIndex = 11;
            label6.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(58, 180);
            label5.Name = "label5";
            label5.Size = new Size(138, 31);
            label5.TabIndex = 10;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(58, 125);
            label4.Name = "label4";
            label4.Size = new Size(139, 31);
            label4.TabIndex = 9;
            label4.Text = "EmployeeId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(58, 67);
            label3.Name = "label3";
            label3.Size = new Size(152, 31);
            label3.TabIndex = 8;
            label3.Text = "ApartmentId";
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
            panel3.Location = new Point(0, 534);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 125);
            panel3.TabIndex = 17;
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
            lblHead.TabIndex = 16;
            lblHead.Text = "Create New Request";
            lblHead.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 247);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 27);
            textBox1.TabIndex = 16;
            // 
            // FormEditRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 659);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(lblHead);
            Name = "FormEditRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditRequest";
            Load += FormEditRequest_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txtCost;
        private TextBox txtDate;
        private TextBox txtCompleDate;
        private ComboBox cmbPosition;
        private TextBox txtDesc;
        private TextBox txtId;
        private Panel panel1;
        private Label label8;
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
        private ComboBox cmbApartment;
        private ComboBox cmbStatus;
        private ComboBox cmbEmp;
        private TextBox textBox1;
    }
}