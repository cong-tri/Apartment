using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace KTDK_CanHo_DaoCongTri.Authen
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void resgister_btn_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
        public bool checkAccount(string account)
        {
            return Regex.IsMatch(account, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[\w]{3,20}@gmail.com(.vn|)$");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password_tb.PasswordChar = showpw_chx.Checked ? '\0' : '*';
        }
        Modify modify = new Modify();

        private void login_btn_Click(object sender, EventArgs e)
        {
            string tentk = username_tb.Text;
            string matkhau = password_tb.Text;
            string xnmk = passwordexcept_tb.Text;
            string email = email_tb.Text;
            if (!checkAccount(tentk))
            {
                MessageBox.Show("Invalid Username. Username must be 6-24 characters long and contain only letters and numbers.");
                return;
            }
            if (!checkAccount(matkhau))
            {
                MessageBox.Show("Invalid Password. Password must be 6-24 characters long and contain only letters and numbers.");
                return;
            }
            if (matkhau != xnmk)
            {
                MessageBox.Show("Password confirmation does not match. Please check and try again.");
                return;
            }

            if (!checkEmail(email))
            {
                MessageBox.Show("Invalid Email. Please enter a valid Gmail address.");
                return;
            }
            if (modify.TaiKhoans("Select * from TaiKhoan where Email = '" + email + "'").Count != 0) { MessageBox.Show("Email have valid, Please create email another!"); return; }
            try
            {
                string query = "Insert into TaiKhoan values('" + tentk + "','" + matkhau + "','" + email + "')";
                modify.Command(query);
                if (MessageBox.Show("Register Successfully, Do you want Login ?") == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Register Account Successfully!,Please register new account!");
            }
            MessageBox.Show("Registration successful!");
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
    }
}
