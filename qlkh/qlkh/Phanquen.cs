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

namespace qlkh
{
    public partial class Phanquen : DevExpress.XtraEditors.XtraForm
    {
        qlkh.QLKHEntities dbContext = new qlkh.QLKHEntities();

        public Phanquen()
        {

            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Users.Where(a => a.ChucVu1.TenCV != "admin").LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                usersBindingSource1.DataSource = dbContext.Users.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            dbContext.SaveChanges();
        }
        QLKHEntities q = new QLKHEntities();
        private void Phanquen_Load(object sender, EventArgs e)
        {
            repositoryItemLookUpEdit1.DataSource = dbContext.ChucVus.ToList();
            repositoryItemLookUpEdit1.ValueMember = "MaCV";
            repositoryItemLookUpEdit1.DisplayMember = "TenCV";
            colChucVu.ColumnEdit = repositoryItemLookUpEdit1;

            repositoryItemLookUpEdit2.DataSource = dbContext.Khoes.ToList();
            repositoryItemLookUpEdit2.ValueMember = "MaKH";
            repositoryItemLookUpEdit2.DisplayMember = "TenKH";
            colKho.ColumnEdit = repositoryItemLookUpEdit2;
        }

        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                delete((int)gridView1.GetFocusedRowCellValue("Id"));
                dbContext.SaveChanges();
            }
        }
        public void delete(int mabn)
        {
            try
            {
                var bn = q.Users.FirstOrDefault(x => x.Id == mabn);
                q.Users.Remove(bn);
                q.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}