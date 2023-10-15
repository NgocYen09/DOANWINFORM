using BusinessLayer;
using DataLayer;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUEPHONG
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePass();
        }

        public void ChangePass()
        {
            string oldpass = txtOldPass.Text.Trim();
            string newpass = txtNewPass.Text.Trim();
            string renewpass = txtReNewPass.Text.Trim();
            tb_Users currentUser = UserSession.CurrentUser;

            if (currentUser == null)
            {
                MessageBox.Show("Lỗi: Không thể tìm thấy thông tin người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (currentUser.PASSWD != oldpass)
            {
                MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newpass != renewpass)
            {
                MessageBox.Show("Nhập lại mật khẩu mới không giống nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            currentUser.PASSWD = newpass;
            try
            {
                USER user = new USER();
                user.updatePassword(currentUser);
                MessageBox.Show("Mật khẩu đã được cập nhật thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
