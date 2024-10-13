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
                if (String.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Please entered the name for type!");
                    txtName.Focus();
                    return;
                }

                var selected = Program.db.Types.FirstOrDefault(x => x.TypeId == Id);
                selected.TypeName = txtName.Text;
                Program.db.SaveChanges();
                MessageBox.Show("Data has been saved");
                LoadData();

                btn_save.Text = "Add";
                txtId.Clear();
                txtName.Clear();
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
            Id = e.RowIndex + 1;

            if (Id > 0)
            {
                btn_save.Text = "Update";
                var selectType = Program.db.Types.AsNoTracking().FirstOrDefault(x => x.TypeId == Id);
                txtId.Text = selectType.TypeId.ToString();
                txtName.Text = selectType.TypeName.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                bool isReferenced = Program.db.Apartments.Any(x => x.TypeId == Id);

                if (isReferenced)
                {
                    MessageBox.Show("This type is referenced in the Apartment table and cannot be deleted.");
                    return;
                }

                var selected = Program.db.Types.FirstOrDefault(x => x.TypeId == Id);
                if (selected != null)
                {
                    Program.db.Types.Remove(selected);
                    Program.db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Data has been removed");
                    txtId.Clear();
                    txtName.Clear();
                }

            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                var searchKey = txtSearch.Text.Trim().ToLower();
                var lst = types.Where(x => x.TypeName.ToLower().Contains(searchKey)).ToList();
                dataGrdView_Type.DataSource = lst;
            }
        }
    }
}
