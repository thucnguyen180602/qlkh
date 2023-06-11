namespace qlkh
{
    partial class KhoHang
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
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3.Panel1)).BeginInit();
            this.splitContainerControl3.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3.Panel2)).BeginInit();
            this.splitContainerControl3.Panel2.SuspendLayout();
            this.splitContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.SL,
            this.gridColumn2});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // Id
            // 
            this.Id.Caption = "id";
            this.Id.FieldName = "Id";
            this.Id.MinWidth = 25;
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 1;
            this.Id.Width = 94;
            // 
            // SL
            // 
            this.SL.Caption = "số lượng";
            this.SL.FieldName = "SL";
            this.SL.MinWidth = 25;
            this.SL.Name = "SL";
            this.SL.Visible = true;
            this.SL.VisibleIndex = 2;
            this.SL.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "MaHH";
            this.gridColumn2.FieldName = "MaHH";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 94;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "detail";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1059, 511);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Danh sách hàng hóa";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gridView1_MasterRowEmpty);
            this.gridView1.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gridView1_MasterRowExpanded_1);
            this.gridView1.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridView1_MasterRowGetChildList);
            this.gridView1.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridView1_MasterRowGetRelationName);
            this.gridView1.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gridView1_MasterRowGetRelationCount);
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên hàng hóa";
            this.gridColumn1.FieldName = "TenHH";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "id";
            this.gridColumn3.FieldName = "Id";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 94;
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
            this.splitContainerControl1.Panel1.Controls.Add(this.textBox1);
            this.splitContainerControl1.Panel1.Controls.Add(this.comboBox2);
            this.splitContainerControl1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl3);
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1059, 685);
            this.splitContainerControl1.SplitterPosition = 103;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(703, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 60);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(127, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(204, 36);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(373, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(287, 36);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm theo:";
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Horizontal = false;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Name = "splitContainerControl3";
            // 
            // splitContainerControl3.Panel1
            // 
            this.splitContainerControl3.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            // 
            // splitContainerControl3.Panel2
            // 
            this.splitContainerControl3.Panel2.Controls.Add(this.label2);
            this.splitContainerControl3.Panel2.Controls.Add(this.button1);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(1059, 570);
            this.splitContainerControl3.SplitterPosition = 511;
            this.splitContainerControl3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "xuất kho";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Location = new System.Drawing.Point(209, 255);
            this.splitContainerControl2.Name = "splitContainerControl2";
            // 
            // splitContainerControl2.Panel1
            // 
            this.splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // splitContainerControl2.Panel2
            // 
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(8, 8);
            this.splitContainerControl2.TabIndex = 1;
            // 
            // KhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 685);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "KhoHang";
            this.Text = "KhoHang";
            this.Load += new System.EventHandler(this.KhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3.Panel1)).EndInit();
            this.splitContainerControl3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3.Panel2)).EndInit();
            this.splitContainerControl3.Panel2.ResumeLayout(false);
            this.splitContainerControl3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn SL;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}