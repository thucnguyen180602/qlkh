﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;

namespace qlkh
{
    public partial class PhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        qlkh.QLKHEntities dbContext = new qlkh.QLKHEntities();

        public PhieuNhap()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.HHTrongKhoes.Where(a => a.ChungTu==commons.ct.ChungTu1).LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                hHTrongKhoesBindingSource.DataSource = dbContext.HHTrongKhoes.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        QLKHEntities q = new QLKHEntities();
        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            var ncc = from a in q.NhaCungCaps select a;
            comboBox1.DataSource= ncc.ToList();
            comboBox1.ValueMember= "MaNCC";
            comboBox1.DisplayMember= "TenNCC";
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

            var hh = from a in q.HangHoas select a;
            repositoryItemLookUpEdit1.DataSource = hh.ToList();
            repositoryItemLookUpEdit1.ValueMember = "Barcode";
            repositoryItemLookUpEdit1.DisplayMember = "TenHH";
            //repositoryItemLookUpEdit1.NullText = "Chọn hàng hóa";

            gridControl1.EmbeddedNavigator.ButtonClick += EmbeddedNavigator_ButtonClick;

            //TỰ ĐỘNG THÊM THÀNH TIỀN
            gridView1.InitNewRow += (s, ee) => {
                GridView view = s as GridView;
                view.SetRowCellValue(ee.RowHandle, view.Columns["GiaMua"], 10);
                view.SetRowCellValue(ee.RowHandle, view.Columns["SL"], 1);
                view.SetRowCellValue(ee.RowHandle, view.Columns["MaKH"], commons.user.MaKH);
                view.SetRowCellValue(ee.RowHandle, view.Columns["ChungTu"], commons.ct.ChungTu1);
            };

            dateTimePicker1.Text = DateTime.Now.ToString();
            commons.ct.Created_Date = Convert.ToDateTime(dateTimePicker1.Text);
            commons.ct.GhiChu = textBox1.Text;

            //cột thành tiền

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

            gridView1.Columns["Total"].VisibleIndex = 3;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var t = int.Parse(comboBox1.SelectedValue.ToString());
            //var hh = from a in q.HangHoas where a.NhaCungCap == t select a;
            //if (hh != null)
            //{
            //    repositoryItemLookUpEdit1.DataSource = hh.ToList();
            //    repositoryItemLookUpEdit1.ValueMember = "Barcode";
            //    repositoryItemLookUpEdit1.DisplayMember = "TenHH";
            //    repositoryItemLookUpEdit1.NullText = "Chọn hàng hóa";
            //}
        }

        // Specify data for the Total column.
        private void GridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "Total" && e.IsGetData) e.Value =
              getTotalValue(view, e.ListSourceRowIndex);
        }

        // Return the total amount for a specific row.
        decimal getTotalValue(GridView view, int listSourceRowIndex)
        {
            decimal unitPrice = Convert.ToDecimal(view.GetListSourceRowCellValue(listSourceRowIndex, "GiaMua"));
            decimal quantity = Convert.ToDecimal(view.GetListSourceRowCellValue(listSourceRowIndex, "SL"));
            return unitPrice * quantity;
        }

        decimal TT()
        {
            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                total += (decimal)gridView1.GetRowCellValue(i, "Total");
            }
            return total;
        }
        BindingList<HHTrongKho> products;
        void load_bdl()
        {

            var dt = q.HHTrongKhoes.ToList();
            
            // Tạo một BindingList chứa các sản phẩm từ cơ sở dữ liệu
            products = new BindingList<HHTrongKho>(dt);
            gridControl1.DataSource= products;
            // Đăng ký sự kiện ListChanged để theo dõi các thay đổi trong BindingList
            //products.ListChanged += Products_ListChanged;
        }

        private void Products_ListChanged(object sender, ListChangedEventArgs e)
        {

        }

        private void EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
            {
                //gridView1.FocusedRowHandle = gridView1.RowCount + 1;//cho phép chỉnh sửa nhiều dòng cùng 1 lúc
                //this.hHTrongKhoTableAdapter.Update(this.qLKHDataSet.HHTrongKho);
                gridControl1.RefreshDataSource();
            }
        }

        SqlDataAdapter da;
        void load_data()
        {
            string strcnn = @"Data Source=LAPTOP-LV12EFC6\SQLEXPRESS;Initial Catalog=QLKH;Integrated Security=True";
            var connection = new SqlConnection(strcnn);
            connection.Open();
            //database db1 = new database(@"LAPTOP-LV12EFC6\\SQLEXPRESS", "QLKH");

            da = new SqlDataAdapter("select * from HHTrongKho ", connection);
            //this.qLKHDataSet.HHTrongKho.Clear();
            //da.Fill(this.qLKHDataSet.HHTrongKho);
            gridControl1.RefreshDataSource();
            connection.Close();
        }


        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            dbContext.SaveChanges();
            label1.Text = string.Format(new CultureInfo("vi-VN"), " {0:#,##0.00}", Convert.ToDecimal(TT()).ToString());
        }
        void taochungtu()
        {
            Guid guid1 = Guid.NewGuid();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //int sl = 0;
            //double dg = 0;
            //if (gridView1.GetFocusedRowCellValue(gridColumn2)!=null|| gridView1.GetFocusedRowCellValue(gridColumn3)!=null)
            //{
            //    if (e.Column == gridColumn2 || e.Column == gridColumn3)
            //    {
            //        sl = Convert.ToInt32(gridView1.GetFocusedRowCellValue(gridColumn2));
            //        dg = (double)gridView1.GetFocusedRowCellValue(gridColumn3);
            //        gridView1.SetFocusedRowCellValue(gridColumn4, sl * dg);
            //    }
            //}


        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa?", "conform", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //GridView view = sender  as GridView;
                //view.DeleteRow(view.FocusedRowHandle);
                gridView1.DeleteSelectedRows();
                //gridView1.OptionsNavigation.AutoFocusNewRow= true;
                dbContext.SaveChanges();
            }
        }

        private void PhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
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

                    foreach (HHTrongKho item1 in dbContext.HHTrongKhoes.Where(x => x.ChungTu == commons.ct.ChungTu1))
                        dbContext.HHTrongKhoes.Remove(item1);

                    foreach (ChungTu item in dbContext.ChungTus.Where(x => x.ChungTu1 == commons.ct.ChungTu1))
                        dbContext.ChungTus.Remove(item);
                    dbContext.SaveChanges();
                }

            }
        }
        void luu()
        {
            var bn = dbContext.ChungTus.FirstOrDefault(x => x.ChungTu1 == commons.ct.ChungTu1);
            bn.GhiChu = textBox1.Text;
            bn.NCC =Convert.ToInt32(comboBox1.SelectedValue);
            dbContext.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            luu();
        }
    }
}