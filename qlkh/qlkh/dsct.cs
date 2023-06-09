using DevExpress.XtraEditors;
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                gridControl1.DataSource = q.ChungTus.Where(a => a.NhaCungCap != null).ToList();
            }
            else
            {
                gridControl1.DataSource = q.ChungTus.Where(a => a.DVX != null).ToList();
            }
        }
    }
}