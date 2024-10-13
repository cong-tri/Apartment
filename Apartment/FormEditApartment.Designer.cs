namespace KTDK_CanHo_DaoCongTri
{
    partial class FormEditApartment
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
            lblHead = new Label();
            panel3 = new Panel();
            btnSave = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label1 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            txtPrice = new TextBox();
            txtRooms = new TextBox();
            cmbStatus = new ComboBox();
            cmbType = new ComboBox();
            radioBtnFalse = new RadioButton();
            radioBtnTrue = new RadioButton();
            txtArea = new TextBox();
            txtName = new TextBox();
            txtFloor = new TextBox();
            txtNumber = new TextBox();
            txtId = new TextBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            lblHead.Size = new Size(785, 50);
            lblHead.TabIndex = 0;
            lblHead.Text = "Create New Apartment";
            lblHead.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnClose);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 628);
            panel3.Name = "panel3";
            panel3.Size = new Size(785, 125);
            panel3.TabIndex = 9;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
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
            panel1.Size = new Size(250, 578);
            panel1.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(58, 527);
            label10.Name = "label10";
            label10.Size = new Size(151, 31);
            label10.TabIndex = 16;
            label10.Text = "Montly Price";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(58, 465);
            label9.Name = "label9";
            label9.Size = new Size(145, 31);
            label9.TabIndex = 15;
            label9.Text = "Has Balcony";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(58, 416);
            label8.Name = "label8";
            label8.Size = new Size(64, 31);
            label8.TabIndex = 14;
            label8.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(58, 360);
            label1.Name = "label1";
            label1.Size = new Size(87, 31);
            label1.TabIndex = 13;
            label1.Text = "Rooms";
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
            label6.Size = new Size(63, 31);
            label6.TabIndex = 11;
            label6.Text = "Area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(58, 180);
            label5.Name = "label5";
            label5.Size = new Size(77, 31);
            label5.TabIndex = 10;
            label5.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(58, 125);
            label4.Name = "label4";
            label4.Size = new Size(70, 31);
            label4.TabIndex = 9;
            label4.Text = "Floor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(58, 67);
            label3.Name = "label3";
            label3.Size = new Size(102, 31);
            label3.TabIndex = 8;
            label3.Text = "Number";
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
            // panel2
            // 
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtRooms);
            panel2.Controls.Add(cmbStatus);
            panel2.Controls.Add(cmbType);
            panel2.Controls.Add(radioBtnFalse);
            panel2.Controls.Add(radioBtnTrue);
            panel2.Controls.Add(txtArea);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(txtFloor);
            panel2.Controls.Add(txtNumber);
            panel2.Controls.Add(txtId);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(241, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 578);
            panel2.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(104, 527);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(383, 27);
            txtPrice.TabIndex = 10;
            // 
            // txtRooms
            // 
            txtRooms.Location = new Point(104, 367);
            txtRooms.Name = "txtRooms";
            txtRooms.Size = new Size(383, 27);
            txtRooms.TabIndex = 9;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Empty", "Out of Space", "In Progress Construction", "Finish Construction", "Prepare for Dismantling", "In Progress Dismantling", "Finish Dismantling" });
            cmbStatus.Location = new Point(104, 307);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(383, 28);
            cmbStatus.TabIndex = 8;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(104, 423);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(383, 28);
            cmbType.TabIndex = 7;
            // 
            // radioBtnFalse
            // 
            radioBtnFalse.AutoSize = true;
            radioBtnFalse.Location = new Point(425, 479);
            radioBtnFalse.Name = "radioBtnFalse";
            radioBtnFalse.Size = new Size(62, 24);
            radioBtnFalse.TabIndex = 6;
            radioBtnFalse.Text = "False";
            radioBtnFalse.UseVisualStyleBackColor = true;
            // 
            // radioBtnTrue
            // 
            radioBtnTrue.AutoSize = true;
            radioBtnTrue.Checked = true;
            radioBtnTrue.Location = new Point(104, 479);
            radioBtnTrue.Name = "radioBtnTrue";
            radioBtnTrue.Size = new Size(51, 24);
            radioBtnTrue.TabIndex = 5;
            radioBtnTrue.TabStop = true;
            radioBtnTrue.Text = "Yes";
            radioBtnTrue.UseVisualStyleBackColor = true;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(104, 245);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(383, 27);
            txtArea.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(104, 184);
            txtName.Name = "txtName";
            txtName.Size = new Size(383, 27);
            txtName.TabIndex = 3;
            // 
            // txtFloor
            // 
            txtFloor.Location = new Point(104, 129);
            txtFloor.Name = "txtFloor";
            txtFloor.Size = new Size(383, 27);
            txtFloor.TabIndex = 2;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(104, 74);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(383, 27);
            txtNumber.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(104, 15);
            txtId.Name = "txtId";
            txtId.Size = new Size(383, 27);
            txtId.TabIndex = 0;
            // 
            // FormEditApartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 753);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(lblHead);
            MaximumSize = new Size(803, 800);
            MinimumSize = new Size(803, 772);
            Name = "FormEditApartment";
            Text = "Edit Apartment";
            Load += FormEdit_Load;
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblHead;
        private Panel panel3;
        private Button btnSave;
        private Button btnClose;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private RadioButton radioBtnFalse;
        private RadioButton radioBtnTrue;
        private TextBox txtArea;
        private TextBox txtName;
        private TextBox txtFloor;
        private TextBox txtNumber;
        private TextBox txtId;
        private ComboBox cmbType;
        private ComboBox cmbStatus;
        private Label label1;
        private TextBox txtRooms;
        private Label label9;
        private Label label8;
        private Label label10;
        private TextBox txtPrice;
    }
}