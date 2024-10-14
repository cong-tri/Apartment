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
    public partial class FormDeleteEmployee : Form
    {
        public int Id { get; set; }
        public FormDeleteEmployee()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                bool isReferenced = Program.db.MaintenanceRequests.Any(x => x.EmployeeId == Id);

                if (isReferenced)
                {
                    MessageBox.Show("This type is referenced in the Request table and cannot be deleted.");
                    return;
                }
                var selected = Program.db.Employees.FirstOrDefault(x => x.EmployeeId == Id);
                if (selected != null)
                {
                    Program.db.Employees.Remove(selected);
                    Program.db.SaveChanges();
                    MessageBox.Show("Data has been removed");
                }
                this.Close();
            }
        }
    }
}
