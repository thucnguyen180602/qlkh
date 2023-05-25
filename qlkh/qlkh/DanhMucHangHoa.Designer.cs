namespace qlkh
{
    partial class DanhMucHangHoa
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
            this.components = new System.ComponentModel.Container();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.hangHoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXuatXu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(804, 469);
            this.splitContainerControl1.SplitterPosition = 36;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.hangHoasBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3});
            this.gridControl1.Size = new System.Drawing.Size(804, 421);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // hangHoasBindingSource
            // 
            this.hangHoasBindingSource.DataSource = typeof(qlkh.HangHoa);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBarcode,
            this.colTenHH,
            this.colDonViTinh,
            this.colNhaCungCap,
            this.colXuatXu,
            this.colTenTat});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colBarcode
            // 
            this.colBarcode.Caption = "Mã hàng hóa";
            this.colBarcode.FieldName = "Barcode";
            this.colBarcode.MinWidth = 25;
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.Visible = true;
            this.colBarcode.VisibleIndex = 0;
            this.colBarcode.Width = 94;
            // 
            // colTenHH
            // 
            this.colTenHH.Caption = "Tên hàng hóa";
            this.colTenHH.FieldName = "TenHH";
            this.colTenHH.MinWidth = 25;
            this.colTenHH.Name = "colTenHH";
            this.colTenHH.Visible = true;
            this.colTenHH.VisibleIndex = 1;
            this.colTenHH.Width = 94;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.Caption = "Đơn vị tính";
            this.colDonViTinh.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colDonViTinh.FieldName = "DonViTinh";
            this.colDonViTinh.MinWidth = 25;
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.Visible = true;
            this.colDonViTinh.VisibleIndex = 2;
            this.colDonViTinh.Width = 94;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDVT", "Mã đơn vị tính"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDVT", "Tên đơn vị tính")});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // colNhaCungCap
            // 
            this.colNhaCungCap.Caption = "Nhà cung cấp";
            this.colNhaCungCap.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colNhaCungCap.FieldName = "NhaCungCap";
            this.colNhaCungCap.MinWidth = 25;
            this.colNhaCungCap.Name = "colNhaCungCap";
            this.colNhaCungCap.Visible = true;
            this.colNhaCungCap.VisibleIndex = 3;
            this.colNhaCungCap.Width = 94;
            // 
            // colXuatXu
            // 
            this.colXuatXu.Caption = "Xuất xứ";
            this.colXuatXu.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colXuatXu.FieldName = "XuatXu";
            this.colXuatXu.MinWidth = 25;
            this.colXuatXu.Name = "colXuatXu";
            this.colXuatXu.Visible = true;
            this.colXuatXu.VisibleIndex = 4;
            this.colXuatXu.Width = 94;
            // 
            // colTenTat
            // 
            this.colTenTat.Caption = "Tên Tắt";
            this.colTenTat.FieldName = "TenTat";
            this.colTenTat.MinWidth = 25;
            this.colTenTat.Name = "colTenTat";
            this.colTenTat.Visible = true;
            this.colTenTat.VisibleIndex = 5;
            this.colTenTat.Width = 94;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNCC", "Mã nhà cung cấp"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNCC", "Tên nhà cung cấp")});
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaQG", "Mã quốc gia"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenQG", "Tên quốc gia")});
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            // 
            // DanhMucHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 469);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "DanhMucHangHoa";
            this.Text = "DanhMucHangHoa";
            this.Load += new System.EventHandler(this.DanhMucHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource hangHoasBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHH;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn colXuatXu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTat;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
    }
}