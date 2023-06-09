using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Data.ExpressionEditor;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace qlkh
{
    public partial class KhoHang : DevExpress.XtraEditors.XtraForm
    {
        public KhoHang()
        {
            InitializeComponent();
        }
        QLKHEntities q = new QLKHEntities();
        List<HHTrongKho> hHTrongKhos;
        private void KhoHang_Load(object sender, EventArgs e)
        {
            hHTrongKhos = new List<HHTrongKho>();
            loadcbb();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;

            var qq = from a in q.HangHoas select a;
            gridControl1.DataSource = qq.ToList();

            //-----------------------------
            gridControl1.ForceInitialize();

            // Create an unbound column.
            GridColumn unboundColumn = gridView1.Columns.AddField("SL1");
            unboundColumn.VisibleIndex = gridView1.Columns.Count;
            unboundColumn.UnboundDataType = typeof(decimal);
            unboundColumn.Caption = "Số lượng";
            // Disable column edit operations.
            unboundColumn.OptionsColumn.AllowEdit = false;
            // Specify format settings.
            unboundColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            //unboundColumn.DisplayFormat.FormatString = "c";
            // Customize appearance settings.
            unboundColumn.AppearanceCell.BackColor = Color.FromArgb(179, 226, 221);
            gridView1.CustomUnboundColumnData += GridView1_CustomUnboundColumnData;


            hHTrongKhos = (from a in q.HHTrongKhoes where a.SL>0 select a).ToList();
        }

        private void GridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "SL1" && e.IsGetData) e.Value =
              getTotalValue(view, e.ListSourceRowIndex);
        }

        decimal getTotalValue(GridView view, int listSourceRowIndex)
        {
            //ten hh theo gridview
            var ss = view.GetListSourceRowCellValue(listSourceRowIndex, "TenHH");
            int t=0;
            var h = from a in q.HHTrongKhoes select new { a.SL,a.HangHoa.TenHH };
            foreach (var item in h)
            {
                if (item.TenHH==ss.ToString())
                {
                    int v = Convert.ToInt32(item.SL);
                    t += v;
                }
            }
            return t;
        }

        // Specify data for the Total column.
        private void gridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            
        }
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = from s in q.HHTrongKhoes
                        join c in q.HangHoas on s.MaHH equals c.Barcode
                        group c by c.TenHH into g // nhóm theo trường TenHH
                        select new { t = g.Key }; // chọn tên hàng hóa làm khóa của mỗi nhóm
            comboBox1.DataSource = query.ToList();
            comboBox1.DisplayMember = "t";

            // Lưu giá trị của comboBox2.SelectedValue.ToString() vào biến nhaCungCap
            //int nhaCungCap = int.Parse(comboBox2.SelectedValue.ToString());

            //// Sử dụng biến nhaCungCap trong truy vấn
            //var query = from s in q.HangHoas where (s.NhaCungCap == nhaCungCap) select s.TenHH;    
            //comboBox1.DataSource = query.Distinct().ToList();
            //comboBox1.DisplayMember = "TenHH";
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var qq = from a in q.HHTrongKhoes where a.MaKH == commons.user.MaKH && a.HangHoa.TenHH == comboBox1.Text && a.HangHoa.NhaCungCap1.TenNCC==comboBox2.Text select a;
            //gridControl1.DataSource = qq.ToList();
        }

        void loadcbb()
        {
            //var query = from s in q.HHTrongKhoes
            //            join c in q.HangHoas on s.MaHH equals c.Barcode
            //            group c by c.TenHH into g // nhóm theo trường TenHH
            //            select new { t = g.Key}; // chọn tên hàng hóa làm khóa của mỗi nhóm
            //comboBox1.DataSource = query.ToList();
            //comboBox1.DisplayMember = "t";
            var query = from s in q.HangHoas select s.TenHH;
            comboBox1.DataSource = query.Distinct().ToList();
            comboBox1.DisplayMember = "TenHH";

            var query1 = from s in q.NhaCungCaps select s;
            comboBox2.DataSource = query1.ToList();
            comboBox2.ValueMember = "MaNCC";
            comboBox2.DisplayMember = "TenNCC";
        }
        public string s = "";
        void tt()
        {
            //ArrayList Rows1 = new ArrayList();
            //int I;
            //for (I = 0; I < gridView2.SelectedRowsCount; I++)
            //{
            //    if (gridView2.GetSelectedRows()[I] >= 0)
            //    {
            //        Rows1.Add(gridView2.GetDataRow(gridView2.GetSelectedRows()[I]));
            //    }
            //}
            //for (I = 0; I < Rows1.Count; I++)
            //{
            //    DataRow Row2 = (DataRow)Rows1[I];
            //    s = s + (I + 1).ToString() + ". " + Row2["id"] + "\n";
            //    //HHTrongKho hh = (HHTrongKho)Rows1[I];
            //    //s += hh.Id.ToString();
            //}
            ArrayList rows = new ArrayList();
            //string s = "";
            // Add the selected rows to the list.
            Int32[] selectedRowHandles = gridView2.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView1.GetDataRow(selectedRowHandle));
            }
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i] as DataRow;
                s += row["id"];
               
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(s);
            themhhvaophieuxuat f = new themhhvaophieuxuat(s,id1);
            f.Show();
        }
        // gird lồng nhau
        private void gridView1_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            GridView v = sender as GridView;
            HangHoa pkb = v.GetRow(e.RowHandle) as HangHoa;
            if (pkb != null)
            {
                e.IsEmpty = !hHTrongKhos.Any(x => x.HangHoa.TenHH == pkb.TenHH);
            }
        }

        private void gridView1_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            GridView v = sender as GridView;
            HangHoa pkb = v.GetRow(e.RowHandle) as HangHoa;
            if (pkb != null)
            {
                //e.ChildList = hHTrongKhos.Where(x => x.HangHoa.TenHH == pkb.TenHH).ToList();
                var hh = from a in q.HHTrongKhoes where a.HangHoa.TenHH == pkb.TenHH select new { TênHàngHóa=a.HangHoa.TenHH, SốLượng=a.SL,NgàyNhập=a.ChungTu1.Created_Date,NhàCungCấp=a.ChungTu1.NCC,id=a.Id };
                
                //var hh = from a in q.HHTrongKhoes where a.HangHoa.TenHH == pkb.TenHH select a;
                //
                //e.ChildList = hh.ToList();

                //List<HHTrongKho> hh = (from a in q.HHTrongKhoes where a.HangHoa.TenHH == pkb.TenHH select a).ToList();
                e.ChildList = hh.ToList();

                
            }
        }

        private void gridView1_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridView1_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Chi tiết";//detail
        }
        void detail_Click(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            var value = gridView.GetRowCellDisplayText(gridView.FocusedRowHandle, gridView.Columns["id"]);
            //MessageBox.Show(value.ToString());
        }

        private void gridView1_MasterRowExpanded_1(object sender, CustomMasterRowEventArgs e)
        {
            GridView master = sender as GridView;
            GridView detail = master.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            detail.Click += new EventHandler(detail_Click);
            //button1_Click(null,null);
            detail.SelectionChanged += Detail_SelectionChanged;
        }

        private void Detail_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            // Lấy số lượng dòng được chọn
            GridView gridView = sender as GridView;
            int count = gridView.SelectedRowsCount;
            // Lấy tổng giá trị của cột Price trong các dòng được chọn
            decimal total = 0;
            ArrayList id = new ArrayList();
            foreach (int rowHandle in gridView.GetSelectedRows())
            {
                if (rowHandle >= 0) // Nếu là dòng dữ liệu
                {
                    // Lấy giá trị của cột Price tại dòng đó
                    decimal price = Convert.ToDecimal(gridView.GetRowCellValue(rowHandle, "SốLượng"));
                    int price2 = Convert.ToInt32(gridView.GetRowCellValue(rowHandle, "id"));

                    id.Add(price2);
                    // Cộng vào tổng
                    total += price;
                    id1 = id;
                }
            }
            // Hiển thị kết quả lên label
            s = string.Format("Đã chọn: {0}, Tổng số lượng: {1}", count, total);
        }
        ArrayList id1 = new ArrayList();
        ArrayList tenhh1 = new ArrayList();
        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            // Lấy số lượng dòng được chọn
            GridView gridView = sender as GridView;
            int count = gridView.SelectedRowsCount;
            // Lấy tổng giá trị của cột Price trong các dòng được chọn
            decimal total = 0;
            string s2="";
            ArrayList id = new ArrayList();
            ArrayList tenhh = new ArrayList();

            foreach (int rowHandle in gridView.GetSelectedRows())
            {
                if (rowHandle >= 0) // Nếu là dòng dữ liệu
                {
                    // Lấy giá trị của cột Price tại dòng đó
                    string price = Convert.ToString(gridView.GetRowCellValue(rowHandle, "TenHH"));
                    int price2 = Convert.ToInt32(gridView.GetRowCellValue(rowHandle, "SL1"));

                    id.Add(price2);
                    // Cộng vào tổng
                    total += price2;
                    id1 = id;
                    s2 += price;
                    tenhh.Add(price);
                    
                }
            }
            tenhh1 = tenhh;
            // Hiển thị kết quả lên label
            label2.Text = s2;
            s = string.Format("Đã chọn: {0}, Tổng số lượng: {1}", count, total);
        }
    }
}