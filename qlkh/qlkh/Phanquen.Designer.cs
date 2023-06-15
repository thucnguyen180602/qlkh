namespace qlkh
{
    partial class Phanquen
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassWord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChungTus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassWord1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.usersBindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.gridControl1.Size = new System.Drawing.Size(895, 529);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(qlkh.User);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colUserName1,
            this.colPassWord1,
            this.colFullName1,
            this.colChucVu2,
            this.colMaKH1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.MinWidth = 25;
            this.colUserName.Name = "colUserName";
            this.colUserName.Width = 94;
            // 
            // colPassWord
            // 
            this.colPassWord.FieldName = "PassWord";
            this.colPassWord.MinWidth = 25;
            this.colPassWord.Name = "colPassWord";
            this.colPassWord.Width = 94;
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
            this.colFullName.MinWidth = 25;
            this.colFullName.Name = "colFullName";
            this.colFullName.Width = 94;
            // 
            // colChucVu
            // 
            this.colChucVu.FieldName = "ChucVu";
            this.colChucVu.MinWidth = 25;
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.Width = 94;
            // 
            // colMaKH
            // 
            this.colMaKH.FieldName = "MaKH";
            this.colMaKH.MinWidth = 25;
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.Width = 94;
            // 
            // colChucVu1
            // 
            this.colChucVu1.FieldName = "ChucVu1";
            this.colChucVu1.MinWidth = 25;
            this.colChucVu1.Name = "colChucVu1";
            this.colChucVu1.Width = 94;
            // 
            // colChungTus
            // 
            this.colChungTus.FieldName = "ChungTus";
            this.colChungTus.MinWidth = 25;
            this.colChungTus.Name = "colChungTus";
            this.colChungTus.Width = 94;
            // 
            // colKho
            // 
            this.colKho.FieldName = "Kho";
            this.colKho.MinWidth = 25;
            this.colKho.Name = "colKho";
            this.colKho.Width = 94;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataSource = typeof(qlkh.User);
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.MinWidth = 25;
            this.colId1.Name = "colId1";
            this.colId1.Visible = true;
            this.colId1.VisibleIndex = 0;
            this.colId1.Width = 94;
            // 
            // colUserName1
            // 
            this.colUserName1.FieldName = "UserName";
            this.colUserName1.MinWidth = 25;
            this.colUserName1.Name = "colUserName1";
            this.colUserName1.Visible = true;
            this.colUserName1.VisibleIndex = 1;
            this.colUserName1.Width = 94;
            // 
            // colPassWord1
            // 
            this.colPassWord1.FieldName = "PassWord";
            this.colPassWord1.MinWidth = 25;
            this.colPassWord1.Name = "colPassWord1";
            this.colPassWord1.Visible = true;
            this.colPassWord1.VisibleIndex = 2;
            this.colPassWord1.Width = 94;
            // 
            // colFullName1
            // 
            this.colFullName1.FieldName = "FullName";
            this.colFullName1.MinWidth = 25;
            this.colFullName1.Name = "colFullName1";
            this.colFullName1.Visible = true;
            this.colFullName1.VisibleIndex = 3;
            this.colFullName1.Width = 94;
            // 
            // colChucVu2
            // 
            this.colChucVu2.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colChucVu2.FieldName = "ChucVu";
            this.colChucVu2.MinWidth = 25;
            this.colChucVu2.Name = "colChucVu2";
            this.colChucVu2.Visible = true;
            this.colChucVu2.VisibleIndex = 4;
            this.colChucVu2.Width = 94;
            // 
            // colMaKH1
            // 
            this.colMaKH1.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colMaKH1.FieldName = "MaKH";
            this.colMaKH1.MinWidth = 25;
            this.colMaKH1.Name = "colMaKH1";
            this.colMaKH1.Visible = true;
            this.colMaKH1.VisibleIndex = 5;
            this.colMaKH1.Width = 94;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            // 
            // Phanquen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 529);
            this.Controls.Add(this.gridControl1);
            this.Name = "Phanquen";
            this.Text = "Phanquen";
            this.Load += new System.EventHandler(this.Phanquen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassWord;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu1;
        private DevExpress.XtraGrid.Columns.GridColumn colChungTus;
        private DevExpress.XtraGrid.Columns.GridColumn colKho;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName1;
        private DevExpress.XtraGrid.Columns.GridColumn colPassWord1;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName1;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
    }
}