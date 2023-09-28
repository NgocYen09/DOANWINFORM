using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUEPHONG
{
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        SANPHAM _sanpham;
        bool _them;
        int _idSanPham;
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            _sanpham = new SANPHAM();
            loadData();
            showHideControl(true);
            _enabled(false);
            txtIDSanPham.Enabled = false;
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
            txtIDSanPham.Enabled = !t;
            txtTenSanPham.Enabled = t;
            txtDonGia.Enabled = t;
        }
        void _reset()
        {
            txtIDSanPham.Text = "";
            txtTenSanPham.Text = "";
            txtDonGia.Text = "";
        }

        void loadData()
        {
           gcDanhSachSanPham.DataSource = _sanpham.getAll();
           gvDanhSachSanPham.OptionsBehavior.Editable = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            txtIDSanPham.Enabled = false;
            showHideControl(false);
            _enabled(true);
            _reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            _enabled(true);
            txtIDSanPham.Enabled = false;
            showHideControl(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtIDSanPham.Text.Length == 0 || txtTenSanPham.Text.Length == 0)
            {
                MessageBox.Show("Mời bạn chọ tầng để xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    for (int i = 0; i < gvDanhSachSanPham.RowCount; i++)
                    {
                        bool mutiselect = gvDanhSachSanPham.IsRowSelected(i);
                        if (mutiselect)
                        {
                            _sanpham.delete(int.Parse(gvDanhSachSanPham.GetRowCellValue(i, "IDSP").ToString()));
                        }

                    }               
            }
            loadData();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenSanPham.Text.Length == 0 || txtDonGia.Text.Length == 0)
            {
                MessageBox.Show("Mời bạn nhập thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (_them) {

                    if (MessageBox.Show("Bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tb_SanPham sanPham = new tb_SanPham();
                        sanPham.TENSP = txtTenSanPham.Text;
                        sanPham.DONGIA = double.Parse(txtDonGia.Text.ToString());
                        for (int i = 0; i < gvDanhSachSanPham.RowCount; i++)
                        {
                            if (gvDanhSachSanPham.GetRowCellValue(i, "TENSP").ToString() == txtTenSanPham.Text)
                            {
                                MessageBox.Show("Tên sản phẩm đã có vui lòng nhập tên khác", "Thông báo", MessageBoxButtons.OK);
                                txtTenSanPham.Text = "";
                                txtTenSanPham.Focus();
                                return;
                            }
                        }
                        _sanpham.add(sanPham);
                        txtIDSanPham.Enabled = false;
                        txtTenSanPham.Enabled = false;
                        txtDonGia.Enabled = false;
                        _reset();
                    }
                    else
                    {
                        txtIDSanPham.Focus();
                        return;
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn lưu những gì đã sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        _idSanPham = int.Parse(gvDanhSachSanPham.GetRowCellValue(gvDanhSachSanPham.FocusedRowHandle,"IDSP").ToString());
                        tb_SanPham sanPham = _sanpham.getItem(_idSanPham);
                        MessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        sanPham.TENSP = txtTenSanPham.Text;
                        sanPham.DONGIA = double.Parse (txtDonGia.Text.ToString());
                        _sanpham.update(sanPham);
                        txtTenSanPham.Enabled = false;
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
            txtIDSanPham.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDanhSachSanPham_Click(object sender, EventArgs e)
        {
            
        }

        private void gvDanhSachSanPham_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.Name == "Disabled" && bool.Parse(e.CellValue.ToString()) == true)
            //{
            //    Image img = Properties.Resources._4115230_cancel_close_delete_icon;
            //    e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
            //    e.Handled = true;
            //}
        }

        private void gcDanhSachSanPham_Click(object sender, EventArgs e)
        {
            if (gvDanhSachSanPham.RowCount > 0)
            {
                txtIDSanPham.Text = gvDanhSachSanPham.GetFocusedRowCellValue("IDSP").ToString();
                txtTenSanPham.Text = gvDanhSachSanPham.GetFocusedRowCellValue("TENSP").ToString();
                txtDonGia.Text = gvDanhSachSanPham.GetFocusedRowCellValue("DONGIA").ToString();
            }
        }
    }
}