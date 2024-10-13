using KTDK_CanHo_DaoCongTri.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTDK_CanHo_DaoCongTri.Employee
{
    public partial class FormEmployee : Form
    {
        private List<Models.Employee> employees = new List<Models.Employee>();
        public FormEmployee()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            employees = Program.db.Employees.ToList();
            dataGrv.AutoGenerateColumns = false;
            dataGrv.DataSource = employees;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEditEmployee formEdit = new FormEditEmployee();
            formEdit.ShowDialog();
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGrv.CurrentRow != null)
            {
                FormEditEmployee formEdit = new FormEditEmployee();
                formEdit.Id = Convert.ToInt32(dataGrv.CurrentRow.Cells["EmployeeId"].Value);
                formEdit.ShowDialog();
                Program.db.SaveChanges();
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGrv.CurrentRow != null)
            {
                FormDeleteEmployee formDelete = new FormDeleteEmployee();
                formDelete.Id = Convert.ToInt32(dataGrv.CurrentRow.Cells["EmployeeId"].Value);
                formDelete.ShowDialog();
                Program.db.SaveChanges();
                LoadData();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                var searchKey = txtSearch.Text.Trim().ToLower();
                var lst = employees.Where(x => x.EmployeeName.ToLower().Contains(searchKey) ||
                x.EmployeePosition.ToString().ToLower().Contains(searchKey) ||
                x.EmployeePhone.ToString().ToLower().Contains(searchKey) ||
                x.EmployeeEmail.ToString().ToLower().Contains(searchKey)).ToList();
                dataGrv.DataSource = lst;
            }
        }
    }
}
