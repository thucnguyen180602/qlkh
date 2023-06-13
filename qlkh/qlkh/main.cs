using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using QLK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlkh
{
    public partial class main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public main()
        {
            InitializeComponent();
        }
        OverlayWindowOptions options = new OverlayWindowOptions(
        backColor: Color.Black,
        opacity: 0.5,
        fadeIn: false,
        fadeOut: false
        );
        public void openform(Type form)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == form)
                {
                    f.Activate();
                    //f.Refresh();
                    //if (f.Name=="KhoHang")
                    //{
                    //    f.Refresh();
                    //}
                    return;
                }
            }
            Form f2 = (Form)Activator.CreateInstance(form);
            f2.MdiParent = this;
            if (f2.Name == "PhieuNhap")
            {
                taomaphieu();
            }
            if(f2.Name == "PhieuXuat")
            {
                using (QLKHEntities db = new QLKHEntities())
                {
                    Guid maphieu = Guid.NewGuid();
                    ChungTu c = new ChungTu();
                    c.ChungTu1 = maphieu;
                    c.Created_Date = DateTime.Now;
                    c.Created_By = commons.user.Id;
                    commons.ct2 = c;
                    db.ChungTus.Add(c);
                    db.SaveChanges();
                }
            }
            f2.Show();
        }
        IOverlaySplashScreenHandle ShowProgressPanel(Control control, OverlayWindowOptions op)
        {
            return SplashScreenManager.ShowOverlayForm(control, op);
        }
        private void main_Load(object sender, EventArgs e)
        {
            commons.handle = ShowProgressPanel(this, options);
            login f = new login();
            f.ShowDialog();
        }
        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (commons.user.ChucVu1.TenCV == "Nhân viên")
            {
                MessageBox.Show("bạn không có quyền try cập!");
            }
            else
            {
                openform(typeof(DanhMucHangHoa));
            }
        }

        public void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            openform(typeof(KhoHang));
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            openform(typeof(PhieuNhap));
        }
        void taomaphieu()
        {
            using (QLKHEntities db = new QLKHEntities())
            {
                Guid maphieu = Guid.NewGuid();
                ChungTu c = new ChungTu();
                c.ChungTu1 = maphieu;
                c.Created_Date = DateTime.Now;
                c.Created_By = commons.user.Id;
                commons.ct = c;
                db.ChungTus.Add(c);
                db.SaveChanges();
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            openform(typeof(PhieuXuat));
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (commons.user.ChucVu1.TenCV == "Nhân viên" || commons.user.ChucVu1.TenCV == "Quản lý")
            {
                MessageBox.Show("bạn không có quyền try cập!");
            }
            else
            {
                openform(typeof(FrThemkho));
            }

        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (commons.user.ChucVu1.TenCV == "Nhân viên" || commons.user.ChucVu1.TenCV == "Quản lý")
            {
                MessageBox.Show("bạn không có quyền try cập!");
            }
            else
            {
                openform(typeof(FrNhaCungCap));
            }

        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (commons.user.ChucVu1.TenCV == "Nhân viên" || commons.user.ChucVu1.TenCV == "Quản lý")
            {
                MessageBox.Show("bạn không có quyền try cập!");
            }
            else
            {
                openform(typeof(FrDonVi));

            }

        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            openform(typeof(dsct));

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                item.Close();
            }
            login f = new login();
            f.ShowDialog();
        }

        private void barStaticItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            // hien thong tin ca nhan

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (commons.user.ChucVu1.TenCV == "Nhân viên")
            {
                MessageBox.Show("bạn không có quyền try cập!");
            }
            else
            {
                openform(typeof(DoanhThu));
            }
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (commons.user.ChucVu1.TenCV== "admin")
            {

            }
        }
    }
}