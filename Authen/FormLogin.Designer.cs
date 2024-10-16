namespace KTDK_CanHo_DaoCongTri.Authen
{
    partial class FormLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            username_tb = new TextBox();
            password_tb = new TextBox();
            checkBox1 = new CheckBox();
            login_btn = new Button();
            resgister_btn = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(resgister_btn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 464);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(348, 24);
            label1.Name = "label1";
            label1.Size = new Size(242, 38);
            label1.TabIndex = 1;
            label1.Text = "LOGIN ACCOUNT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 126);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "User Name ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 239);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // username_tb
            // 
            username_tb.Location = new Point(312, 149);
            username_tb.Multiline = true;
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(309, 34);
            username_tb.TabIndex = 4;
            // 
            // password_tb
            // 
            password_tb.Location = new Point(312, 262);
            password_tb.Multiline = true;
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(309, 37);
            password_tb.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(485, 305);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(138, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show pass word";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // login_btn
            // 
            login_btn.BackColor = SystemColors.ActiveCaptionText;
            login_btn.Dock = DockStyle.Bottom;
            login_btn.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.ButtonHighlight;
            login_btn.Location = new Point(306, 423);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(327, 41);
            login_btn.TabIndex = 7;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            // 
            // resgister_btn
            // 
            resgister_btn.BackColor = SystemColors.ActiveCaptionText;
            resgister_btn.Dock = DockStyle.Bottom;
            resgister_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resgister_btn.ForeColor = SystemColors.ButtonHighlight;
            resgister_btn.Location = new Point(0, 423);
            resgister_btn.Name = "resgister_btn";
            resgister_btn.Size = new Size(306, 41);
            resgister_btn.TabIndex = 8;
            resgister_btn.Text = "REGISTER";
            resgister_btn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(28, 232);
            label4.Name = "label4";
            label4.Size = new Size(258, 21);
            label4.TabIndex = 8;
            label4.Text = "APARTMENT MANAGEMENT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(79, 400);
            label5.Name = "label5";
            label5.Size = new Size(156, 20);
            label5.TabIndex = 9;
            label5.Text = "Register your account ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(607, 0);
            label6.Name = "label6";
            label6.Size = new Size(24, 28);
            label6.TabIndex = 10;
            label6.Text = "X";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stencil", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(105, 253);
            label7.Name = "label7";
            label7.Size = new Size(83, 21);
            label7.TabIndex = 10;
            label7.Text = "SYSTEM";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 464);
            Controls.Add(label6);
            Controls.Add(login_btn);
            Controls.Add(checkBox1);
            Controls.Add(password_tb);
            Controls.Add(username_tb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username_tb;
        private TextBox password_tb;
        private Label label5;
        private Label label4;
        private Button resgister_btn;
        private CheckBox checkBox1;
        private Button login_btn;
        private Label label6;
        private Label label7;
    }
}