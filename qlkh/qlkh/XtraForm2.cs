using DevExpress.XtraEditors;
using System;
using System.Collections;
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
    public partial class XtraForm2 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm2()
        {
            InitializeComponent();
        }
        QLKHEntities q = new QLKHEntities();
        private void XtraForm2_Load(object sender, EventArgs e)
        {
            var a = from s in q.HHTrongKhoes select new { a1=s.Id };
            gridControl1.DataSource= a.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            ArrayList Rows1 = new ArrayList();
            int I;
            for (I = 0; I < gridView1.SelectedRowsCount; I++)
            {
                if (gridView1.GetSelectedRows()[I] >= 0)
                {
                    Rows1.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[I]));
                }
            }
            for (I = 0; I < Rows1.Count; I++)
            {
                DataRow Row2 = (DataRow)Rows1[I];
                s = s + (I + 1).ToString() + ". " + Row2["a1"] + "\n";
            }
            MessageBox.Show(s);
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

        }
    }
}