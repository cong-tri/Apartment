using KTDK_CanHo_DaoCongTri.Models;

namespace KTDK_CanHo_DaoCongTri
{
    public partial class FormApartment : Form
    {
        private List<Models.Apartment> apartments = new List<Models.Apartment>();
        public FormApartment()
        {
            InitializeComponent();
            //LoadData();
        }
        private void LoadData()
        {
            apartments = Program.db.Apartments.ToList();
            dataGrv.AutoGenerateColumns = false;
            dataGrv.DataSource = apartments;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 13)
            //{
            //    var searchKey = txtSearch.Text.Trim().ToLower();
            //    var lst = apartments.Where(x => x.ApartmentName.ToLower().Contains(searchKey)).ToList();
            //    dataGrv.DataSource = lst;
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEditApartment formEditApartment = new FormEditApartment();
            formEditApartment.ShowDialog();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            FormEditApartment formEditApartment = new FormEditApartment();
            formEditApartment.ShowDialog();

            //if (dataGrv.CurrentRow != null)
            //{
            //    FormEditApartment formEditApartment = new FormEditApartment();
            //    formEditApartment.Id = Convert.ToInt32(dataGrv.CurrentRow.Cells["ApartmentId"].Value);
            //    formEditApartment.ShowDialog();
            //    Program.db.SaveChanges();
            //    LoadData();
            //}
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            FormDeleleApartment formDelete = new FormDeleleApartment();
            formDelete.ShowDialog();

            //if (dataGrv.CurrentRow != null)
            //{
            //    FormDeleleApartment formDelete = new FormDeleleApartment();
            //    formDelete.Id = Convert.ToInt32(dataGrv.CurrentRow.Cells["ApartmentId"].Value);
            //    formDelete.ShowDialog();
            //    Program.db.SaveChanges();
            //    LoadData();
            //}
        }
    }
}
