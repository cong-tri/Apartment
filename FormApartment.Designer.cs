namespace KTDK_CanHo_DaoCongTri
{
    partial class FormApartment
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            txtSearch = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            panel2 = new Panel();
            dataGrv = new DataGridView();
            ApartmentId = new DataGridViewTextBoxColumn();
            TypeId = new DataGridViewTextBoxColumn();
            ApartmentName = new DataGridViewTextBoxColumn();
            ApartmentNumber = new DataGridViewTextBoxColumn();
            ApartmentArea = new DataGridViewTextBoxColumn();
            ApartmentRoomCount = new DataGridViewTextBoxColumn();
            ApartmentStatus = new DataGridViewTextBoxColumn();
            ApartmentHasBalcony = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 125);
            panel1.TabIndex = 0;
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
            panel3.Size = new Size(932, 125);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(548, 0);
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
            btnDelete.Click += btnDelete_Click_1;
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
            btnEdit.Click += btnEdit_Click_1;
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
            // panel2
            // 
            panel2.Controls.Add(dataGrv);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(932, 328);
            panel2.TabIndex = 1;
            // 
            // dataGrv
            // 
            dataGrv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrv.Columns.AddRange(new DataGridViewColumn[] { ApartmentId, TypeId, ApartmentName, ApartmentNumber, ApartmentArea, ApartmentRoomCount, ApartmentStatus, ApartmentHasBalcony });
            dataGrv.Dock = DockStyle.Fill;
            dataGrv.Location = new Point(0, 0);
            dataGrv.Name = "dataGrv";
            dataGrv.RowHeadersWidth = 51;
            dataGrv.Size = new Size(932, 328);
            dataGrv.TabIndex = 0;
            // 
            // ApartmentId
            // 
            ApartmentId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ApartmentId.DataPropertyName = "ApartmentId";
            ApartmentId.HeaderText = "ApartmentId";
            ApartmentId.MinimumWidth = 6;
            ApartmentId.Name = "ApartmentId";
            // 
            // TypeId
            // 
            TypeId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TypeId.DataPropertyName = "TypeId";
            TypeId.HeaderText = "TypeId";
            TypeId.MinimumWidth = 6;
            TypeId.Name = "TypeId";
            // 
            // ApartmentName
            // 
            ApartmentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ApartmentName.DataPropertyName = "ApartmentName";
            ApartmentName.HeaderText = "Name";
            ApartmentName.MinimumWidth = 6;
            ApartmentName.Name = "ApartmentName";
            // 
            // ApartmentNumber
            // 
            ApartmentNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ApartmentNumber.DataPropertyName = "ApartmentNumber";
            ApartmentNumber.HeaderText = "Number";
            ApartmentNumber.MinimumWidth = 6;
            ApartmentNumber.Name = "ApartmentNumber";
            // 
            // ApartmentArea
            // 
            ApartmentArea.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ApartmentArea.DataPropertyName = "ApartmentArea";
            ApartmentArea.HeaderText = "Area";
            ApartmentArea.MinimumWidth = 6;
            ApartmentArea.Name = "ApartmentArea";
            // 
            // ApartmentRoomCount
            // 
            ApartmentRoomCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ApartmentRoomCount.DataPropertyName = "ApartmentRoomCount";
            ApartmentRoomCount.HeaderText = "Rooms";
            ApartmentRoomCount.MinimumWidth = 6;
            ApartmentRoomCount.Name = "ApartmentRoomCount";
            // 
            // ApartmentStatus
            // 
            ApartmentStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ApartmentStatus.DataPropertyName = "ApartmentStatus";
            ApartmentStatus.HeaderText = "Status";
            ApartmentStatus.MinimumWidth = 6;
            ApartmentStatus.Name = "ApartmentStatus";
            // 
            // ApartmentHasBalcony
            // 
            ApartmentHasBalcony.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ApartmentHasBalcony.DataPropertyName = "ApartmentHasBalcony";
            ApartmentHasBalcony.HeaderText = "HasBalcony";
            ApartmentHasBalcony.MinimumWidth = 6;
            ApartmentHasBalcony.Name = "ApartmentHasBalcony";
            // 
            // FormApartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 453);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(836, 500);
            Name = "FormApartment";
            Text = "Apartment";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGrv;
        private DataGridViewTextBoxColumn ApartmentId;
        private DataGridViewTextBoxColumn TypeId;
        private DataGridViewTextBoxColumn ApartmentName;
        private DataGridViewTextBoxColumn ApartmentNumber;
        private DataGridViewTextBoxColumn ApartmentArea;
        private DataGridViewTextBoxColumn ApartmentRoomCount;
        private DataGridViewTextBoxColumn ApartmentStatus;
        private DataGridViewTextBoxColumn ApartmentHasBalcony;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtSearch;
        private Label label1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}
