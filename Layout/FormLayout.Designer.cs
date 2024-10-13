namespace KTDK_CanHo_DaoCongTri
{
    partial class FormLayout
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
            panel_nav = new Panel();
            btn_request = new Button();
            btn_employee = new Button();
            btn_apartment = new Button();
            btn_type = new Button();
            btn_home = new Button();
            panel_body = new Panel();
            label1 = new Label();
            panel1_top = new Panel();
            lbl_head = new Label();
            panel_nav.SuspendLayout();
            panel_body.SuspendLayout();
            panel1_top.SuspendLayout();
            SuspendLayout();
            // 
            // panel_nav
            // 
            panel_nav.BackColor = Color.Black;
            panel_nav.Controls.Add(btn_request);
            panel_nav.Controls.Add(btn_employee);
            panel_nav.Controls.Add(btn_apartment);
            panel_nav.Controls.Add(btn_type);
            panel_nav.Controls.Add(btn_home);
            panel_nav.Dock = DockStyle.Left;
            panel_nav.Location = new Point(0, 0);
            panel_nav.Name = "panel_nav";
            panel_nav.Size = new Size(250, 620);
            panel_nav.TabIndex = 0;
            // 
            // btn_request
            // 
            btn_request.BackColor = SystemColors.Highlight;
            btn_request.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_request.ForeColor = SystemColors.ButtonHighlight;
            btn_request.Location = new Point(12, 371);
            btn_request.Name = "btn_request";
            btn_request.Size = new Size(223, 60);
            btn_request.TabIndex = 4;
            btn_request.Text = "Request";
            btn_request.UseVisualStyleBackColor = false;
            btn_request.Click += btn_request_Click;
            // 
            // btn_employee
            // 
            btn_employee.BackColor = SystemColors.Highlight;
            btn_employee.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_employee.ForeColor = SystemColors.ButtonHighlight;
            btn_employee.Location = new Point(12, 287);
            btn_employee.Name = "btn_employee";
            btn_employee.Size = new Size(223, 60);
            btn_employee.TabIndex = 3;
            btn_employee.Text = "Employee";
            btn_employee.UseVisualStyleBackColor = false;
            btn_employee.Click += btn_employee_Click;
            // 
            // btn_apartment
            // 
            btn_apartment.BackColor = SystemColors.Highlight;
            btn_apartment.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_apartment.ForeColor = SystemColors.ButtonHighlight;
            btn_apartment.Location = new Point(12, 200);
            btn_apartment.Name = "btn_apartment";
            btn_apartment.Size = new Size(223, 60);
            btn_apartment.TabIndex = 2;
            btn_apartment.Text = "Apartment";
            btn_apartment.UseVisualStyleBackColor = false;
            btn_apartment.Click += btn_apartment_Click;
            // 
            // btn_type
            // 
            btn_type.BackColor = SystemColors.Highlight;
            btn_type.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_type.ForeColor = SystemColors.ButtonHighlight;
            btn_type.Location = new Point(12, 111);
            btn_type.Name = "btn_type";
            btn_type.Size = new Size(223, 60);
            btn_type.TabIndex = 1;
            btn_type.Text = "Type";
            btn_type.UseVisualStyleBackColor = false;
            btn_type.Click += btn_type_Click;
            // 
            // btn_home
            // 
            btn_home.BackColor = SystemColors.Highlight;
            btn_home.Dock = DockStyle.Top;
            btn_home.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_home.ForeColor = SystemColors.ButtonHighlight;
            btn_home.Location = new Point(0, 0);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(250, 83);
            btn_home.TabIndex = 0;
            btn_home.Text = "HOME";
            btn_home.UseVisualStyleBackColor = false;
            btn_home.Click += btn_home_Click;
            // 
            // panel_body
            // 
            panel_body.Controls.Add(label1);
            panel_body.Dock = DockStyle.Fill;
            panel_body.Location = new Point(250, 83);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(1074, 537);
            panel_body.TabIndex = 4;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1074, 537);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO APARTMENT MANAGEMENT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1_top
            // 
            panel1_top.BackColor = Color.DimGray;
            panel1_top.Controls.Add(lbl_head);
            panel1_top.Dock = DockStyle.Top;
            panel1_top.Location = new Point(250, 0);
            panel1_top.Name = "panel1_top";
            panel1_top.Size = new Size(1074, 83);
            panel1_top.TabIndex = 3;
            // 
            // lbl_head
            // 
            lbl_head.AutoSize = true;
            lbl_head.BorderStyle = BorderStyle.Fixed3D;
            lbl_head.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_head.ForeColor = SystemColors.ButtonHighlight;
            lbl_head.Location = new Point(30, 27);
            lbl_head.Name = "lbl_head";
            lbl_head.Size = new Size(71, 33);
            lbl_head.TabIndex = 0;
            lbl_head.Text = "Main";
            // 
            // FormLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 620);
            Controls.Add(panel_body);
            Controls.Add(panel1_top);
            Controls.Add(panel_nav);
            MinimumSize = new Size(1048, 667);
            Name = "FormLayout";
            Text = "FormLayout";
            panel_nav.ResumeLayout(false);
            panel_body.ResumeLayout(false);
            panel1_top.ResumeLayout(false);
            panel1_top.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_nav;
        private Button btn_type;
        private Button btn_home;
        private Panel panel_body;
        private Panel panel1_top;
        private Label lbl_head;
        private Button btn_request;
        private Button btn_employee;
        private Button btn_apartment;
        private Label label1;
    }
}