using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTDK_CanHo_DaoCongTri.Contract
{
    public partial class FormEditContract : Form
    {
        public int Id { get; set; }
        public FormEditContract()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            bool Extend = extend_cbx.Checked;

            int customerId;
            if (!int.TryParse(customerid_tb.Text, out customerId))
            {
                MessageBox.Show("Invalid Customer ID. Please enter a valid number.");
                return;
            }

            var customerExists = Program.db.Customers.Any(c => c.CustomerId == customerId);
            if (!customerExists)
            {
                MessageBox.Show("Customer ID does not exist. Please enter a valid Customer ID.");
                return;
            }

            int apartmentId;
            if (!int.TryParse(apartmentid_tb.Text, out apartmentId))
            {
                MessageBox.Show("Invalid Apartment ID. Please enter a valid number.");
                return;
            }

            var apartmentExists = Program.db.Apartments.Any(a => a.ApartmentId == apartmentId);
            if (!apartmentExists)
            {
                MessageBox.Show("Apartment ID does not exist. Please enter a valid Apartment ID.");
                return;
            }

            if (Id > 0)
            {
                var selectContract = Program.db.Contracts.FirstOrDefault(x => x.ContractId == Id);
                if (selectContract != null)
                {
                    selectContract.ApartmentId = apartmentId;
                    selectContract.CustomerId = customerId;
                    selectContract.StartDate = startdate_tb.Text.Trim();
                    selectContract.EndDate = enddate_tb.Text.Trim();
                    selectContract.MonthlyRent = decimal.Parse(monthlyrent_tb.Text);
                    selectContract.DepositAmount = decimal.Parse(depositamount_tb.Text);
                    selectContract.ContractStatus = contractsatus_tb.Text.Trim();
                    selectContract.RenewalOption = Extend;
                    Program.db.SaveChanges();
                }
            }
            else
            {
                var newContract = new Models.Contract
                {
                    ApartmentId = apartmentId,
                    CustomerId = customerId,
                    StartDate = startdate_tb.Text.Trim(),
                    EndDate = enddate_tb.Text.Trim(),
                    MonthlyRent = decimal.Parse(monthlyrent_tb.Text),
                    DepositAmount = decimal.Parse(depositamount_tb.Text),
                    ContractStatus = contractsatus_tb.Text.Trim(),
                    RenewalOption = Extend,
                };
                Program.db.Contracts.Add(newContract);
                Program.db.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditContract_Load(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                var selectContract = Program.db.Contracts.AsNoTracking().FirstOrDefault(x => x.ContractId == Id);
                contractid_tb.Text = selectContract.ContractId.ToString();
                apartmentid_tb.Text = selectContract.ApartmentId.ToString();
                customerid_tb.Text = selectContract.CustomerId.ToString();
                startdate_tb.Text = selectContract.StartDate.ToString();
                enddate_tb.Text = selectContract.EndDate.ToString();
                monthlyrent_tb.Text = selectContract.MonthlyRent.ToString();
                depositamount_tb.Text = selectContract.DepositAmount.ToString();
                contractsatus_tb.Text = selectContract.ContractStatus.ToString();
                extend_cbx.Checked = selectContract.RenewalOption;
                string RenewalOption = extend_cbx.Checked ? "Extend" : "";
            }
        }
    }
}
