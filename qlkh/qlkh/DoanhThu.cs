using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlkh
{
    public partial class DoanhThu : DevExpress.XtraEditors.XtraForm
    {
        public DoanhThu()
        {
            InitializeComponent();
        }
        QLKHEntities q = new QLKHEntities();
        private void DoanhThu_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Series _seri = new Series("Doanh thu bán hàng theo nhóm hàng", ViewType.Pie);
            var lst = (from a in q.HHXKs where a.ChungTu1.NgayXuat <= dateTimePicker2.Value && a.ChungTu1.NgayXuat >= dateTimePicker1.Value select a).ToList();
            //var lst = from a in q.HHXKs select a;
            List<hxk> s = new List<hxk>();
            List<hxk> s1 = new List<hxk>();
            // tuổi trẻ :((
            //foreach (var item in lst)
            //{
            //    hxk h = new hxk();
            //    h.tenhh = item.HHTrongKho.HangHoa.TenHH;
            //    var i = from a in q.HHXKs where a.HHTrongKho.HangHoa.TenHH == item.HHTrongKho.HangHoa.TenHH select new { tt = a.GiaBan * a.SLban };
            //    foreach (var item1 in i)
            //    {
            //        h.thanhtien += (int)item1.tt;
            //    }
            //    s.Add(h);
            //}
            Series _seri2 = new Series("Doanh thu bán hàng theo nhóm hàng", ViewType.Bar);

            var groups = from item in lst
                         group item by item.HHTrongKho.HangHoa.TenHH into g
                         select new { tenhh = g.Key, thanhtien = g.Sum(x => (x.GiaBan - x.HHTrongKho.GiaMua) * x.SLban) };
            int tong = 0;
            foreach (var item in groups)
            {
                _seri.Points.Add(new SeriesPoint(item.tenhh, item.thanhtien));
                _seri2.Points.Add(new SeriesPoint(item.tenhh, item.thanhtien));
                tong += (int)item.thanhtien;
            }
            labelControl4.Text = tong.ToString();
            chartControl1.Series.Clear();
            chartControl1.Series.Add(_seri);
            _seri.Label.TextPattern = "{A}: {VP: p0}";
            chartControl2.Series.Clear();

            chartControl2.Series.Add(_seri2);
            _seri2.Label.TextPattern = "{A}: {V:F1}";

            //Tổng doanh thu theo năm
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged(sender, e);
        }
    }
}