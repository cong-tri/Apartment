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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
            label3.Text = "";
        }
        Modify modify = new Modify();
        private void login_btn_Click(object sender, EventArgs e)
        {
            string email = email_tb.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Please register email!");
            }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    label3.ForeColor = Color.Blue;
                    label3.Text = "Password" + modify.TaiKhoans(query)[0].MatKhau;
                }
                else
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "Email have not registered";
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resgister_btn_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Hide();
        }
    }
}
