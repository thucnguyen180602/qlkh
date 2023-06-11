using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
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
    }
}