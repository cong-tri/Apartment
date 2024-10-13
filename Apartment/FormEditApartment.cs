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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KTDK_CanHo_DaoCongTri
{
    public partial class FormEditApartment : Form
    {
        private List<Models.Type> types = new List<Models.Type>();
        public int Id { get; set; }
        public FormEditApartment()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int typeId = int.Parse(cmbType.SelectedValue.ToString());
            double area = double.Parse(txtArea.Text);
            int floor = int.Parse(txtFloor.Text);
            int roomCounts = int.Parse(txtRooms.Text);
            decimal price = decimal.Parse(txtPrice.Text);

            if (Id > 0)
            {
                if (CheckValidate())
                {
                    var selectedApartment = Program.db.Apartments.FirstOrDefault(x => x.ApartmentId == Id);
                    selectedApartment.TypeId = typeId;
                    selectedApartment.ApartmentArea = area;
                    selectedApartment.ApartmentName = txtName.Text.Trim();
                    selectedApartment.ApartmentNumber = txtNumber.Text.Trim();
                    selectedApartment.ApartmentStatus = cmbStatus.Text.Trim();
                    selectedApartment.ApartmentFloor = floor;
                    selectedApartment.ApartmentRoomCount = roomCounts;
                    selectedApartment.ApartmentMonthlyRentPrice = price;
                    selectedApartment.ApartmentHasBalcony = GetHasBalconySelected();
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
                    var newApartment = new Models.Apartment
                    {
                        TypeId = typeId,
                        ApartmentNumber = txtNumber.Text.Trim(),
                        ApartmentName = txtName.Text.Trim(),
                        ApartmentArea = area,
                        ApartmentFloor = floor,
                        ApartmentStatus = cmbStatus.Text.Trim(),
                        ApartmentRoomCount = roomCounts,
                        ApartmentMonthlyRentPrice = price,
                        ApartmentHasBalcony = GetHasBalconySelected(),
                    };
                    Program.db.Apartments.Add(newApartment);
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
        private string GetHasBalconySelected()
        {
            if (radioBtnTrue.Checked)
            {
                return "T";
            }
            return "F";
        }
        private bool CheckValidate()
        {
            if (!String.IsNullOrEmpty(txtName.Text) ||
                !String.IsNullOrEmpty(txtNumber.Text) ||
                !String.IsNullOrEmpty(cmbStatus.Text) ||
                int.TryParse(cmbType.SelectedValue.ToString(), out int type) ||
                int.TryParse(txtFloor.Text, out int floor) ||
                double.TryParse(txtArea.Text, out double tang) ||
                decimal.TryParse(txtPrice.Text, out decimal price)) 
            {
                return true;
            }

            return false;
        }
        private void FormEdit_Load(object sender, EventArgs e)
        {
            types = Program.db.Types.ToList();
            cmbType.DataSource = types;
            cmbType.ValueMember = "TypeId";
            cmbType.DisplayMember = "TypeName";

            if (Id > 0)
            {
                lblHead.Text = "Update Apartment";
                var selected = Program.db.Apartments.AsNoTracking().FirstOrDefault(x => x.ApartmentId == Id);

                txtId.Text = selected.ApartmentId.ToString();
                txtNumber.Text = selected.ApartmentNumber.ToString();
                txtName.Text = selected.ApartmentName.ToString();
                txtArea.Text = selected.ApartmentArea.ToString();
                txtFloor.Text = selected.ApartmentFloor.ToString();
                txtRooms.Text = selected.ApartmentRoomCount.ToString();
                cmbType.DisplayMember = selected.TypeId.ToString();
                cmbStatus.Text = selected.ApartmentStatus.ToString();
                txtPrice.Text = selected.ApartmentMonthlyRentPrice.ToString();
                if (selected.ApartmentHasBalcony == "T")
                {
                    radioBtnTrue.Checked = true;
                }
                else
                {
                    radioBtnFalse.Checked = true;
                }
            }
        }
    }
}
