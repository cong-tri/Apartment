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
    public partial class FormContract : Form
    {
        private List<Models.Contract> Contracts = new List<Models.Contract>();
        public FormContract()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            Contracts = Program.db.Contracts.OrderBy(x => x.ContractId).ToList();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Contracts;
        }
        private void FormContract_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            FormEditContract formEditContract = new FormEditContract();
            formEditContract.ShowDialog();
            LoadData();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                FormEditContract formEditContract = new FormEditContract();
                formEditContract.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ContractId"].Value);
                formEditContract.ShowDialog();
                Program.db.SaveChanges();
                LoadData();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                var selectContract = Contracts.FirstOrDefault(x => x.ContractId == Convert.ToInt32(dataGridView1.CurrentRow.Cells["ContractId"].Value));
                if (selectContract != null)
                {
                    Program.db.Contracts.Remove(selectContract);
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
                var lst = Contracts.Where(x => x.StartDate.ToLower().Contains(search_key)).ToList();
                dataGridView1.DataSource = lst;
            }
        }
    }
}
