﻿namespace DXApplication1.View._UC.Phiếu_nhập
{
    partial class frmCTHDB
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTHDB));
            this.lblMaHDN = new System.Windows.Forms.Label();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.lblTongTienNhap = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblHDB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grC = new DevExpress.XtraGrid.GridControl();
            this.grV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaHDN
            // 
            this.lblMaHDN.AutoSize = true;
            this.lblMaHDN.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHDN.Location = new System.Drawing.Point(114, 105);
            this.lblMaHDN.Name = "lblMaHDN";
            this.lblMaHDN.Size = new System.Drawing.Size(54, 14);
            this.lblMaHDN.TabIndex = 39;
            this.lblMaHDN.Text = "Mã HĐB: ";
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.Enabled = false;
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(214, 135);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(121, 21);
            this.cmbNhanVien.TabIndex = 47;
            // 
            // lblTongTienNhap
            // 
            this.lblTongTienNhap.AutoSize = true;
            this.lblTongTienNhap.Location = new System.Drawing.Point(211, 213);
            this.lblTongTienNhap.Name = "lblTongTienNhap";
            this.lblTongTienNhap.Size = new System.Drawing.Size(39, 13);
            this.lblTongTienNhap.TabIndex = 46;
            this.lblTongTienNhap.Text = "HDB01";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(114, 212);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(62, 14);
            this.lblTongTien.TabIndex = 45;
            this.lblTongTien.Text = "Tổng tiền : ";
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Enabled = false;
            this.dtpNgayBan.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBan.Location = new System.Drawing.Point(214, 171);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayBan.TabIndex = 44;
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.AutoSize = true;
            this.lblNgayBan.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBan.Location = new System.Drawing.Point(114, 176);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(56, 14);
            this.lblNgayBan.TabIndex = 43;
            this.lblNgayBan.Text = "Ngày bán :";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(114, 138);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(50, 14);
            this.lblTenNV.TabIndex = 42;
            this.lblTenNV.Text = "Tên NV :";
            // 
            // lblHDB
            // 
            this.lblHDB.AutoSize = true;
            this.lblHDB.Location = new System.Drawing.Point(211, 105);
            this.lblHDB.Name = "lblHDB";
            this.lblHDB.Size = new System.Drawing.Size(39, 13);
            this.lblHDB.TabIndex = 41;
            this.lblHDB.Text = "HDB01";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(169, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 31);
            this.label1.TabIndex = 40;
            this.label1.Text = "Chi Tiết Hóa Đơn Bán";
            // 
            // grC
            // 
            this.grC.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridLevelNode1.RelationName = "Level1";
            this.grC.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grC.Location = new System.Drawing.Point(0, 276);
            this.grC.MainView = this.grV;
            this.grC.Name = "grC";
            this.grC.Size = new System.Drawing.Size(563, 240);
            this.grC.TabIndex = 48;
            this.grC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grV});
            // 
            // grV
            // 
            this.grV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHH,
            this.TenHH,
            this.SoLuong,
            this.DonGiaBan,
            this.ThanhTien});
            this.grV.GridControl = this.grC;
            this.grV.Name = "grV";
            this.grV.OptionsView.ShowGroupPanel = false;
            this.grV.Click += new System.EventHandler(this.grV_Click);
            // 
            // MaHH
            // 
            this.MaHH.Caption = "Mã hàng hóa";
            this.MaHH.FieldName = "MaHH";
            this.MaHH.Name = "MaHH";
            this.MaHH.OptionsColumn.AllowEdit = false;
            this.MaHH.Visible = true;
            this.MaHH.VisibleIndex = 0;
            this.MaHH.Width = 96;
            // 
            // TenHH
            // 
            this.TenHH.Caption = "Tên hàng hóa";
            this.TenHH.FieldName = "TenHH";
            this.TenHH.Name = "TenHH";
            this.TenHH.OptionsColumn.AllowEdit = false;
            this.TenHH.Visible = true;
            this.TenHH.VisibleIndex = 1;
            this.TenHH.Width = 123;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 2;
            this.SoLuong.Width = 86;
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.Caption = "Đơn giá bán";
            this.DonGiaBan.FieldName = "DonGiaBan";
            this.DonGiaBan.Name = "DonGiaBan";
            this.DonGiaBan.OptionsColumn.AllowEdit = false;
            this.DonGiaBan.Visible = true;
            this.DonGiaBan.VisibleIndex = 3;
            this.DonGiaBan.Width = 113;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.OptionsColumn.AllowEdit = false;
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 4;
            this.ThanhTien.Width = 127;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(214, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 22);
            this.button2.TabIndex = 57;
            this.button2.Text = "In CT";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(147, 248);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 22);
            this.btnXoa.TabIndex = 56;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(12, 248);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(62, 22);
            this.btnThem.TabIndex = 54;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(80, 248);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 22);
            this.btnSua.TabIndex = 55;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmCTHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 516);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.grC);
            this.Controls.Add(this.lblMaHDN);
            this.Controls.Add(this.cmbNhanVien);
            this.Controls.Add(this.lblTongTienNhap);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.dtpNgayBan);
            this.Controls.Add(this.lblNgayBan);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblHDB);
            this.Controls.Add(this.label1);
            this.Name = "frmCTHDB";
            this.Text = "frmCTPN";
            ((System.ComponentModel.ISupportInitialize)(this.grC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaHDN;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.Label lblTongTienNhap;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblHDB;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl grC;
        private DevExpress.XtraGrid.Views.Grid.GridView grV;
        private DevExpress.XtraGrid.Columns.GridColumn MaHH;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private DevExpress.XtraGrid.Columns.GridColumn TenHH;
    }
}