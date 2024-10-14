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
    public partial class FormDeleteRequest : Form
    {
        public int Id { get; set; }
        public FormDeleteRequest()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                var selected = Program.db.MaintenanceRequests.FirstOrDefault(x => x.RequestId == Id);
                if (selected != null)
                {
                    Program.db.MaintenanceRequests.Remove(selected);
                    Program.db.SaveChanges();
                    MessageBox.Show("Data has been removed");
                }
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
