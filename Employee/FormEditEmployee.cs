using KTDK_CanHo_DaoCongTri.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.MonthCalendar;

namespace KTDK_CanHo_DaoCongTri.Employee
{
    public partial class FormEditEmployee : Form
    {
        public int Id { get; set; }
        public FormEditEmployee()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckValidate()
        {
            if (!String.IsNullOrEmpty(txtName.Text) ||
                !String.IsNullOrEmpty(cmbPosition.Text) ||
                !String.IsNullOrEmpty(txtPhone.Text) ||
                !String.IsNullOrEmpty(txtEmail.Text) ||
                !String.IsNullOrEmpty(txtDate.Text) ||
                !String.IsNullOrEmpty(txtDepartment.Text) ||
                decimal.TryParse(txtSalary.Text, out decimal salary))
            {
                return true;
            }

            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                if (CheckValidate())
                {
                    var selected = Program.db.Employees.FirstOrDefault(x => x.EmployeeId == Id);
                    selected.EmployeeName = txtName.Text.Trim();
                    selected.EmployeePhone = txtPhone.Text.Trim();
                    selected.EmployeeEmail = txtEmail.Text.Trim();
                    selected.EmployeePosition = cmbPosition.Text.Trim();
                    selected.EmployeeDepartment = txtDepartment.Text.Trim();
                    selected.EmployeeSalary = decimal.Parse(txtSalary.Text);
                    selected.EmployeeHireDate = txtDate.Text.Trim(); 
                    Program.db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Please entered full of employee' fields.");
                    return;
                }
            }
            else
            {
                if (CheckValidate())
                {
                    var newEmployee = new Models.Employee
                    {
                        EmployeeName = txtName.Text.Trim(),
                        EmployeePhone = txtPhone.Text.Trim(),
                        EmployeeEmail = txtEmail.Text.Trim(),
                        EmployeePosition = cmbPosition.Text.Trim(),
                        EmployeeDepartment = txtDepartment.Text.Trim(),
                        EmployeeSalary = decimal.Parse(txtSalary.Text),
                        EmployeeHireDate = txtDate.Text.Trim()
                    };
                    Program.db.Employees.Add(newEmployee);
                    Program.db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Please entered full of apartment' fields.");
                    return;
                }
            }
            this.Close();
        }

        private void FormEditEmployee_Load(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                lblHead.Text = "Update Employee";
                var selected = Program.db.Employees.AsNoTracking().FirstOrDefault(x => x.EmployeeId == Id);

                txtId.Text = selected.EmployeeId.ToString();
                txtName.Text = selected.EmployeeName.ToString();
                txtPhone.Text = selected.EmployeePhone.ToString();
                cmbPosition.Text = selected.EmployeePosition.ToString();
                txtEmail.Text = selected.EmployeeEmail.ToString();
                txtDepartment.Text = selected.EmployeeDepartment.ToString();
                txtDate.Text = selected.EmployeeHireDate.ToString();
                txtSalary.Text = selected.EmployeeSalary.ToString();
            }
        }
    }
}
