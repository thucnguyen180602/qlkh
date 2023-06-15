using DevExpress.XtraEditors;
using qlkh;
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
    public partial class FrDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        string opt = "";
        QLKHEntities db = new QLKHEntities();

        public FrDonViTinh()
        {
            InitializeComponent();
        }

        private void FrDonViTinh_Load(object sender, EventArgs e)
        {
            donViTinhBindingSource.DataSource = db.DonViTinhs.ToList();
            txtMaDVT.Enabled = false;
        }

        public void clear()
        {
            txtTenDVT.Text =  "";
        }

        public void Add()
        {
            var NewDonViTinh = new DonViTinh();

            NewDonViTinh.TenDVT = txtTenDVT.Text.Trim();

            db.DonViTinhs.Add(NewDonViTinh);
            db.SaveChanges();
        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaDVT.Enabled = true;
            opt = "1";
            donViTinhBindingSource.AddNew();
            txtTenDVT.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa hay không? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtMaDVT.Text.Trim());
                DonViTinh newDonViTinh = db.DonViTinhs.FirstOrDefault(c => c.MaDVT == id);
                db.DonViTinhs.Remove(newDonViTinh);

                db.SaveChanges();
                FrDonViTinh_Load(sender, e);
            }
        }

        public void update()
        {
            int id = Convert.ToInt32(txtMaDVT.Text.Trim());
            DonViTinh newDonViTinh = db.DonViTinhs.FirstOrDefault(c => c.MaDVT == id);

            newDonViTinh.TenDVT = txtTenDVT.Text.Trim();
            

            db.SaveChanges();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTenDVT.Text != "")
            {
                if (opt == "1")
                {
                    Add();
                }
                else
                    update();

                opt = "";
                FrDonViTinh_Load(sender, e);
                XtraMessageBox.Show("Dữ liệu đã được lưu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(" tên không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void donViTinhBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}