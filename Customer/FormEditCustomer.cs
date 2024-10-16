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
    public partial class FormEditCustomer : Form
    {
        public int Id { get; set; }
        public FormEditCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {

                var selectedCustomer = Program.db.Customers.FirstOrDefault(x => x.CustomerId == Id);
                if (selectedCustomer != null)
                {
                    selectedCustomer.Name = txtName.Text.Trim();
                    selectedCustomer.Phone = txtPhone.Text.Trim();
                    selectedCustomer.Email = txtCEmail.Text.Trim();
                    selectedCustomer.Address = txtAddress.Text.Trim();
                    selectedCustomer.Dateofbirth = txtDateoB.Text.Trim();
                    selectedCustomer.IdentificationNumber = txtIdentificationNumber.Text.Trim();
                    selectedCustomer.Customersince = txtCustomerSince.Text.Trim();
                    Program.db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Customer not exist!");
                    return;
                }

            }
            else
            {
                var selectedCustomer = new Models.Customer
                {
                    Name = txtName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtCEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Dateofbirth = txtDateoB.Text.Trim(),
                    IdentificationNumber = txtIdentificationNumber.Text.Trim(),
                    Customersince = txtCustomerSince.Text.Trim(),
                };
                Program.db.Customers.Add(selectedCustomer);
                Program.db.SaveChanges();
            }
        }

        private void FormEditCustomer_Load(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                var selectedCustomer = Program.db.Customers.AsNoTracking().FirstOrDefault(x => x.CustomerId == Id);
                if (selectedCustomer == null)
                {
                    MessageBox.Show("Customer not found!");
                    this.Close();
                    return;
                }
                txtId.Text = selectedCustomer.CustomerId.ToString();
                txtName.Text = selectedCustomer.Name.ToString();
                txtPhone.Text = selectedCustomer.Phone.ToString();
                txtCEmail.Text = selectedCustomer.Email.ToString();
                txtAddress.Text = selectedCustomer.Address.ToString();
                txtDateoB.Text = selectedCustomer.Dateofbirth.ToString();
                txtIdentificationNumber.Text = selectedCustomer.IdentificationNumber.ToString();
                txtCustomerSince.Text = selectedCustomer.Customersince.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
