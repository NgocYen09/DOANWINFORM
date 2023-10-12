using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace THUEPHONG
{
    public partial class frmThanhToan : Form
    {
        THANHTOAN _thanhtoan;
        public frmThanhToan()
        {
            InitializeComponent();

            ls.View = View.Details;
            ls.Columns.Add("Ngày", 100, HorizontalAlignment.Left);
            ls.Columns.Add("Tháng", 100, HorizontalAlignment.Left);
            ls.Columns.Add("Năm", 100, HorizontalAlignment.Left);
            ls.Columns.Add("Doanh thu", 100, HorizontalAlignment.Left);
        }

        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            _thanhtoan = new THANHTOAN();
        }

        private void dttg_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dttg.Value;
            decimal totalRevenue = _thanhtoan.GetTotalRevenueByDate(selectedDate);
            ls.Items.Clear();
            ListViewItem item = new ListViewItem(selectedDate.ToString("dd"));
            item.SubItems.Add(selectedDate.ToString("MM"));
            item.SubItems.Add(selectedDate.Year.ToString());
            item.SubItems.Add(totalRevenue.ToString("N0"));
            ls.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
