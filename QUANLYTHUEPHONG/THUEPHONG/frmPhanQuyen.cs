using DataLayer;
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
   
    public partial class frmPhanQuyen : Form
    {
        tb_Users _user;
        bool isThoat = true;
        public frmPhanQuyen()
        {
            InitializeComponent();
        }
        public frmPhanQuyen(tb_Users nv)
        {
            InitializeComponent();
            this._user = nv;
            this.Text = "hello" + _user.FULLNAME;
        }
        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {

        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            isThoat =false;
            this.Close();
           
          
        }

        private void frmPhanQuyen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isThoat)
            {
                Application.Exit();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (isThoat)
            {
                Application.Exit();
            }
        }

        private void btnquanly_Click(object sender, EventArgs e)
        {
            
            string cv = _user.CHUCVU;
            if (cv != "Quản lý")
            {
                MessageBox.Show("Bạn không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                frmUser user = new frmUser();
                user.ShowDialog();
            }

        }

    }
}
