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
            int soCanHo, tang;
            if (Id > 0)
            {
                if (String.IsNullOrEmpty(txtTCC.Text) ||
                    String.IsNullOrEmpty(txtDiaChi.Text) ||
                    !int.TryParse(txtSCH.Text, out soCanHo) ||
                    !int.TryParse(txtTang.Text, out tang))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin cho căn hộ");
                    return;
                }

                var selectedApartment = Program.db.Apartments.FirstOrDefault(x => x.ApartmentId == Id);
                //selectedApartment.ApartmentRoomCount = soCanHo;
                //selectedApartment.Tang = tang;
                //selectedApartment.TenChungCu = txtTCC.Text.Trim();
                //selectedApartment.DiaChi = txtDiaChi.Text.Trim();
                //selectedApartment.Loai = GetLoaiSelected();
                //Program.db.SaveChanges();
            }
            else
            {
            //    if (String.IsNullOrEmpty(txtTCC.Text) ||
            //        String.IsNullOrEmpty(txtDiaChi.Text) ||
            //        !int.TryParse(txtSCH.Text, out soCanHo) ||
            //        !int.TryParse(txtTang.Text, out tang))
            //    {
            //        MessageBox.Show("Vui lòng nhập đủ thông tin cho căn hộ");
            //        return;
            //    }

            //    var newCanHo = new CanHo
            //    {
            //        TenChungCu = txtTCC.Text.Trim(),
            //        SoCanHo = soCanHo,
            //        Tang = tang,
            //        DiaChi = txtDiaChi.Text.Trim(),
            //        Loai = GetLoaiSelected()
            //    };
            //    Program.db.CanHos.Add(newCanHo);
            //    Program.db.SaveChanges();
            }
            this.Close();
        }
        private string GetLoaiSelected()
        {
            if (radioBtnShop.Checked)
            {
                return "Shophouse";
            }
            return "Căn hộ";
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            //if (Id > 0)
            //{
            //    var selectCanHo = Program.db.CanHos.AsNoTracking().FirstOrDefault(x => x.Id == Id);
            //    txtId.Text = selectCanHo.Id.ToString();
            //    txtSCH.Text = selectCanHo.SoCanHo.ToString();
            //    txtTang.Text = selectCanHo.Tang.ToString();
            //    txtTCC.Text = selectCanHo.TenChungCu.ToString();
            //    txtDiaChi.Text = selectCanHo.DiaChi.ToString();
            //    string loai = selectCanHo.Loai.ToString();
            //    if (loai == "Shophouse")
            //    {
            //        radioBtnShop.Checked = true;
            //    }
            //    else
            //    {
            //        radioBtnCanHo.Checked = true;
            //    }
            //}
        }
    }
}
