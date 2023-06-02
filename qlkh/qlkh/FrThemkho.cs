using DevExpress.XtraEditors;
using qlkh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLK
{
    public partial class FrThemkho : DevExpress.XtraEditors.XtraForm
    {
        string opt = "";
        qlkh.QLKHEntities db = new qlkh.QLKHEntities();
        public FrThemkho()
        {
            InitializeComponent();
        }

        private void Themkho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKHDataSet.Kho' table. You can move, or remove it, as needed.
            //this.khoTableAdapter.Fill(this.qLKHDataSet.Kho);
            khoBindingSource.DataSource = db.Khoes.ToList();

            txtMaKH.Enabled = false;
        }

        public void clear()
        {
            txtTenkho.Text = txtDiaChi.Text = "";
        }

        public void Add()
        {
            var newKho = new Kho();

            newKho.TenKH = txtTenkho.Text.Trim();
            newKho.DiaChiKH = txtDiaChi.Text.Trim();

            db.Khoes.Add(newKho);
            db.SaveChanges();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaKH.Enabled = true;
            opt = "1";
            khoBindingSource.AddNew();

            txtTenkho.Focus();
        }

        public void update()
        {
            int id = Convert.ToInt32(txtMaKH.Text.Trim());
            Kho newKho = db.Khoes.FirstOrDefault(c => c.MaKH == id);

            newKho.TenKH = txtTenkho.Text.Trim();
            newKho.DiaChiKH = txtDiaChi.Text.Trim();

            db.SaveChanges();
        }


        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTenkho.Text != "")
            {
                if (opt == "1")
                {
                    Add();
                }
                else
                    update();

                opt = "";
                Themkho_Load(sender, e);
                XtraMessageBox.Show("Dữ liệu đã được lưu", "Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(" tên không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa hay không? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtMaKH.Text.Trim());
                Kho newKho = db.Khoes.FirstOrDefault(c => c.MaKH == id);
                db.Khoes.Remove(newKho);
                db.SaveChanges();
                Themkho_Load(sender, e);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}