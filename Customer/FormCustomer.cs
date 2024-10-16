using KTDK_CanHo_DaoCongTri.Models;
using KTDK_CanHo_DaoCongTri.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTDK_CanHo_DaoCongTri.Customer
{
    public partial class FormCustomer : Form
    {
        private List<Models.Customer> customers = new List<Models.Customer>();
        public FormCustomer()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            customers = Program.db.Customers.OrderBy(x => x.CustomerId).ThenBy(y => y.Name).ToList();
            datagvC.AutoGenerateColumns = false;
            datagvC.DataSource = customers;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEditCustomer formEditCustomer = new FormEditCustomer();
            formEditCustomer.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (datagvC.CurrentRow != null)
            {
                FormEditCustomer formEdit = new FormEditCustomer();
                formEdit.Id = Convert.ToInt32(datagvC.CurrentRow.Cells["CustomerId"].Value);
                formEdit.ShowDialog();
                Program.db.SaveChanges();
                LoadData();
            }
            else
            {
                MessageBox.Show("Please choose customer which you want to edit!");
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (datagvC.CurrentRow != null)
            {
                var selectedCustomerId = Convert.ToInt32(datagvC.CurrentRow.Cells["CustomerId"].Value);
                bool isReferenced = Program.db.Users.Any(x => x.UserId == selectedCustomerId);

                if (isReferenced)
                {
                    MessageBox.Show("This type is referenced in the User table and cannot be deleted.");
                    return;
                }
                var selectedCustomer = Program.db.Customers.FirstOrDefault(x => x.CustomerId == selectedCustomerId);
                if (selectedCustomer != null)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this customer?", "Delete", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        Program.db.Customers.Remove(selectedCustomer);
                        Program.db.SaveChanges();
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose customer which you want to delete!");
                return;
            }
        }
    }
}
