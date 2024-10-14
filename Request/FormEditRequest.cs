using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;
using System.Xml.Linq;
using KTDK_CanHo_DaoCongTri.Models;
using System.Diagnostics;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace KTDK_CanHo_DaoCongTri.Request
{
    public partial class FormEditRequest : Form
    {
        public int Id { get; set; }
        private List<Models.Apartment> apartments = new List<Models.Apartment>();
        private List<Models.Employee> employees = new List<Models.Employee>();
        public FormEditRequest()
        {
            InitializeComponent();
        }
        private bool CheckValidate()
        {
            if (!String.IsNullOrEmpty(textBox1.Text) ||
                !String.IsNullOrEmpty(txtCost.Text) ||
                !String.IsNullOrEmpty(txtCompleDate.Text) ||
                !String.IsNullOrEmpty(txtDesc.Text) ||
                !String.IsNullOrEmpty(cmbStatus.Text) ||
                int.TryParse(cmbEmp.SelectedValue.ToString(), out _) ||
                int.TryParse(cmbApartment.SelectedValue.ToString(), out _) ||
                decimal.TryParse(txtCompleDate.Text, out _))
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
                    var selected = Program.db.MaintenanceRequests.FirstOrDefault(x => x.RequestId == Id);
                    selected.ApartmentId = int.Parse(cmbApartment.SelectedValue.ToString());
                    selected.EmployeeId = int.Parse(cmbEmp.SelectedValue.ToString());
                    selected.RequestDescription = txtDesc.Text.Trim();
                    selected.RequestStatus = cmbStatus.Text.Trim();
                    selected.RequestCompletionDate = txtCompleDate.Text.Trim();
                    selected.RequestDate = textBox1.Text.Trim();
                    selected.RequestCost = decimal.Parse(txtCost.Text.Trim());
                    Program.db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Please entered full of apartment' fields.");
                    return;
                }
            }
            else
            {
                if (CheckValidate())
                {
                    var newRequest = new Models.MaintenanceRequest
                    {
                        ApartmentId = int.Parse(cmbApartment.SelectedValue.ToString()),
                        EmployeeId = int.Parse(cmbEmp.SelectedValue.ToString()),
                        RequestDescription = txtDesc.Text.Trim(),
                        RequestStatus = cmbStatus.Text.Trim(),
                        RequestCompletionDate = txtCompleDate.Text.Trim(),
                        RequestDate = textBox1.Text.Trim(),
                        RequestCost = decimal.Parse(txtCost.Text.Trim()),
                    };
                    Program.db.MaintenanceRequests.Add(newRequest);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditRequest_Load(object sender, EventArgs e)
        {
            apartments = Program.db.Apartments.ToList();
            cmbApartment.DataSource = apartments;
            cmbApartment.ValueMember = "ApartmentId";
            cmbApartment.DisplayMember = "ApartmentName";

            employees = Program.db.Employees.ToList();
            cmbEmp.DataSource = employees;
            cmbEmp.ValueMember = "EmployeeId";
            cmbEmp.DisplayMember = "EmployeeName";

            if (Id > 0)
            {
                lblHead.Text = "Update Request";
                var selected = Program.db.MaintenanceRequests.AsNoTracking().FirstOrDefault(x => x.RequestId == Id);

                txtId.Text = selected.RequestId.ToString();
                txtDesc.Text = selected.RequestDescription.ToString();
                textBox1.Text = selected.RequestDate.ToString();
                cmbApartment.DisplayMember = selected.ApartmentId.ToString();
                cmbEmp.DisplayMember = selected.EmployeeId.ToString();
                cmbStatus.Text = selected.RequestStatus.ToString();
                txtCompleDate.Text = selected.RequestCompletionDate.ToString();
                txtCost.Text = selected.RequestCost.ToString();
            }
        }
    }
}
