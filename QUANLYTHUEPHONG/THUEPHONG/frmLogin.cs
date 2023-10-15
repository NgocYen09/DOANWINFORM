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
using static THUEPHONG.frmUser;
using BusinessLayer;
using DataLayer;

namespace THUEPHONG
{

    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        LOGIN _login;
        tb_Users _user;

        public frmLogin()
        {
            InitializeComponent();


        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            _login = new LOGIN();

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            _user = new tb_Users();
            if (txtMatKhau.Text.Trim() == "" || txtTaiKhoan.Text.Trim() == "")
            {
            
                MessageBox.Show("Vui lòng điền tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _user = _login.getItem(txtTaiKhoan.Text.Trim());
            if (_user == null || _user.USERNAME != txtTaiKhoan.Text.Trim())
            {
                MessageBox.Show("Chưa có tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if(_user.USERNAME == txtTaiKhoan.Text.Trim() && _user.PASSWD == txtMatKhau.Text.Trim())
                {
                    UserSession.StartSession(_user);
                    frmPhanQuyen phanQuyen = new frmPhanQuyen();
                    phanQuyen.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
            }

        }
    }
}
    
