﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Design;
using System.Diagnostics;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils.MVVM;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace qlkh
{
    public partial class PhieuXuat : DevExpress.XtraEditors.XtraForm
    {
        qlkh.QLKHEntities dbContext = new qlkh.QLKHEntities();

        public PhieuXuat()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            //dbContext.HHXKs.Where(a => a.ChungTu == commons.ct2.ChungTu1).LoadAsync().ContinueWith(loadTask =>
            //{
            //    // Bind data to control when loading complete
            //    hHXKsBindingSource.DataSource = dbContext.HHXKs.Local.ToBindingList();
            //}, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        QLKHEntities q = new QLKHEntities();
        private void PhieuXuat_Load(object sender, EventArgs e)
        {
            dbContext.HHXKs.Where(a => a.ChungTu == commons.ct2.ChungTu1).Load();
            // Bind data to control when loading complete
            hHXKsBindingSource.DataSource = dbContext.HHXKs.Local.ToBindingList();

            var ncc = from a in q.DonVis select a;
            comboBox1.DataSource = ncc.ToList();
            comboBox1.ValueMember = "MaDV";
            comboBox1.DisplayMember = "TenDV";

            var hh = from a in q.HHTrongKhoes select new {id=a.Id,tenhh=a.HangHoa.TenHH};
            repositoryItemLookUpEdit2.DataSource = hh.ToList();
            repositoryItemLookUpEdit2.ValueMember = "id";
            repositoryItemLookUpEdit2.DisplayMember = "tenhh";
            repositoryItemLookUpEdit2.NullText = "Chọn hàng hóa có trong kho";

            //TỰ ĐỘNG THÊM 
            gridView1.InitNewRow += (s, ee) => {
                GridView view = s as GridView;
                view.SetRowCellValue(ee.RowHandle, view.Columns["ChungTu"], commons.ct2.ChungTu1);
                //MessageBox.Show(view.GetRowCellValue(ee.RowHandle, view.Columns["idhhtk"]).ToString());
                //view.SetRowCellValue(ee.RowHandle, view.Columns["SLBan"], commons.ct2.ChungTu1);
                //repositoryItemSpinEdit1.MaxValue = 100;
            };

            gridControl1.ForceInitialize();
            // Create an unbound column.
            GridColumn unboundColumn = gridView1.Columns.AddField("Total");
            unboundColumn.VisibleIndex = gridView1.Columns.Count;
            unboundColumn.UnboundDataType = typeof(decimal);
            unboundColumn.Caption = "Thành tiền";
            // Disable column edit operations.
            unboundColumn.OptionsColumn.AllowEdit = false;
            // Specify format settings.
            unboundColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            unboundColumn.DisplayFormat.FormatString = "#,##0 \"VND\"";
            // Customize appearance settings.
            unboundColumn.AppearanceCell.BackColor = Color.FromArgb(179, 226, 221);
            gridView1.CustomUnboundColumnData += GridView1_CustomUnboundColumnData;

            gridView1.Columns["Total"].VisibleIndex = 4;

            repositoryItemSpinEdit1.ValueChanged += RepositoryItemSpinEdit1_ValueChanged;
        }

        private void RepositoryItemSpinEdit1_ValueChanged(object sender, EventArgs e)
        {
            //string ss = gridView1.GetFocusedDataRow();
            //int t = 0;
            //var h = from a in q.HHTrongKhoes select new { a.SL, a.HangHoa.TenHH };
            //foreach (var item in h)
            //{
            //    if (item.TenHH == ss.ToString())
            //    {
            //        int v = Convert.ToInt32(item.SL);
            //        t += v;
            //    }
            //}
            //repositoryItemSpinEdit1.MaxValue = t;
        }

        private void GridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "Total" && e.IsGetData) e.Value =
              getTotalValue(view, e.ListSourceRowIndex);
        }
        decimal getTotalValue(GridView view, int listSourceRowIndex)
        {
            decimal unitPrice = Convert.ToDecimal(view.GetListSourceRowCellValue(listSourceRowIndex, "GiaBan"));
            decimal quantity = Convert.ToDecimal(view.GetListSourceRowCellValue(listSourceRowIndex, "SLban"));
            return unitPrice * quantity;
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        int idhhtk = 0;
        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            dbContext.SaveChanges();
            //MessageBox.Show(gridView1.GetFocusedRowCellValue("idhhtk").ToString());
            idhhtk = int.Parse(gridView1.GetFocusedRowCellValue("idhhtk").ToString());
            string hhtk="";
            int slban = int.Parse(gridView1.GetFocusedRowCellValue("SLban").ToString());
            var s = from a in q.HHTrongKhoes where a.Id==idhhtk select a.HangHoa.TenHH;
            foreach (var item1 in s)
            {
                hhtk = item1;
            }
            int t = 0;
            var h = from a in q.HHTrongKhoes select new { a.SL, a.HangHoa.TenHH };
            foreach (var item in h)
            {
                if (item.TenHH == hhtk)
                {
                    int v = Convert.ToInt32(item.SL);
                    t += v;
                }
            }

            if (slban<t)
            {
                int tongsoluong = t;
                int tslban = slban;
                //cap nhat lai kho hang
                using (QLKHEntities q1 = new QLKHEntities())
                {
                    var hh = (from a in q1.HHTrongKhoes where a.HangHoa.TenHH == hhtk select a).ToList();
                    foreach (var item in hh)
                    {
                        if (item.SL <= tslban)
                        {
                            tslban =(int)(tslban-item.SL);
                            item.SL = 0;

                        }
                        else
                        {
                            item.SL-=tslban;
                        }
                    }
                    q1.SaveChanges();
                    //xoa
                    using (QLKHEntities q2 = new QLKHEntities())
                    {
                        // Lấy ra danh sách các items có id lớn hơn 10
                        var items = q2.HHTrongKhoes.Where(i => i.SL == 0).ToList();
                        // Xóa các items khỏi cơ sở dữ liệu
                        q2.HHTrongKhoes.RemoveRange(items);
                        // Lưu thay đổi
                        q2.SaveChanges();
                    }
                }
                

            }
            else
            {
                //focus den o so luong ban
                string m1 = string.Format("Số lượng hàng trong kho không đủ! Vui lòng nhập lại số lượng (<={0})", t.ToString());
                MessageBox.Show(m1);
                repositoryItemSpinEdit1.MaxValue = t;
                focus();
            }
        }
        void capnhatlaikhohang()
        {
            
        }
        void focus()
        {
            gridView1.FocusedRowHandle = 0; // gán hàng ở chỉ số rowIndex làm hàng hiện tại
            gridView1.FocusedColumn = gridView1.Columns["SLban"]; // gán cột có tên là columnName làm cột hiện tại
            gridView1.Focus();
        }

        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            //main f1 = (main)Application.OpenForms["main"]; // Lấy form kia theo tên
            //f1.openform(typeof(KhoHang));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            luu();
        }
        void luu()
        {
            var bn = dbContext.ChungTus.FirstOrDefault(x => x.ChungTu1 == commons.ct2.ChungTu1);
            bn.DVX = Convert.ToInt32(comboBox1.SelectedValue);
            bn.NCC = Convert.ToInt32(comboBox1.SelectedValue);
            dbContext.SaveChanges();
        }

        private void PhieuXuat_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu người dùng nhấn nút đóng hoặc Alt+F4
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Hỏi người dùng có muốn lưu thay đổi không
                var result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                // Nếu người dùng nhấn Yes, lưu thay đổi và cho phép đóng form
                if (result == DialogResult.Yes)
                {
                    luu();
                }
                // Nếu người dùng nhấn Cancel, hủy lệnh đóng form
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    // Nếu người dùng nhấn No, không làm gì và cho phép đóng form

                    foreach (HHXK item1 in dbContext.HHXKs.Where(x => x.ChungTu == commons.ct2.ChungTu1))
                        dbContext.HHXKs.Remove(item1);

                    foreach (ChungTu item in dbContext.ChungTus.Where(x => x.ChungTu1 == commons.ct2.ChungTu1))
                        dbContext.ChungTus.Remove(item);
                    dbContext.SaveChanges();

                    //xóa cái ct củ
                    //commons.ct = null;
                    //commons.ct2 = null;

                }

            }
        }
    }
}