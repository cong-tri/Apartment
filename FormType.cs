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
    public partial class FormType : Form
    {
        private List<Models.Type> types = new List<Models.Type>();
        private int Id { get; set; } = 0;

        public FormType()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            types = Program.db.Types.ToList();
            dataGrdView_Type.AutoGenerateColumns = false;
            dataGrdView_Type.DataSource = types;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                //if (String.IsNullOrEmpty(txt.Text) ||
                //    String.IsNullOrEmpty(txtDiaChi.Text) ||
                //    !int.TryParse(txtSCH.Text, out soCanHo) ||
                //    !int.TryParse(txtTang.Text, out tang))
                //{
                //    MessageBox.Show("Vui lòng nhập đủ thông tin cho căn hộ");
                //    return;
                //}

                //var selectedApartment = Program.db.Types.FirstOrDefault(x => x.ApartmentId == Id);
                //selectedApartment.ApartmentRoomCount = soCanHo;
                //selectedApartment.Tang = tang;
                //selectedApartment.TenChungCu = txtTCC.Text.Trim();
                //selectedApartment.DiaChi = txtDiaChi.Text.Trim();
                //selectedApartment.Loai = GetLoaiSelected();
                //Program.db.SaveChanges();
            }
            else
            {
                if (String.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Please entered the name for type!");
                    txtName.Focus();
                    return;
                }

                var newType = new Models.Type
                {
                    TypeName = txtName.Text.Trim()
                };
                Program.db.Types.Add(newType);
                Program.db.SaveChanges();
                MessageBox.Show("Data has been saved");
                LoadData();
            }
        }

        private void dataGrdView_Type_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = e.RowIndex;

            if (Id > 0) {
                var selectType = Program.db.Types.AsNoTracking().FirstOrDefault(x => x.TypeId == Id);
                txtId.Text = selectType.TypeId.ToString();
                txtName.Text = selectType.TypeName.ToString();
            }
        }
    }
}
