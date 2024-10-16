using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTDK_CanHo_DaoCongTri.Transaction
{
    public partial class FormEditTransaction : Form
    {
        public int Id { get; set; }
        public FormEditTransaction()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            int contractId;
            if (!int.TryParse(contractid_tb.Text, out contractId))
            {
                MessageBox.Show("Invalid Contract ID. Please enter a valid number.");
                return;
            }

            var contractExists = Program.db.Contracts.Any(c => c.ContractId == contractId);
            if (!contractExists)
            {
                MessageBox.Show("Contract ID does not exist. Please enter a valid Contract ID.");
                return;
            }

            if (Id > 0)
            {
                var selectTransaction = Program.db.Transactions.FirstOrDefault(x => x.TransactionId == Id);
                if (selectTransaction != null)
                {
                    selectTransaction.ContractId = contractId;
                    selectTransaction.Amount = decimal.Parse(amount_tb.Text);
                    selectTransaction.IssuedBy = int.Parse(issuedby_db.Text.Trim());
                    selectTransaction.TransactionDate = transactiondate_tb.Text.Trim();
                    selectTransaction.Description = desciption_tb.Text.Trim();
                    selectTransaction.TransactionType = transactiontype_tb.Text.Trim();
                    selectTransaction.PaymentMethod = paymentmethod_tb.Text.Trim();
                    Program.db.SaveChanges();
                }
            }
            else
            {
                var newTransaction = new Models.Transaction
                {
                    ContractId = contractId,
                    Amount = decimal.Parse(amount_tb.Text),
                    TransactionDate = transactiondate_tb.Text.Trim(),
                    Description = desciption_tb.Text.Trim(),
                    TransactionType = transactiontype_tb.Text.Trim(),
                    PaymentMethod = paymentmethod_tb.Text.Trim(),
                    IssuedBy = Convert.ToInt32(issuedby_db.Text),
                };
                Program.db.Transactions.Add(newTransaction);
                Program.db.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                var selectTransaction = Program.db.Transactions.AsNoTracking().FirstOrDefault(x => x.TransactionId == Id);
                transactionid_tb.Text = selectTransaction.TransactionId.ToString();
                contractid_tb.Text = selectTransaction.ContractId.ToString();
                amount_tb.Text = selectTransaction.Amount.ToString();
                transactiondate_tb.Text = selectTransaction.TransactionDate.ToString();
                desciption_tb.Text = selectTransaction.Description.ToString();
                transactiontype_tb.Text = selectTransaction.TransactionType.ToString();
                paymentmethod_tb.Text = selectTransaction.PaymentMethod.ToString();
                issuedby_db.Text = selectTransaction.IssuedBy.ToString();
            }
        }
    }
}
