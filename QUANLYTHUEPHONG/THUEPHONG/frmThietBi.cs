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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace THUEPHONG
{
    public partial class frmThietBi : DevExpress.XtraEditors.XtraForm
    {
        public frmThietBi()
        {
            InitializeComponent();
        }
        ThietBi _thietBi;
        bool _them;
        int _idthietbi;

        private void frmThietBi_Load(object sender, EventArgs e)
        {
            _thietBi = new ThietBi();
            loadData();
            showHideControl(true);
            _enabled(false);
            txtIDThietBi.Enabled = false;
        }

        void showHideControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;

        }
        void _enabled(bool t)
        {
            txtIDThietBi.Enabled = !t;
            txtTenThietBi.Enabled = t;
            txtDonGia.Enabled = t;
        }
        void _reset()
        {
            txtIDThietBi.Text = "";
            txtTenThietBi.Text = "";
            txtDonGia.Text = "";
        }
        void loadData()
        {
            gcDanhSachThietBi.DataSource = _thietBi.getAll();
            gvDanhSachThietBi.OptionsBehavior.Editable = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            txtIDThietBi.Enabled = false;
            showHideControl(false);
            _enabled(true);
            _reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            _enabled(true);
            txtIDThietBi.Enabled = false;
            showHideControl(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtIDThietBi.Text.Length == 0 || txtTenThietBi.Text.Length == 0)
            {
                MessageBox.Show("Mời bạn chọ tầng để xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    for (int i = 0; i < gvDanhSachThietBi.RowCount; i++)
                    {
                        bool mutiselect = gvDanhSachThietBi.IsRowSelected(i);
                        if (mutiselect)
                        {
                            _thietBi.delete(int.Parse(gvDanhSachThietBi.GetRowCellValue(i, "IDTB").ToString()));
                        }

                    }
            }
            loadData();

        }

        private void gcDanhSachThietBi_Click(object sender, EventArgs e)
        {
            if (gvDanhSachThietBi.RowCount > 0)
            {
                txtIDThietBi.Text = gvDanhSachThietBi.GetFocusedRowCellValue("IDTB").ToString();
                txtTenThietBi.Text = gvDanhSachThietBi.GetFocusedRowCellValue("TENTB").ToString();
                txtDonGia.Text = gvDanhSachThietBi.GetFocusedRowCellValue("DONGIA").ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenThietBi.Text.Length == 0 || txtDonGia.Text.Length == 0)
            {
                MessageBox.Show("Mời bạn nhập thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (_them)
                {

                    if (MessageBox.Show("Bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tb_ThietBi thietBi = new tb_ThietBi();
                        thietBi.TENTB = txtTenThietBi.Text;
                        thietBi.DONGIA = double.Parse(txtDonGia.Text.ToString());
                        for (int i = 0; i < gvDanhSachThietBi.RowCount; i++)
                        {
                            if (gvDanhSachThietBi.GetRowCellValue(i, "TENTB").ToString() == txtTenThietBi.Text)
                            {
                                MessageBox.Show("Tên thiết bị đã có vui lòng nhập tên khác", "Thông báo", MessageBoxButtons.OK);
                                txtTenThietBi.Text = "";
                                txtTenThietBi.Focus();
                                return;
                            }
                        }
                        _thietBi.add(thietBi);
                        txtIDThietBi.Enabled = false;
                        txtTenThietBi.Enabled = false;
                        txtDonGia.Enabled = false;
                        _reset();
                    }
                    else
                    {
                        txtIDThietBi.Focus();
                        return;
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn lưu những gì đã sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        _idthietbi = int.Parse(gvDanhSachThietBi.GetRowCellValue(gvDanhSachThietBi.FocusedRowHandle, "IDTB").ToString());
                        tb_ThietBi thietBi = _thietBi.getItem(_idthietbi);
                        MessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        thietBi.TENTB = txtTenThietBi.Text;
                        thietBi.DONGIA = double.Parse(txtDonGia.Text.ToString());
                        _thietBi.update(thietBi);
                        txtTenThietBi.Enabled = false;
                        txtDonGia.Enabled = false;
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

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);
            _enabled(false);
            txtIDThietBi.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

