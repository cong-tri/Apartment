using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTDK_CanHo_DaoCongTri.Authen
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void login_btn_Click(object sender, EventArgs e)
        {
            string tentk = username_tb.Text;
            string matkhau = password_tb.Text;
            if (tentk == "") { MessageBox.Show("Invalid the username!"); }
            else if (matkhau == "") { MessageBox.Show("Invalid the password!"); }
            else
            {
                string query = "Select * from Taikhoan where TenTaiKhoan = '" + tentk + "' and Matkhau = '" + matkhau + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Success Account!");
                    this.Hide();
                    FormLayout formLayout = new FormLayout();
                    formLayout.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Not Success Account!");
                }
            }
        }

        private void resgister_btn_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password_tb.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }
    }
}
