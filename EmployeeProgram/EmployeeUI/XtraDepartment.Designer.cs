namespace EmployeeUI
{
	partial class XtraDepartment
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraDepartment));
			layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			btnClose = new DevExpress.XtraEditors.SimpleButton();
			btnSave = new DevExpress.XtraEditors.SimpleButton();
			gC1 = new DevExpress.XtraGrid.GridControl();
			gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			colId = new DevExpress.XtraGrid.Columns.GridColumn();
			colName = new DevExpress.XtraGrid.Columns.GridColumn();
			colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
			colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
			repositoryBtnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
			repositoryBtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			colStatusChange = new DevExpress.XtraGrid.Columns.GridColumn();
			repositoryBtnStatusChange = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			txtDepartmentName = new DevExpress.XtraEditors.TextEdit();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
			layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gC1).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)repositoryBtnEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)repositoryBtnDelete).BeginInit();
			((System.ComponentModel.ISupportInitialize)repositoryBtnStatusChange).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtDepartmentName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)Root).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
			SuspendLayout();
			// 
			// layoutControl1
			// 
			layoutControl1.Controls.Add(btnClose);
			layoutControl1.Controls.Add(btnSave);
			layoutControl1.Controls.Add(gC1);
			layoutControl1.Controls.Add(txtDepartmentName);
			layoutControl1.Dock = DockStyle.Fill;
			layoutControl1.Location = new Point(0, 0);
			layoutControl1.Margin = new Padding(4, 3, 4, 3);
			layoutControl1.Name = "layoutControl1";
			layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(623, 0, 650, 400);
			layoutControl1.Root = Root;
			layoutControl1.Size = new Size(537, 552);
			layoutControl1.TabIndex = 0;
			layoutControl1.Text = "layoutControl1";
			// 
			// btnClose
			// 
			btnClose.Appearance.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnClose.Appearance.Options.UseFont = true;
			btnClose.ImageOptions.Image = (Image)resources.GetObject("btnClose.ImageOptions.Image");
			btnClose.Location = new Point(12, 78);
			btnClose.Margin = new Padding(4, 3, 4, 3);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(513, 36);
			btnClose.StyleController = layoutControl1;
			btnClose.TabIndex = 7;
			btnClose.Text = "Kapat";
			btnClose.Click += btnClose_Click;
			// 
			// btnSave
			// 
			btnSave.Appearance.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnSave.Appearance.Options.UseFont = true;
			btnSave.ImageOptions.Image = (Image)resources.GetObject("btnSave.ImageOptions.Image");
			btnSave.Location = new Point(12, 38);
			btnSave.Margin = new Padding(4, 3, 4, 3);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(513, 36);
			btnSave.StyleController = layoutControl1;
			btnSave.TabIndex = 6;
			btnSave.Text = "Kaydet";
			btnSave.Click += btnSave_Click;
			// 
			// gC1
			// 
			gC1.Location = new Point(12, 132);
			gC1.MainView = gridView1;
			gC1.Margin = new Padding(4, 3, 4, 3);
			gC1.Name = "gC1";
			gC1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryBtnDelete, repositoryBtnEdit, repositoryBtnStatusChange });
			gC1.Size = new Size(513, 408);
			gC1.TabIndex = 5;
			gC1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
			// 
			// gridView1
			// 
			gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colName, colStatus, colEdit, colDelete, colStatusChange });
			gridView1.DetailHeight = 404;
			gridView1.GridControl = gC1;
			gridView1.Name = "gridView1";
			gridView1.OptionsEditForm.PopupEditFormWidth = 933;
			// 
			// colId
			// 
			colId.Caption = "#";
			colId.FieldName = "Id";
			colId.Name = "colId";
			colId.Visible = true;
			colId.VisibleIndex = 0;
			// 
			// colName
			// 
			colName.Caption = "Bölüm Adı";
			colName.FieldName = "Name";
			colName.Name = "colName";
			colName.Visible = true;
			colName.VisibleIndex = 1;
			// 
			// colStatus
			// 
			colStatus.Caption = "Durum";
			colStatus.FieldName = "Status";
			colStatus.Name = "colStatus";
			colStatus.Visible = true;
			colStatus.VisibleIndex = 2;
			// 
			// colEdit
			// 
			colEdit.Caption = "Güncelle";
			colEdit.ColumnEdit = repositoryBtnEdit;
			colEdit.Name = "colEdit";
			colEdit.Visible = true;
			colEdit.VisibleIndex = 4;
			// 
			// repositoryBtnEdit
			// 
			repositoryBtnEdit.AutoHeight = false;
			repositoryBtnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo) });
			repositoryBtnEdit.Name = "repositoryBtnEdit";
			repositoryBtnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			repositoryBtnEdit.Click += repositoryBtnEdit_Click;
			// 
			// colDelete
			// 
			colDelete.Caption = "Sil";
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
			// colStatusChange
			// 
			colStatusChange.Caption = "Durumu Değiştir";
			colStatusChange.ColumnEdit = repositoryBtnStatusChange;
			colStatusChange.Name = "colStatusChange";
			colStatusChange.Visible = true;
			colStatusChange.VisibleIndex = 3;
			// 
			// repositoryBtnStatusChange
			// 
			repositoryBtnStatusChange.AutoHeight = false;
			repositoryBtnStatusChange.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK) });
			repositoryBtnStatusChange.Name = "repositoryBtnStatusChange";
			repositoryBtnStatusChange.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			repositoryBtnStatusChange.Click += repositoryBtnStatusChange_Click;
			// 
			// txtDepartmentName
			// 
			txtDepartmentName.Location = new Point(81, 12);
			txtDepartmentName.Margin = new Padding(4, 3, 4, 3);
			txtDepartmentName.Name = "txtDepartmentName";
			txtDepartmentName.Properties.Appearance.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			txtDepartmentName.Properties.Appearance.Options.UseFont = true;
			txtDepartmentName.Size = new Size(444, 22);
			txtDepartmentName.StyleController = layoutControl1;
			txtDepartmentName.TabIndex = 4;
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4 });
			Root.Name = "Root";
			Root.Size = new Size(537, 552);
			Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.AppearanceItemCaption.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
			layoutControlItem1.Control = txtDepartmentName;
			layoutControlItem1.Location = new Point(0, 0);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new Size(517, 26);
			layoutControlItem1.Text = "Bölüm Adı";
			layoutControlItem1.TextSize = new Size(57, 15);
			// 
			// emptySpaceItem1
			// 
			emptySpaceItem1.AllowHotTrack = false;
			emptySpaceItem1.Location = new Point(0, 106);
			emptySpaceItem1.Name = "emptySpaceItem1";
			emptySpaceItem1.Size = new Size(517, 14);
			emptySpaceItem1.TextSize = new Size(0, 0);
			// 
			// layoutControlItem2
			// 
			layoutControlItem2.Control = gC1;
			layoutControlItem2.Location = new Point(0, 120);
			layoutControlItem2.Name = "layoutControlItem2";
			layoutControlItem2.Size = new Size(517, 412);
			layoutControlItem2.TextSize = new Size(0, 0);
			layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			layoutControlItem3.Control = btnSave;
			layoutControlItem3.Location = new Point(0, 26);
			layoutControlItem3.Name = "layoutControlItem3";
			layoutControlItem3.Size = new Size(517, 40);
			layoutControlItem3.TextSize = new Size(0, 0);
			layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			layoutControlItem4.Control = btnClose;
			layoutControlItem4.Location = new Point(0, 66);
			layoutControlItem4.Name = "layoutControlItem4";
			layoutControlItem4.Size = new Size(517, 40);
			layoutControlItem4.TextSize = new Size(0, 0);
			layoutControlItem4.TextVisible = false;
			// 
			// XtraDepartment
			// 
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(537, 552);
			Controls.Add(layoutControl1);
			Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			IconOptions.LargeImage = (Image)resources.GetObject("XtraDepartment.IconOptions.LargeImage");
			Margin = new Padding(4, 3, 4, 3);
			Name = "XtraDepartment";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Bölümler";
			Load += XtraDepartment_Load;
			((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
			layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)gC1).EndInit();
			((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)repositoryBtnEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)repositoryBtnDelete).EndInit();
			((System.ComponentModel.ISupportInitialize)repositoryBtnStatusChange).EndInit();
			((System.ComponentModel.ISupportInitialize)txtDepartmentName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.SimpleButton btnSave;
		private DevExpress.XtraGrid.GridControl gC1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.TextEdit txtDepartmentName;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraEditors.SimpleButton btnClose;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colName;
		private DevExpress.XtraGrid.Columns.GridColumn colStatus;
		private DevExpress.XtraGrid.Columns.GridColumn colDelete;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnDelete;
		private DevExpress.XtraGrid.Columns.GridColumn colEdit;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnEdit;
		private DevExpress.XtraGrid.Columns.GridColumn colStatusChange;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnStatusChange;
	}
}