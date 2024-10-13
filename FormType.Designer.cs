namespace KTDK_CanHo_DaoCongTri
{
    partial class FormType
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btn_save = new Button();
            panel2 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            dataGrdView_Type = new DataGridView();
            TypeId = new DataGridViewTextBoxColumn();
            TypeName = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrdView_Type).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.YellowGreen;
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtName);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 395);
            panel1.TabIndex = 0;
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.Highlight;
            btn_save.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.ForeColor = SystemColors.ButtonHighlight;
            btn_save.Location = new Point(18, 252);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(213, 49);
            btn_save.TabIndex = 7;
            btn_save.Text = "Add";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 78);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(85, 31);
            label1.TabIndex = 3;
            label1.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(107, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 38);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 103);
            label3.Name = "label3";
            label3.Size = new Size(35, 31);
            label3.TabIndex = 5;
            label3.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(107, 100);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 38);
            txtId.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 157);
            label2.Name = "label2";
            label2.Size = new Size(77, 31);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(107, 154);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 38);
            txtName.TabIndex = 2;
            // 
            // dataGrdView_Type
            // 
            dataGrdView_Type.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrdView_Type.Columns.AddRange(new DataGridViewColumn[] { TypeId, TypeName });
            dataGrdView_Type.Dock = DockStyle.Fill;
            dataGrdView_Type.Location = new Point(250, 0);
            dataGrdView_Type.Name = "dataGrdView_Type";
            dataGrdView_Type.RowHeadersWidth = 51;
            dataGrdView_Type.Size = new Size(550, 395);
            dataGrdView_Type.TabIndex = 2;
            dataGrdView_Type.CellClick += dataGrdView_Type_CellClick;
            // 
            // TypeId
            // 
            TypeId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TypeId.DataPropertyName = "TypeId";
            TypeId.HeaderText = "Id";
            TypeId.MinimumWidth = 6;
            TypeId.Name = "TypeId";
            // 
            // TypeName
            // 
            TypeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TypeName.DataPropertyName = "TypeName";
            TypeName.HeaderText = "Name";
            TypeName.MinimumWidth = 6;
            TypeName.Name = "TypeName";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 395);
            Controls.Add(dataGrdView_Type);
            Controls.Add(panel1);
            Name = "FormType";
            Text = "FormType";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrdView_Type).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_save;
        private Panel panel2;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox txtId;
        private Label label2;
        private TextBox txtName;
        private DataGridView dataGrdView_Type;
        private DataGridViewTextBoxColumn TypeId;
        private DataGridViewTextBoxColumn TypeName;
        private ContextMenuStrip contextMenuStrip1;
    }
}