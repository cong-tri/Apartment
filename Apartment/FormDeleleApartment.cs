using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTDK_CanHo_DaoCongTri
{
    public partial class FormDeleleApartment : Form
    {
        public int Id { get; set; }
        public FormDeleleApartment()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                bool isReferenced = Program.db.MaintenanceRequests.Any(x => x.ApartmentId == Id);

                if (isReferenced)
                {
                    MessageBox.Show("This type is referenced in the Request table and cannot be deleted.");
                    return;
                }
                var selectedApartment = Program.db.Apartments.FirstOrDefault(x => x.ApartmentId == Id);
                if (selectedApartment != null)
                {
                    Program.db.Apartments.Remove(selectedApartment);
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
