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
        public FormUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEditUser formEditUser = new FormEditUser();
            formEditUser.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormEditUser formEditUser = new FormEditUser();
            formEditUser.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
