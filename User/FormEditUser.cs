using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTDK_CanHo_DaoCongTri.User
{
    public partial class FormEditUser : Form
    {
        public int Id { get; set; }
        public FormEditUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                var selectedUser = Program.db.Users.FirstOrDefault(x => x.UserId == Id);
                if (selectedUser != null)
                {
                    selectedUser.CustomerId = int.Parse(txtCustomerId.Text.Trim());
                    selectedUser.Username = txtUserName.Text.Trim();
                    selectedUser.Password = txtPassword.Text.Trim();
                    selectedUser.Role = txtRole.Text.Trim();
                    selectedUser.Fullname = txtFullName.Text.Trim();
                    selectedUser.Email = txtEmail.Text.Trim();
                    selectedUser.LastLoginDate = txtLastLoginDate.Text.Trim();
                    Program.db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("User not exist");
                    return;
                }
            }
            else
            {
                var selectedUser = new Models.Users
                {
                    CustomerId = int.Parse(txtCustomerId.Text.Trim()),
                    Password = txtPassword.Text.Trim(),
                    Username = txtUserName.Text.Trim(),
                    Role = txtRole.Text.Trim(),
                    Fullname = txtFullName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    LastLoginDate = txtLastLoginDate.Text.Trim(),
                };
                Program.db.Users.Add(selectedUser);
                Program.db.SaveChanges();
            }
            this.Close();
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            if (Id > 0)
            {

                var selectedUser = Program.db.Users.AsNoTracking().FirstOrDefault(x => x.UserId == Id);
                if (selectedUser == null)
                {
                    MessageBox.Show("User not found!");
                    this.Close();
                    return;
                }
                txtId.Text = selectedUser.UserId.ToString();
                txtCustomerId.Text = selectedUser.CustomerId.ToString();
                txtUserName.Text = selectedUser.Username.ToString();
                txtPassword.Text = selectedUser.Password.ToString();
                txtRole.Text = selectedUser.Role.ToString();
                txtFullName.Text = selectedUser.Fullname.ToString();
                txtEmail.Text = selectedUser.Email.ToString();
                txtLastLoginDate.Text = selectedUser.LastLoginDate.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
