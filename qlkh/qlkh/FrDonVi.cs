using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLK
{
    public partial class FrDonVi : DevExpress.XtraEditors.XtraForm
    {

        string opt = "";
        qlkh.QLKHEntities db = new qlkh.QLKHEntities();
        public FrDonVi()
        {
            InitializeComponent();
        }

        private void FrDonVi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKHDataSet2.DonVi' table. You can move, or remove it, as needed.
            //this.donViTableAdapter.Fill(this.qLKHDataSet2.DonVi);
            donViBindingSource.DataSource = db.DonVis.ToList();
            txtMaDV.Enabled = false;
        }


        public void clear()
        {
            txtTenDV.Text = txtSDTDV.Text = txtDiaChiDV.Text = "";
        }

        public void Add()
        {
            var NewDonVi = new qlkh.DonVi();

            NewDonVi.TenDV = txtTenDV.Text.Trim();
            NewDonVi.SDTDV = txtSDTDV.Text.Trim();
            NewDonVi.DCDV = txtDiaChiDV.Text.Trim();

            db.DonVis.Add(NewDonVi);
            db.SaveChanges();
        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaDV.Enabled = true;
            opt = "1";
            donViBindingSource.AddNew();

            txtTenDV.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa hay không? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtMaDV.Text.Trim());
                qlkh.DonVi newDonVi = db.DonVis.FirstOrDefault(c => c.MaDV == id);
                db.DonVis.Remove(newDonVi);

                db.SaveChanges();
                FrDonVi_Load(sender, e);
            }
        }

        public void update()
        {
            int id = Convert.ToInt32(txtMaDV.Text.Trim());
            qlkh.DonVi newDonVi = db.DonVis.FirstOrDefault(c => c.MaDV == id);

            newDonVi.TenDV = txtTenDV.Text.Trim();
            newDonVi.SDTDV = txtSDTDV.Text.Trim();
            newDonVi.DCDV = txtDiaChiDV.Text.Trim();

            db.SaveChanges();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTenDV.Text != "")
            {
                if (opt == "1")
                {
                    Add();
                }
                else
                    update();

                opt = "";
                FrDonVi_Load(sender, e);
                XtraMessageBox.Show("Dữ liệu đã được lưu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(" tên không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}