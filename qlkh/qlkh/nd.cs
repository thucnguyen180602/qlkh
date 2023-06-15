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
    public partial class nd : DevExpress.XtraEditors.XtraForm
    {
        public nd()
        {
            InitializeComponent();
        }

        private void nd_Load(object sender, EventArgs e)
        {
            textBox1.Text = commons.user.FullName;
            textBox2.Text = commons.user.UserName;
            textBox3.Text = commons.user.ChucVu1.TenCV;
            textBox4.Text = commons.user.Kho.TenKH;
        }
    }
}