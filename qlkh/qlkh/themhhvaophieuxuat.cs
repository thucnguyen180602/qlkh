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
    public partial class themhhvaophieuxuat : DevExpress.XtraEditors.XtraForm
    {
        public themhhvaophieuxuat()
        {
            InitializeComponent();
        }
        public themhhvaophieuxuat(string s1,ArrayList id1)
        {
            InitializeComponent();
            s = s1;
            id= id1;
        }
        string s = "";
        string s2 = "";

        ArrayList id = new ArrayList();


        QLKHEntities q = new QLKHEntities();    
        private void themhhvaophieuxuat_Load(object sender, EventArgs e)
        {
            label1.Text=s;
            foreach (var item in id)
            {
                s2 += item.ToString();
            }
            label2.Text=s2;
            int[] idsArray = id.ToArray(typeof(int)) as int[];
            var hh = from a in q.HHTrongKhoes where idsArray.Contains(a.Id) select a;
            gridControl1.DataSource = hh.ToList();

        }
    }
}