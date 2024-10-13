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
            label1 = new Label();
            panel3 = new Panel();
            btnSave = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            radioBtnCanHo = new RadioButton();
            radioBtnShop = new RadioButton();
            txtDiaChi = new TextBox();
            txtTCC = new TextBox();
            txtTang = new TextBox();
            txtSCH = new TextBox();
            txtId = new TextBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 50);
            label1.TabIndex = 0;
            label1.Text = "Thêm - Cập nhật căn hộ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnClose);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 414);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 125);
            panel3.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(437, 51);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(250, 51);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 0;
            btnClose.Text = "Đóng";
            btnClose.TextAlign = ContentAlignment.BottomCenter;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 364);
            panel1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 321);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 12;
            label7.Text = "Loại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 265);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 11;
            label6.Text = "Địa Chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 204);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 10;
            label5.Text = "Tên Chung Cư";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 149);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 9;
            label4.Text = "Tầng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 94);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 8;
            label3.Text = "Số Căn Hộ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 35);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 7;
            label2.Text = "Id";
            // 
            // panel2
            // 
            panel2.Controls.Add(radioBtnCanHo);
            panel2.Controls.Add(radioBtnShop);
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(txtTCC);
            panel2.Controls.Add(txtTang);
            panel2.Controls.Add(txtSCH);
            panel2.Controls.Add(txtId);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(256, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 364);
            panel2.TabIndex = 11;
            // 
            // radioBtnCanHo
            // 
            radioBtnCanHo.AutoSize = true;
            radioBtnCanHo.Location = new Point(281, 321);
            radioBtnCanHo.Name = "radioBtnCanHo";
            radioBtnCanHo.Size = new Size(76, 24);
            radioBtnCanHo.TabIndex = 6;
            radioBtnCanHo.TabStop = true;
            radioBtnCanHo.Text = "Căn hộ";
            radioBtnCanHo.UseVisualStyleBackColor = true;
            // 
            // radioBtnShop
            // 
            radioBtnShop.AutoSize = true;
            radioBtnShop.Location = new Point(104, 321);
            radioBtnShop.Name = "radioBtnShop";
            radioBtnShop.Size = new Size(103, 24);
            radioBtnShop.TabIndex = 5;
            radioBtnShop.TabStop = true;
            radioBtnShop.Text = "Shophouse";
            radioBtnShop.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(104, 262);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(383, 27);
            txtDiaChi.TabIndex = 4;
            // 
            // txtTCC
            // 
            txtTCC.Location = new Point(104, 201);
            txtTCC.Name = "txtTCC";
            txtTCC.Size = new Size(383, 27);
            txtTCC.TabIndex = 3;
            // 
            // txtTang
            // 
            txtTang.Location = new Point(104, 146);
            txtTang.Name = "txtTang";
            txtTang.Size = new Size(383, 27);
            txtTang.TabIndex = 2;
            // 
            // txtSCH
            // 
            txtSCH.Location = new Point(104, 91);
            txtSCH.Name = "txtSCH";
            txtSCH.Size = new Size(383, 27);
            txtSCH.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(104, 32);
            txtId.Name = "txtId";
            txtId.Size = new Size(383, 27);
            txtId.TabIndex = 0;
            // 
            // FormEditApartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 539);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(label1);
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

        private Label label1;
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
        private RadioButton radioBtnCanHo;
        private RadioButton radioBtnShop;
        private TextBox txtDiaChi;
        private TextBox txtTCC;
        private TextBox txtTang;
        private TextBox txtSCH;
        private TextBox txtId;
    }
}