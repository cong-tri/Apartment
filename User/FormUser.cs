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
    public partial class FormUser : Form
    {
        private List<Models.Users> users = new List<Models.Users>();
        public FormUser()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            users = Program.db.Users.OrderBy(x => x.Fullname).ToList();
            if (users.Count == 0)
            {
                MessageBox.Show("Không có người dùng nào để hiển thị.");
            }
            datagv.AutoGenerateColumns = false;
            datagv.DataSource = users;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEditUser formEditUser = new FormEditUser();
            formEditUser.ShowDialog();
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (datagv.CurrentRow != null)
            {
                FormEditUser formEdit = new FormEditUser();
                formEdit.Id = Convert.ToInt32(datagv.CurrentRow.Cells["UserId"].Value);
                formEdit.ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("Please choose user who you want to edit!");
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (datagv.CurrentRow != null)
            {
                var selectedUserId = Convert.ToInt32(datagv.CurrentRow.Cells["UserId"].Value);
                var selectedUser = Program.db.Users.FirstOrDefault(x => x.UserId == selectedUserId);
                if (selectedUser != null)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this user?", "Delete", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        Program.db.Users.Remove(selectedUser);
                        Program.db.SaveChanges();
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose user who you want to delete!");
                return;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                var searchKey = txtSearch.Text.Trim().ToLower();
                var lst = Program.db.Users.Where(x => (x.Username + " " + x.Fullname).ToLower().Contains(searchKey)).ToList();
                datagv.DataSource = lst;
            }
        }
    }
}
