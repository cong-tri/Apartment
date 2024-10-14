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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            txtSearch = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            dataGrdViewTypes = new DataGridView();
            dataGrdView_Type = new DataGridView();
            TypeId = new DataGridViewTextBoxColumn();
            TypeName = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDelete = new Button();
            btn_save = new Button();
            Type_Name = new DataGridViewTextBoxColumn();
            ApartmentCount = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrdViewTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrdView_Type).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.YellowGreen;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtName);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 398);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtSearch);
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
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(107, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 38);
            txtSearch.TabIndex = 2;
            txtSearch.KeyPress += txtSearch_KeyPress;
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
            // dataGrdViewTypes
            // 
            dataGrdViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrdViewTypes.Columns.AddRange(new DataGridViewColumn[] { Type_Name, ApartmentCount });
            dataGrdViewTypes.Dock = DockStyle.Bottom;
            dataGrdViewTypes.Location = new Point(250, 244);
            dataGrdViewTypes.Name = "dataGrdViewTypes";
            dataGrdViewTypes.RowHeadersWidth = 51;
            dataGrdViewTypes.Size = new Size(550, 154);
            dataGrdViewTypes.TabIndex = 1;
            // 
            // dataGrdView_Type
            // 
            dataGrdView_Type.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrdView_Type.Columns.AddRange(new DataGridViewColumn[] { TypeId, TypeName });
            dataGrdView_Type.Dock = DockStyle.Fill;
            dataGrdView_Type.Location = new Point(250, 0);
            dataGrdView_Type.Name = "dataGrdView_Type";
            dataGrdView_Type.RowHeadersWidth = 51;
            dataGrdView_Type.Size = new Size(550, 244);
            dataGrdView_Type.TabIndex = 3;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_save);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 249);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 149);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Highlight;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(3, 58);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(244, 49);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.Highlight;
            btn_save.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.ForeColor = SystemColors.ButtonHighlight;
            btn_save.Location = new Point(3, 3);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(244, 49);
            btn_save.TabIndex = 7;
            btn_save.Text = "Add";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // Type_Name
            // 
            Type_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Type_Name.DataPropertyName = "Type_Name";
            Type_Name.HeaderText = "Type Name";
            Type_Name.MinimumWidth = 6;
            Type_Name.Name = "Type_Name";
            // 
            // ApartmentCount
            // 
            ApartmentCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ApartmentCount.DataPropertyName = "ApartmentCount";
            ApartmentCount.HeaderText = "Apartment Count";
            ApartmentCount.MinimumWidth = 6;
            ApartmentCount.Name = "ApartmentCount";
            // 
            // FormType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 398);
            Controls.Add(dataGrdView_Type);
            Controls.Add(dataGrdViewTypes);
            Controls.Add(panel1);
            Name = "FormType";
            Text = "FormType";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrdViewTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrdView_Type).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox txtSearch;
        private Label label3;
        private TextBox txtId;
        private Label label2;
        private TextBox txtName;
        private DataGridView dataGrdViewTypes;
        private DataGridView dataGrdView_Type;
        private DataGridViewTextBoxColumn TypeId;
        private DataGridViewTextBoxColumn TypeName;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_save;
        private Button btnDelete;
        private DataGridViewTextBoxColumn Type_Name;
        private DataGridViewTextBoxColumn ApartmentCount;
    }
}