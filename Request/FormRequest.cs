using KTDK_CanHo_DaoCongTri.Employee;
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

namespace KTDK_CanHo_DaoCongTri.Request
{
    public partial class FormRequest : Form
    {
        private List<Models.MaintenanceRequest> maintenanceRequests = new List<Models.MaintenanceRequest>();
        public FormRequest()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            maintenanceRequests = Program.db.MaintenanceRequests.ToList();
            dataGrv.AutoGenerateColumns = false;
            dataGrv.DataSource = maintenanceRequests;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEditRequest formEdit = new FormEditRequest();
            formEdit.ShowDialog();
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGrv.CurrentRow != null)
            {
                FormEditRequest formEdit = new FormEditRequest();
                formEdit.Id = Convert.ToInt32(dataGrv.CurrentRow.Cells["RequestId"].Value);
                formEdit.ShowDialog();
                Program.db.SaveChanges();
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGrv.CurrentRow != null)
            {
                FormDeleteRequest formDelete = new FormDeleteRequest();
                formDelete.Id = Convert.ToInt32(dataGrv.CurrentRow.Cells["RequestId"].Value);
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
                var lst = maintenanceRequests.Where(x => x.RequestId.ToString().Contains(searchKey) ||
                x.ApartmentId.ToString().ToLower().Contains(searchKey) ||
                x.EmployeeId.ToString().ToLower().Contains(searchKey) ||
                x.RequestStatus.ToString().ToLower().Contains(searchKey)).ToList();
                dataGrv.DataSource = lst;
            }
        }
    }
}
