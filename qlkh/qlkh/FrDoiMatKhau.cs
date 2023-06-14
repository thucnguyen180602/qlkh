using DevExpress.XtraEditors;
using qlkh;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLK
{
    public partial class FrDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public string currentUser;
        public FrDoiMatKhau()
        {
            InitializeComponent();
            //currentUser = UserName;// người dùng hiện tại
        }
        

        private void FrDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string currentPassword = txtMatKhauCu.Text;
            string newPassword = txtMatKhauMoi.Text;
            string confirmPassword = txtGoLaiMK.Text;

            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                XtraMessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            using (QLKHEntities db = new QLKHEntities())
            {
                // Truy vấn người dùng hiện tại
                //User currentUser = db.User.FirstOrDefault(u => u.UserName == UserName);
                var currentUser = db.Users.FirstOrDefault(u => u.UserName == commons.user.UserName);// "thuc" thay thế bằng giá trị người dùng hiện tại

                if (currentUser == null)
                {
                    XtraMessageBox.Show("Không tìm thấy người dùng hiện tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //XtraMessageBox.Show(currentUser.PassWord+currentPassword, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); kiểm tra mk trong csdl và txtmk
               

                if (currentUser.PassWord.Trim() != currentPassword.Trim())
                {
                    XtraMessageBox.Show("Mật khẩu hiện tại không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật mật khẩu mới
                currentUser.PassWord = newPassword;

                try
                {
                    // Lưu thay đổi vào cơ sở dữ liệu
                    db.SaveChanges();
                    XtraMessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình đổi mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}