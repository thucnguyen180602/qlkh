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
            gridControl1.DataSource=q.ChungTus.ToList();
        }
    }
}