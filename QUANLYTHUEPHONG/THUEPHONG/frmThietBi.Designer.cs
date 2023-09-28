namespace THUEPHONG
{
    partial class frmThietBi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnBoQua = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.gcDanhSachThietBi = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachThietBi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDTB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENTB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grThongTin = new DevExpress.XtraEditors.GroupControl();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenThietBi = new System.Windows.Forms.TextBox();
            this.txtIDThietBi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongTin)).BeginInit();
            this.grThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnBoQua,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1061, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::THUEPHONG.Properties.Resources._134224_add_plus_new_icon1;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 44);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::THUEPHONG.Properties.Resources._8666681_edit_icon;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(38, 44);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::THUEPHONG.Properties.Resources._4115230_cancel_close_delete_icon;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(39, 44);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::THUEPHONG.Properties.Resources.z4734532830138_23b40aafe93b5c33341ceda66c6dab0d1;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(37, 44);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Image = global::THUEPHONG.Properties.Resources._3669229_skip_ic_next_icon;
            this.btnBoQua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(60, 44);
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::THUEPHONG.Properties.Resources.thoat1;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 44);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gcDanhSachThietBi
            // 
            this.gcDanhSachThietBi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDanhSachThietBi.Location = new System.Drawing.Point(0, 47);
            this.gcDanhSachThietBi.MainView = this.gvDanhSachThietBi;
            this.gcDanhSachThietBi.Name = "gcDanhSachThietBi";
            this.gcDanhSachThietBi.Size = new System.Drawing.Size(1061, 251);
            this.gcDanhSachThietBi.TabIndex = 3;
            this.gcDanhSachThietBi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachThietBi});
            this.gcDanhSachThietBi.Click += new System.EventHandler(this.gcDanhSachThietBi_Click);
            // 
            // gvDanhSachThietBi
            // 
            this.gvDanhSachThietBi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDTB,
            this.TENTB,
            this.DONGIA});
            this.gvDanhSachThietBi.GridControl = this.gcDanhSachThietBi;
            this.gvDanhSachThietBi.Name = "gvDanhSachThietBi";
            this.gvDanhSachThietBi.OptionsSelection.MultiSelect = true;
            this.gvDanhSachThietBi.OptionsView.ShowGroupPanel = false;
            // 
            // IDTB
            // 
            this.IDTB.Caption = "ID Thiết Bị";
            this.IDTB.FieldName = "IDTB";
            this.IDTB.MaxWidth = 35;
            this.IDTB.MinWidth = 25;
            this.IDTB.Name = "IDTB";
            this.IDTB.Visible = true;
            this.IDTB.VisibleIndex = 0;
            this.IDTB.Width = 30;
            // 
            // TENTB
            // 
            this.TENTB.Caption = "Tên Thiết Bị";
            this.TENTB.FieldName = "TENTB";
            this.TENTB.MaxWidth = 200;
            this.TENTB.MinWidth = 100;
            this.TENTB.Name = "TENTB";
            this.TENTB.Visible = true;
            this.TENTB.VisibleIndex = 1;
            this.TENTB.Width = 200;
            // 
            // DONGIA
            // 
            this.DONGIA.Caption = "Đơn Giá";
            this.DONGIA.FieldName = "DONGIA";
            this.DONGIA.MaxWidth = 400;
            this.DONGIA.MinWidth = 200;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 2;
            this.DONGIA.Width = 200;
            // 
            // grThongTin
            // 
            this.grThongTin.Controls.Add(this.txtDonGia);
            this.grThongTin.Controls.Add(this.txtTenThietBi);
            this.grThongTin.Controls.Add(this.txtIDThietBi);
            this.grThongTin.Controls.Add(this.label3);
            this.grThongTin.Controls.Add(this.label2);
            this.grThongTin.Controls.Add(this.label1);
            this.grThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grThongTin.Location = new System.Drawing.Point(0, 298);
            this.grThongTin.Name = "grThongTin";
            this.grThongTin.Size = new System.Drawing.Size(1061, 127);
            this.grThongTin.TabIndex = 2;
            this.grThongTin.Text = "Thông tin";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(612, 40);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(138, 23);
            this.txtDonGia.TabIndex = 2;
            // 
            // txtTenThietBi
            // 
            this.txtTenThietBi.Location = new System.Drawing.Point(144, 93);
            this.txtTenThietBi.Name = "txtTenThietBi";
            this.txtTenThietBi.Size = new System.Drawing.Size(161, 23);
            this.txtTenThietBi.TabIndex = 1;
            // 
            // txtIDThietBi
            // 
            this.txtIDThietBi.Location = new System.Drawing.Point(144, 39);
            this.txtIDThietBi.Name = "txtIDThietBi";
            this.txtIDThietBi.Size = new System.Drawing.Size(161, 23);
            this.txtIDThietBi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(525, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên thiết bị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Thiết bị";
            // 
            // frmThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 425);
            this.Controls.Add(this.grThongTin);
            this.Controls.Add(this.gcDanhSachThietBi);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmThietBi";
            this.Text = "frmThietBi";
            this.Load += new System.EventHandler(this.frmThietBi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongTin)).EndInit();
            this.grThongTin.ResumeLayout(false);
            this.grThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnBoQua;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraGrid.GridControl gcDanhSachThietBi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachThietBi;
        private DevExpress.XtraEditors.GroupControl grThongTin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenThietBi;
        private System.Windows.Forms.TextBox txtIDThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn IDTB;
        private DevExpress.XtraGrid.Columns.GridColumn TENTB;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
    }
}