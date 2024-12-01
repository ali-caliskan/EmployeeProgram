namespace EmployeeUI
{
	partial class XtraOffDayList
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraOffDayList));
			dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			gC1 = new DevExpress.XtraGrid.GridControl();
			gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			colId = new DevExpress.XtraGrid.Columns.GridColumn();
			colEmployeeId = new DevExpress.XtraGrid.Columns.GridColumn();
			colName = new DevExpress.XtraGrid.Columns.GridColumn();
			colDate = new DevExpress.XtraGrid.Columns.GridColumn();
			colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
			repositoryBtnUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
			repositoryBtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			barManager1 = new DevExpress.XtraBars.BarManager(components);
			bar2 = new DevExpress.XtraBars.Bar();
			btnClose = new DevExpress.XtraBars.BarButtonItem();
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)dataLayoutControl1).BeginInit();
			dataLayoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gC1).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)repositoryBtnUpdate).BeginInit();
			((System.ComponentModel.ISupportInitialize)repositoryBtnDelete).BeginInit();
			((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)Root).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
			SuspendLayout();
			// 
			// dataLayoutControl1
			// 
			dataLayoutControl1.Controls.Add(gC1);
			dataLayoutControl1.Dock = DockStyle.Fill;
			dataLayoutControl1.Location = new Point(0, 24);
			dataLayoutControl1.Name = "dataLayoutControl1";
			dataLayoutControl1.Root = Root;
			dataLayoutControl1.Size = new Size(920, 617);
			dataLayoutControl1.TabIndex = 0;
			dataLayoutControl1.Text = "dataLayoutControl1";
			// 
			// gC1
			// 
			gC1.Location = new Point(12, 12);
			gC1.MainView = gridView1;
			gC1.MenuManager = barManager1;
			gC1.Name = "gC1";
			gC1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryBtnUpdate, repositoryBtnDelete });
			gC1.Size = new Size(896, 593);
			gC1.TabIndex = 4;
			gC1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
			// 
			// gridView1
			// 
			gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colEmployeeId, colName, colDate, colEdit, colDelete });
			gridView1.GridControl = gC1;
			gridView1.Name = "gridView1";
			gridView1.OptionsView.ShowAutoFilterRow = true;
			// 
			// colId
			// 
			colId.Caption = "#";
			colId.FieldName = "Id";
			colId.Name = "colId";
			colId.Visible = true;
			colId.VisibleIndex = 0;
			// 
			// colEmployeeId
			// 
			colEmployeeId.Caption = "Personel Id";
			colEmployeeId.FieldName = "EmployeeId";
			colEmployeeId.Name = "colEmployeeId";
			colEmployeeId.Visible = true;
			colEmployeeId.VisibleIndex = 1;
			// 
			// colName
			// 
			colName.Caption = "Personel Adı";
			colName.FieldName = "Name";
			colName.Name = "colName";
			colName.Visible = true;
			colName.VisibleIndex = 2;
			// 
			// colDate
			// 
			colDate.Caption = "İzin Tarihi";
			colDate.FieldName = "Date";
			colDate.Name = "colDate";
			colDate.Visible = true;
			colDate.VisibleIndex = 3;
			// 
			// colEdit
			// 
			colEdit.Caption = "Güncelle";
			colEdit.ColumnEdit = repositoryBtnUpdate;
			colEdit.Name = "colEdit";
			colEdit.Visible = true;
			colEdit.VisibleIndex = 4;
			// 
			// repositoryBtnUpdate
			// 
			repositoryBtnUpdate.AutoHeight = false;
			repositoryBtnUpdate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo) });
			repositoryBtnUpdate.Name = "repositoryBtnUpdate";
			repositoryBtnUpdate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			repositoryBtnUpdate.Click += repositoryBtnUpdate_Click;
			// 
			// colDelete
			// 
			colDelete.Caption = "Temizle";
			colDelete.ColumnEdit = repositoryBtnDelete;
			colDelete.Name = "colDelete";
			colDelete.Visible = true;
			colDelete.VisibleIndex = 5;
			// 
			// repositoryBtnDelete
			// 
			repositoryBtnDelete.AutoHeight = false;
			repositoryBtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
			repositoryBtnDelete.Name = "repositoryBtnDelete";
			repositoryBtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			repositoryBtnDelete.Click += repositoryBtnDelete_Click;
			// 
			// barManager1
			// 
			barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2 });
			barManager1.DockControls.Add(barDockControlTop);
			barManager1.DockControls.Add(barDockControlBottom);
			barManager1.DockControls.Add(barDockControlLeft);
			barManager1.DockControls.Add(barDockControlRight);
			barManager1.Form = this;
			barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnClose });
			barManager1.MainMenu = bar2;
			barManager1.MaxItemId = 1;
			// 
			// bar2
			// 
			bar2.BarName = "Main menu";
			bar2.DockCol = 0;
			bar2.DockRow = 0;
			bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnClose) });
			bar2.OptionsBar.MultiLine = true;
			bar2.OptionsBar.UseWholeRow = true;
			bar2.Text = "Main menu";
			// 
			// btnClose
			// 
			btnClose.Caption = "Kapat";
			btnClose.Id = 0;
			btnClose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnClose.ImageOptions.SvgImage");
			btnClose.Name = "btnClose";
			btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			btnClose.ItemClick += btnClose_ItemClick;
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Dock = DockStyle.Top;
			barDockControlTop.Location = new Point(0, 0);
			barDockControlTop.Manager = barManager1;
			barDockControlTop.Size = new Size(920, 24);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = DockStyle.Bottom;
			barDockControlBottom.Location = new Point(0, 641);
			barDockControlBottom.Manager = barManager1;
			barDockControlBottom.Size = new Size(920, 0);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = DockStyle.Left;
			barDockControlLeft.Location = new Point(0, 24);
			barDockControlLeft.Manager = barManager1;
			barDockControlLeft.Size = new Size(0, 617);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = DockStyle.Right;
			barDockControlRight.Location = new Point(920, 24);
			barDockControlRight.Manager = barManager1;
			barDockControlRight.Size = new Size(0, 617);
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
			Root.Name = "Root";
			Root.Size = new Size(920, 617);
			Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.Control = gC1;
			layoutControlItem1.Location = new Point(0, 0);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new Size(900, 597);
			layoutControlItem1.TextSize = new Size(0, 0);
			layoutControlItem1.TextVisible = false;
			// 
			// XtraOffDayList
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(920, 641);
			Controls.Add(dataLayoutControl1);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Name = "XtraOffDayList";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Personel İzinli Listesi";
			Load += XtraOffDayList_Load;
			((System.ComponentModel.ISupportInitialize)dataLayoutControl1).EndInit();
			dataLayoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)gC1).EndInit();
			((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)repositoryBtnUpdate).EndInit();
			((System.ComponentModel.ISupportInitialize)repositoryBtnDelete).EndInit();
			((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem btnClose;
		private DevExpress.XtraGrid.GridControl gC1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colEmployeeId;
		private DevExpress.XtraGrid.Columns.GridColumn colName;
		private DevExpress.XtraGrid.Columns.GridColumn colDate;
		private DevExpress.XtraGrid.Columns.GridColumn colEdit;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnUpdate;
		private DevExpress.XtraGrid.Columns.GridColumn colDelete;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnDelete;
	}
}