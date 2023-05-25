using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraSplashScreen;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace qlkh
{
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        public login()
        {
            InitializeComponent();
        }
        QLKHEntities db = new QLKHEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (commons.handle!=null)
            {
                var user = db.Users.FirstOrDefault(u => u.UserName == textBox1.Text && u.PassWord == textBox2.Text);
                if (user!=null)
                {
                    commons.user=user;
                    main m = (main)Application.OpenForms["main"];
                    m.barStaticItem1.Caption= commons.user.FullName;
                    SplashScreenManager.CloseOverlayForm(commons.handle);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}