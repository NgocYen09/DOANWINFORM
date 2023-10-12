using BusinessLayer;
using DataLayer;
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
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace THUEPHONG
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        public frmUser()
        {
            InitializeComponent();
        }

        USER _user;
        bool _them;
        int _id;
 
    private void frmUser_Load(object sender, EventArgs e)
        {
            _user = new USER();
            txtUid.Enabled = false;
            txtFullName.Enabled = false;
            txtUserName.Enabled = false;
            txtPasswd.Enabled = false;
            txtChucvu.Enabled = false;
            chkDisabled.Enabled = false;
           
            //txtUid.Enabled = true;
            //_enabled(false);
            loadData();
            showHideControl(true);
            _reset();
           


        }
        void showHideControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnThoat.Visible = t;
            btnXoa.Visible = t;
            btnLuu.Visible = !t;
            btnBoqua.Visible = !t;
        }
        void _enabled(bool t)
        { 
            txtUid.Enabled = t;
            txtFullName.Enabled = t;
            txtPasswd.Enabled = t;
            txtUserName.Enabled = t;
            chkDisabled.Enabled = t;
            txtChucvu.Enabled = t;
           
        }
        void _reset()
        {
            txtUid.Text = "";
            txtFullName.Text = "";
            txtPasswd.Text = "";
            txtUserName.Text = "";
            chkDisabled.Checked = false;
            txtChucvu.Text = "";
           
        }

        void loadData()
        {
            gcDanhSach.DataSource = _user.getAll();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
       
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtUid.Enabled = false;
            txtFullName.Enabled = true;
            txtUserName.Enabled = true;
            txtPasswd.Enabled = true;
           txtChucvu.Enabled=true;
            chkDisabled.Enabled = false;
            
            _them = true;
            showHideControl(false);
            _reset();
            //_them = true;
            //txtUid.Enabled = false;
            //showHideControl(false);
            //_enabled(true);
            //_reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtUid.Enabled = false;
            txtFullName.Enabled = true;
            txtUserName.Enabled = true;
            txtPasswd.Enabled = true;
            txtChucvu.Enabled = true;
            chkDisabled.Enabled = false;
            
            _them = false;
            showHideControl(false);
            _reset();
            //_them = false;
            //txtUid.Enabled = false;
            //showHideControl(false);
            //_enabled(true);
            //_reset();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có chắc chắn muốn xóa những mục đã chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < gvDanhSach.RowCount; i++)
                {
                    bool mutiselect = gvDanhSach.IsRowSelected(i);
                    if (mutiselect)
                    {
                        int id = int.Parse(gvDanhSach.GetRowCellValue(i, "UID").ToString());
                        _user.delete(id);
                       
                    }
                }

                loadData();
                _reset();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text.Length == 0 || txtPasswd.Text.Length == 0 || txtUserName.Text.Length == 0)
            {
                MessageBox.Show(" Nhập thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (_them)
                {
                    if (MessageBox.Show("Bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tb_Users users = new tb_Users();
                        users.FULLNAME = txtFullName.Text;
                        users.PASSWD = txtPasswd.Text;
                        users.USERNAME = txtUserName.Text;
                        users.CHUCVU = txtChucvu.Text;
                        for (int i = 0; i < gvDanhSach.RowCount; i++)
                        {
                            if (gvDanhSach.GetRowCellValue(i, "USERNAME").ToString() == txtUserName.Text)
                            {
                                MessageBox.Show("Tên đăng nhập đã có vui lòng nhập tên khác", "Thông báo", MessageBoxButtons.OK);
                                txtUserName.Text = "";
                                txtUserName.Focus();
                                return;
                            }
                        }
                        _user.add(users);

                        
                        txtFullName.Enabled = false;
                        txtPasswd.Enabled = false;
                        txtUserName.Enabled = false;
                        txtChucvu.Enabled = false;
                        chkDisabled.Enabled = false;
                        

                       
                        _reset();
                    }
                    else
                    {
                        txtUid.Focus();
                        return;
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn lưu những gì đã sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        _id = int.Parse(gvDanhSach.GetRowCellValue(gvDanhSach.FocusedRowHandle, "UID").ToString());
                        tb_Users users = _user.getItem(_id);
                        MessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        users.FULLNAME = txtFullName.Text;
                        users.PASSWD = txtPasswd.Text;
                        users.USERNAME = txtUserName.Text;
                        users.CHUCVU = txtChucvu.Text;

                        _user.update(users);

               
                        txtFullName.Enabled = false;
                        txtPasswd.Enabled = false;
                        txtUserName.Enabled = false;
                        txtChucvu.Enabled   =false;
                        chkDisabled.Enabled = false;
                        

                     
                        _reset();

                    }
                    else
                    {
                        return;
                    }
                }
                _them = false;
                loadData();
                showHideControl(true);
            }

        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);
            txtUid.Enabled = false;
            _enabled(false);
            _reset();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount>0)
            {
                txtUid.Text = gvDanhSach.GetFocusedRowCellValue("UID").ToString();
                txtFullName.Text = gvDanhSach.GetFocusedRowCellValue("FULLNAME").ToString();
                txtPasswd.Text = gvDanhSach.GetFocusedRowCellValue("PASSWD").ToString();
                txtUserName.Text = gvDanhSach.GetFocusedRowCellValue("USERNAME").ToString();
                txtChucvu.Text = gvDanhSach.GetFocusedRowCellValue("CHUCVU").ToString() ;
              
            }
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
  

      
    }
}