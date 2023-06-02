using DevExpress.XtraEditors;
using qlkh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLK
{
    public partial class FrNhaCungCap : DevExpress.XtraEditors.XtraForm
    {

        string opt = "";
        qlkh.QLKHEntities db = new qlkh.QLKHEntities();
        public FrNhaCungCap()
        {
            InitializeComponent();
        }

        private void FrNhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKHDataSet1.NhaCungCap' table. You can move, or remove it, as needed.
            //this.nhaCungCapTableAdapter.Fill(this.qLKHDataSet1.NhaCungCap);
            nhaCungCapBindingSource.DataSource = db.NhaCungCaps.ToList();
            txtMaNCC.Enabled = false;
        }

        public void clear()
        {
            txtTenNCC.Text = txtSDTNCC.Text = txtEmailNCC.Text = "";
        }

        public void Add()
        {
            var newNhaCungCap = new NhaCungCap();

            newNhaCungCap.TenNCC = txtTenNCC.Text.Trim();
            newNhaCungCap.SDTNCC = txtSDTNCC.Text.Trim();
            newNhaCungCap.EmailNCC = txtSDTNCC.Text.Trim();

            db.NhaCungCaps.Add(newNhaCungCap);
            db.SaveChanges();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaNCC.Enabled = true;
            opt = "1";
            nhaCungCapBindingSource.AddNew();

            txtTenNCC.Focus();
        }


        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa hay không? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtMaNCC.Text.Trim());
                NhaCungCap newNhaCungCap = db.NhaCungCaps.FirstOrDefault(c => c.MaNCC == id);
                db.NhaCungCaps.Remove(newNhaCungCap);

                db.SaveChanges();
                FrNhaCungCap_Load(sender, e);
            }
        }
        public void update()
        {
            int id = Convert.ToInt32(txtMaNCC.Text.Trim());
            NhaCungCap newNhaCungCap = db.NhaCungCaps.FirstOrDefault(c => c.MaNCC == id);

            newNhaCungCap.TenNCC = txtTenNCC.Text.Trim();
            newNhaCungCap.SDTNCC =  txtSDTNCC.Text.Trim();
            newNhaCungCap.EmailNCC =  txtEmailNCC.Text.Trim();

            db.SaveChanges();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTenNCC.Text != "")
            {
                if (opt == "1")
                {
                    Add();
                }
                else
                    update();

                opt = "";
                FrNhaCungCap_Load(sender, e);
                XtraMessageBox.Show("Dữ liệu đã được lưu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(" tên không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtEmailNCC_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
