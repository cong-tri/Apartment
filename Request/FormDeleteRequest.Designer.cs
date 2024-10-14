namespace KTDK_CanHo_DaoCongTri.Request
{
    partial class FormDeleteRequest
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
            btnDelete = new Button();
            btnClose = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(237, 137);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(152, 65);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Goldenrod;
            btnClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(12, 137);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(152, 65);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Highlight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(401, 48);
            label1.TabIndex = 6;
            label1.Text = "Are you sure to delete this request?";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormDeleteRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 220);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(label1);
            MaximumSize = new Size(419, 267);
            MinimumSize = new Size(419, 267);
            Name = "FormDeleteRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDeleteRequest";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDelete;
        private Button btnClose;
        private Label label1;
    }
}