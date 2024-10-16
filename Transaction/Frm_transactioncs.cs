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
    public partial class Frm_transactioncs : Form
    {
        private List<Models.Transaction> Transactions = new List<Models.Transaction>();

        public Frm_transactioncs()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            Transactions = Program.db.Transactions.OrderBy(x => x.TransactionId).ToList();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Transactions;
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            FormEditTransaction formEditTransaction = new FormEditTransaction();
            formEditTransaction.ShowDialog();
            LoadData();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                FormEditTransaction form1 = new FormEditTransaction();
                form1.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["TransactionId"].Value);
                form1.ShowDialog();
                Program.db.SaveChanges();
                LoadData();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                var SelectTransaction = Transactions.FirstOrDefault(x => x.TransactionId == Convert.ToInt32(dataGridView1.CurrentRow.Cells["TransactionId"].Value));
                if (SelectTransaction != null)
                {
                    Program.db.Transactions.Remove(SelectTransaction);
                    Program.db.SaveChanges();
                    LoadData();
                }
            }
        }

        private void searchkey_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var search_key = searchkey_tb.Text.Trim().ToLower();
                var lst = Transactions.Where(x => x.TransactionDate.ToLower().Contains(search_key)).ToList();
                dataGridView1.DataSource = lst;
            }
        }
    }
}
