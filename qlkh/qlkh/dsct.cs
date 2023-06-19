using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlkh
{
    public partial class dsct : DevExpress.XtraEditors.XtraForm
    {
        public dsct()
        {
            InitializeComponent();
        }
        QLKHEntities q = new QLKHEntities();
        private void dsct_Load(object sender, EventArgs e)
        {
            
            //gridControl1.DataSource = q.ChungTus.ToList();

            string[] cities = new string[] { "Phiếu nhập kho", "Phiếu xuất kho" };

            // Gán mảng làm nguồn dữ liệu cho combobox
            comboBox1.DataSource = cities;

            NCC.DataSource = q.NhaCungCaps.ToList();
            NCC.ValueMember = "MaNCC";
            NCC.DisplayMember = "TenNCC";

            DVX.DataSource = q.DonVis.ToList();
            DVX.ValueMember = "MaDV";
            DVX.DisplayMember = "TenDV";

            repositoryItemLookUpEdit1.DataSource = q.Users.ToList();
            repositoryItemLookUpEdit1.ValueMember = "Id";
            repositoryItemLookUpEdit1.DisplayMember = "FullName";

            hHTrongKhos = (from a in q.HHTrongKhoes select a).ToList();
            hhxk= (from a in q.HHXKs select a).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                gridControl1.DataSource = q.ChungTus.Where(a => a.NhaCungCap != null).ToList();
                gridColumn5.Visible = false;
                gridColumn6.Visible = false;

                gridColumn3.Visible = true;
                gridColumn7.Visible = true;
            }
            else
            {
                gridControl1.DataSource = q.ChungTus.Where(a => a.DVX != null).ToList();
                gridColumn3.Visible = false;
                gridColumn7.Visible = false;

                gridColumn5.Visible = true;
                gridColumn6.Visible = true;
            }
        }
        List<HHTrongKho> hHTrongKhos = new List<HHTrongKho>();
        List<HHXK> hhxk = new List<HHXK>();

        private void gridView1_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView v = sender as GridView;
            ChungTu pkb = v.GetRow(e.RowHandle) as ChungTu;
            if (pkb != null)
            {
                if (comboBox1.SelectedIndex==0)
                {
                    e.IsEmpty = !hHTrongKhos.Any(x => x.ChungTu == pkb.ChungTu1);
                }
                else
                {
                    e.IsEmpty = !hhxk.Any(x => x.ChungTu == pkb.ChungTu1);
                }
            }
        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView v = sender as GridView;
            ChungTu pkb = v.GetRow(e.RowHandle) as ChungTu;
            if (pkb != null)
            {
                if (comboBox1.SelectedIndex==0)
                {
                    var hh = from a in q.HHTrongKhoes where a.ChungTu == pkb.ChungTu1 select new { TênHàngHóa = a.HangHoa.TenHH, SốLượng = a.SL, GíaMua = a.GiaMua, NhàCungCấp = a.ChungTu1.NhaCungCap.TenNCC, id = a.Id, };
                    e.ChildList = hh.ToList();
                }
                else
                {
                    var hh = from a in q.HHXKs where a.ChungTu == pkb.ChungTu1 select new { TênHàngHóa = a.HHTrongKho.HangHoa.TenHH, SốLượngBán = a.SLban, GíaBán = a.GiaBan, NhàCungCấp = a.HHTrongKho.ChungTu1.NhaCungCap.TenNCC, id = a.idhhtk, };
                    e.ChildList = hh.ToList();
                }
            }
        }

        private void gridView1_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridView1_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Chi tiết";//detail
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XtraReport2 a = new XtraReport2();
            var aa = from s in q.HHXKs where s.ChungTu.ToString() == ss select s;
            a.DataSource = aa.ToList();
            a.ShowPreviewDialog();
        }
        String ss;
        private void gridControl1_Click(object sender, EventArgs e)
        {
            ss = gridView1.GetFocusedRowCellValue("ChungTu1").ToString();

        }

        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                delete(ss);
                q.SaveChanges();
            }
        }
        public void delete(String mabn)
        {
            try
            {
                var bn = q.ChungTus.FirstOrDefault(x => x.ChungTu1.ToString() == ss);
                q.ChungTus.Remove(bn);
                q.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}