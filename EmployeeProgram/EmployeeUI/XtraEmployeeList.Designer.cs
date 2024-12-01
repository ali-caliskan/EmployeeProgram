namespace EmployeeUI
{
	partial class XtraEmployeeList
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
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraEmployeeList));
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
			dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			lbActiveList = new DevExpress.XtraEditors.LabelControl();
			labelControl4 = new DevExpress.XtraEditors.LabelControl();
			btnDismiss = new DevExpress.XtraEditors.LabelControl();
			btnOff = new DevExpress.XtraEditors.LabelControl();
			btnEmployee = new DevExpress.XtraEditors.LabelControl();
			gCDepartmentList = new DevExpress.XtraGrid.GridControl();
			gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			gridcolId = new DevExpress.XtraGrid.Columns.GridColumn();
			gridcolName = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColEmployeeCount = new DevExpress.XtraGrid.Columns.GridColumn();
			gCEmployeeList = new DevExpress.XtraGrid.GridControl();
			gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			colId = new DevExpress.XtraGrid.Columns.GridColumn();
			colName = new DevExpress.XtraGrid.Columns.GridColumn();
			colDepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
			colIdentityNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
			colSalary = new DevExpress.XtraGrid.Columns.GridColumn();
			colStartingDate = new DevExpress.XtraGrid.Columns.GridColumn();
			colOffDayEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
			colEndingDate = new DevExpress.XtraGrid.Columns.GridColumn();
			colReasonOfLeaving = new DevExpress.XtraGrid.Columns.GridColumn();
			colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
			repositoryBtnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			colEmployeeQuit = new DevExpress.XtraGrid.Columns.GridColumn();
			repositoryBtnEmployeeQuit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
			repositoryBtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			colReHired = new DevExpress.XtraGrid.Columns.GridColumn();
			repositoryBtnReHired = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)dataLayoutControl1).BeginInit();
			dataLayoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gCDepartmentList).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
			((System.ComponentModel.ISupportInitialize)gCEmployeeList).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)repositoryBtnEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)repositoryBtnEmployeeQuit).BeginInit();
			((System.ComponentModel.ISupportInitialize)repositoryBtnDelete).BeginInit();
			((System.ComponentModel.ISupportInitialize)repositoryBtnReHired).BeginInit();
			((System.ComponentModel.ISupportInitialize)Root).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
			SuspendLayout();
			// 
			// dataLayoutControl1
			// 
			dataLayoutControl1.Controls.Add(lbActiveList);
			dataLayoutControl1.Controls.Add(labelControl4);
			dataLayoutControl1.Controls.Add(btnDismiss);
			dataLayoutControl1.Controls.Add(btnOff);
			dataLayoutControl1.Controls.Add(btnEmployee);
			dataLayoutControl1.Controls.Add(gCDepartmentList);
			dataLayoutControl1.Controls.Add(gCEmployeeList);
			dataLayoutControl1.Dock = DockStyle.Fill;
			dataLayoutControl1.Location = new Point(0, 0);
			dataLayoutControl1.Name = "dataLayoutControl1";
			dataLayoutControl1.Root = Root;
			dataLayoutControl1.Size = new Size(1489, 662);
			dataLayoutControl1.TabIndex = 0;
			dataLayoutControl1.Text = "dataLayoutControl1";
			// 
			// lbActiveList
			// 
			lbActiveList.Appearance.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
			lbActiveList.Appearance.ForeColor = Color.Red;
			lbActiveList.Appearance.Options.UseFont = true;
			lbActiveList.Appearance.Options.UseForeColor = true;
			lbActiveList.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			lbActiveList.Location = new Point(12, 56);
			lbActiveList.Name = "lbActiveList";
			lbActiveList.Size = new Size(1465, 27);
			lbActiveList.StyleController = dataLayoutControl1;
			lbActiveList.TabIndex = 10;
			lbActiveList.Text = "labelControl1";
			// 
			// labelControl4
			// 
			labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			labelControl4.Location = new Point(1080, 12);
			labelControl4.Name = "labelControl4";
			labelControl4.Size = new Size(397, 13);
			labelControl4.StyleController = dataLayoutControl1;
			labelControl4.TabIndex = 9;
			// 
			// btnDismiss
			// 
			btnDismiss.Appearance.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnDismiss.Appearance.ForeColor = Color.DarkRed;
			btnDismiss.Appearance.Options.UseFont = true;
			btnDismiss.Appearance.Options.UseForeColor = true;
			btnDismiss.Appearance.Options.UseTextOptions = true;
			btnDismiss.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			btnDismiss.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			btnDismiss.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			btnDismiss.Location = new Point(763, 12);
			btnDismiss.Name = "btnDismiss";
			btnDismiss.Size = new Size(313, 40);
			btnDismiss.StyleController = dataLayoutControl1;
			btnDismiss.TabIndex = 8;
			btnDismiss.Text = "İşten Ayrılan";
			btnDismiss.Click += btnDismiss_Click;
			// 
			// btnOff
			// 
			btnOff.Appearance.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnOff.Appearance.ForeColor = Color.FromArgb(0, 0, 192);
			btnOff.Appearance.Options.UseFont = true;
			btnOff.Appearance.Options.UseForeColor = true;
			btnOff.Appearance.Options.UseTextOptions = true;
			btnOff.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			btnOff.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			btnOff.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			btnOff.Location = new Point(349, 12);
			btnOff.Name = "btnOff";
			btnOff.Size = new Size(410, 40);
			btnOff.StyleController = dataLayoutControl1;
			btnOff.TabIndex = 7;
			btnOff.Text = "İzinli";
			btnOff.Click += btnOff_Click;
			// 
			// btnEmployee
			// 
			btnEmployee.Appearance.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnEmployee.Appearance.ForeColor = Color.Green;
			btnEmployee.Appearance.Options.UseFont = true;
			btnEmployee.Appearance.Options.UseForeColor = true;
			btnEmployee.Appearance.Options.UseTextOptions = true;
			btnEmployee.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			btnEmployee.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			btnEmployee.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			btnEmployee.Location = new Point(12, 12);
			btnEmployee.Name = "btnEmployee";
			btnEmployee.Size = new Size(333, 40);
			btnEmployee.StyleController = dataLayoutControl1;
			btnEmployee.TabIndex = 6;
			btnEmployee.Text = "Çalışan";
			btnEmployee.Click += btnEmployee_Click;
			// 
			// gCDepartmentList
			// 
			gCDepartmentList.Location = new Point(1080, 87);
			gCDepartmentList.MainView = gridView2;
			gCDepartmentList.Name = "gCDepartmentList";
			gCDepartmentList.Size = new Size(397, 563);
			gCDepartmentList.TabIndex = 5;
			gCDepartmentList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
			// 
			// gridView2
			// 
			gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridcolId, gridcolName, gridColEmployeeCount });
			gridView2.GridControl = gCDepartmentList;
			gridView2.Name = "gridView2";
			// 
			// gridcolId
			// 
			gridcolId.Caption = "#";
			gridcolId.FieldName = "Id";
			gridcolId.Name = "gridcolId";
			// 
			// gridcolName
			// 
			gridcolName.Caption = "Departman Adı";
			gridcolName.FieldName = "Name";
			gridcolName.Name = "gridcolName";
			gridcolName.Visible = true;
			gridcolName.VisibleIndex = 0;
			// 
			// gridColEmployeeCount
			// 
			gridColEmployeeCount.Caption = "Personel Sayısı";
			gridColEmployeeCount.DisplayFormat.FormatString = "n0";
			gridColEmployeeCount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			gridColEmployeeCount.FieldName = "EmployeeCount";
			gridColEmployeeCount.Name = "gridColEmployeeCount";
			gridColEmployeeCount.Visible = true;
			gridColEmployeeCount.VisibleIndex = 1;
			// 
			// gCEmployeeList
			// 
			gCEmployeeList.Location = new Point(12, 87);
			gCEmployeeList.MainView = gridView1;
			gCEmployeeList.Name = "gCEmployeeList";
			gCEmployeeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryBtnEdit, repositoryBtnDelete, repositoryBtnEmployeeQuit, repositoryBtnReHired });
			gCEmployeeList.Size = new Size(1064, 563);
			gCEmployeeList.TabIndex = 4;
			gCEmployeeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
			// 
			// gridView1
			// 
			gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colName, colDepartmentName, colIdentityNumber, colBirthDate, colSalary, colStartingDate, colOffDayEndDate, colEndingDate, colReasonOfLeaving, colEdit, colEmployeeQuit, colDelete, colReHired });
			gridView1.GridControl = gCEmployeeList;
			gridView1.Name = "gridView1";
			gridView1.OptionsView.ShowAutoFilterRow = true;
			// 
			// colId
			// 
			colId.Caption = "#";
			colId.FieldName = "Id";
			colId.Name = "colId";
			// 
			// colName
			// 
			colName.Caption = "Personel Adı Soyadı";
			colName.FieldName = "Name";
			colName.Name = "colName";
			colName.Visible = true;
			colName.VisibleIndex = 0;
			// 
			// colDepartmentName
			// 
			colDepartmentName.Caption = "Departman Adı";
			colDepartmentName.FieldName = "DepartmentName";
			colDepartmentName.Name = "colDepartmentName";
			colDepartmentName.Visible = true;
			colDepartmentName.VisibleIndex = 1;
			// 
			// colIdentityNumber
			// 
			colIdentityNumber.Caption = "TC Kimlik Numarası";
			colIdentityNumber.FieldName = "IdentityNumber";
			colIdentityNumber.Name = "colIdentityNumber";
			colIdentityNumber.Visible = true;
			colIdentityNumber.VisibleIndex = 2;
			// 
			// colBirthDate
			// 
			colBirthDate.Caption = "Doğum Tarihi";
			colBirthDate.FieldName = "BirthDate";
			colBirthDate.Name = "colBirthDate";
			colBirthDate.Visible = true;
			colBirthDate.VisibleIndex = 3;
			// 
			// colSalary
			// 
			colSalary.Caption = "Maaş";
			colSalary.DisplayFormat.FormatString = "n2";
			colSalary.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			colSalary.FieldName = "Salary";
			colSalary.Name = "colSalary";
			colSalary.Visible = true;
			colSalary.VisibleIndex = 4;
			// 
			// colStartingDate
			// 
			colStartingDate.Caption = "İşe Başlama Tarihi";
			colStartingDate.FieldName = "StartingDate";
			colStartingDate.Name = "colStartingDate";
			colStartingDate.Visible = true;
			colStartingDate.VisibleIndex = 5;
			// 
			// colOffDayEndDate
			// 
			colOffDayEndDate.Caption = "İzin Bitiş Tarihi";
			colOffDayEndDate.FieldName = "OffDayEndDate";
			colOffDayEndDate.Name = "colOffDayEndDate";
			colOffDayEndDate.Visible = true;
			colOffDayEndDate.VisibleIndex = 6;
			// 
			// colEndingDate
			// 
			colEndingDate.Caption = "İşten Çıkış Tarihi";
			colEndingDate.FieldName = "EndingDate";
			colEndingDate.Name = "colEndingDate";
			colEndingDate.Visible = true;
			colEndingDate.VisibleIndex = 7;
			// 
			// colReasonOfLeaving
			// 
			colReasonOfLeaving.Caption = "Ayrılma Nedeni";
			colReasonOfLeaving.FieldName = "ReasonOfLeaving";
			colReasonOfLeaving.Name = "colReasonOfLeaving";
			colReasonOfLeaving.Visible = true;
			colReasonOfLeaving.VisibleIndex = 8;
			// 
			// colEdit
			// 
			colEdit.Caption = "Güncelle";
			colEdit.ColumnEdit = repositoryBtnEdit;
			colEdit.Name = "colEdit";
			colEdit.Visible = true;
			colEdit.VisibleIndex = 9;
			// 
			// repositoryBtnEdit
			// 
			repositoryBtnEdit.AutoHeight = false;
			repositoryBtnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo) });
			repositoryBtnEdit.Name = "repositoryBtnEdit";
			repositoryBtnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			repositoryBtnEdit.Click += repositoryBtnEdit_Click;
			// 
			// colEmployeeQuit
			// 
			colEmployeeQuit.Caption = "İşten Çıkart";
			colEmployeeQuit.ColumnEdit = repositoryBtnEmployeeQuit;
			colEmployeeQuit.Name = "colEmployeeQuit";
			colEmployeeQuit.Visible = true;
			colEmployeeQuit.VisibleIndex = 10;
			// 
			// repositoryBtnEmployeeQuit
			// 
			repositoryBtnEmployeeQuit.AutoHeight = false;
			editorButtonImageOptions1.Image = (Image)resources.GetObject("editorButtonImageOptions1.Image");
			repositoryBtnEmployeeQuit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
			repositoryBtnEmployeeQuit.Name = "repositoryBtnEmployeeQuit";
			repositoryBtnEmployeeQuit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			repositoryBtnEmployeeQuit.Click += repositoryBtnEmployeeQuit_Click;
			// 
			// colDelete
			// 
			colDelete.Caption = "Sil";
			colDelete.ColumnEdit = repositoryBtnDelete;
			colDelete.Name = "colDelete";
			colDelete.Visible = true;
			colDelete.VisibleIndex = 11;
			// 
			// repositoryBtnDelete
			// 
			repositoryBtnDelete.AutoHeight = false;
			repositoryBtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
			repositoryBtnDelete.Name = "repositoryBtnDelete";
			repositoryBtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			repositoryBtnDelete.Click += repositoryBtnDelete_Click;
			// 
			// colReHired
			// 
			colReHired.Caption = "İşe Tekrar Al";
			colReHired.ColumnEdit = repositoryBtnReHired;
			colReHired.Name = "colReHired";
			colReHired.Visible = true;
			colReHired.VisibleIndex = 12;
			// 
			// repositoryBtnReHired
			// 
			repositoryBtnReHired.AutoHeight = false;
			repositoryBtnReHired.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			repositoryBtnReHired.Name = "repositoryBtnReHired";
			repositoryBtnReHired.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			repositoryBtnReHired.Click += repositoryBtnReHired_Click;
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, layoutControlItem7 });
			Root.Name = "Root";
			Root.Size = new Size(1489, 662);
			Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.Control = gCEmployeeList;
			layoutControlItem1.Location = new Point(0, 75);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new Size(1068, 567);
			layoutControlItem1.TextSize = new Size(0, 0);
			layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			layoutControlItem2.Control = gCDepartmentList;
			layoutControlItem2.Location = new Point(1068, 75);
			layoutControlItem2.Name = "layoutControlItem2";
			layoutControlItem2.Size = new Size(401, 567);
			layoutControlItem2.TextSize = new Size(0, 0);
			layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			layoutControlItem3.Control = btnEmployee;
			layoutControlItem3.Location = new Point(0, 0);
			layoutControlItem3.Name = "layoutControlItem3";
			layoutControlItem3.Size = new Size(337, 44);
			layoutControlItem3.TextSize = new Size(0, 0);
			layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			layoutControlItem4.Control = btnOff;
			layoutControlItem4.Location = new Point(337, 0);
			layoutControlItem4.Name = "layoutControlItem4";
			layoutControlItem4.Size = new Size(414, 44);
			layoutControlItem4.TextSize = new Size(0, 0);
			layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			layoutControlItem5.Control = btnDismiss;
			layoutControlItem5.Location = new Point(751, 0);
			layoutControlItem5.Name = "layoutControlItem5";
			layoutControlItem5.Size = new Size(317, 44);
			layoutControlItem5.TextSize = new Size(0, 0);
			layoutControlItem5.TextVisible = false;
			// 
			// layoutControlItem6
			// 
			layoutControlItem6.Control = labelControl4;
			layoutControlItem6.Location = new Point(1068, 0);
			layoutControlItem6.Name = "layoutControlItem6";
			layoutControlItem6.Size = new Size(401, 44);
			layoutControlItem6.TextSize = new Size(0, 0);
			layoutControlItem6.TextVisible = false;
			// 
			// layoutControlItem7
			// 
			layoutControlItem7.Control = lbActiveList;
			layoutControlItem7.Location = new Point(0, 44);
			layoutControlItem7.Name = "layoutControlItem7";
			layoutControlItem7.Size = new Size(1469, 31);
			layoutControlItem7.TextSize = new Size(0, 0);
			layoutControlItem7.TextVisible = false;
			// 
			// XtraEmployeeList
			// 
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1489, 662);
			Controls.Add(dataLayoutControl1);
			Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4, 3, 4, 3);
			Name = "XtraEmployeeList";
			Text = "Personel Listesi";
			Load += XtraEmployeeList_Load;
			((System.ComponentModel.ISupportInitialize)dataLayoutControl1).EndInit();
			dataLayoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)gCDepartmentList).EndInit();
			((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
			((System.ComponentModel.ISupportInitialize)gCEmployeeList).EndInit();
			((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)repositoryBtnEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)repositoryBtnEmployeeQuit).EndInit();
			((System.ComponentModel.ISupportInitialize)repositoryBtnDelete).EndInit();
			((System.ComponentModel.ISupportInitialize)repositoryBtnReHired).EndInit();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraGrid.GridControl gCDepartmentList;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraGrid.GridControl gCEmployeeList;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraGrid.Columns.GridColumn gridcolId;
		private DevExpress.XtraGrid.Columns.GridColumn gridcolName;
		private DevExpress.XtraGrid.Columns.GridColumn gridColEmployeeCount;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnEdit;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnDelete;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnEmployeeQuit;
		private DevExpress.XtraEditors.LabelControl btnDismiss;
		private DevExpress.XtraEditors.LabelControl btnOff;
		private DevExpress.XtraEditors.LabelControl btnEmployee;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraEditors.LabelControl lbActiveList;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnReHired;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colName;
		private DevExpress.XtraGrid.Columns.GridColumn colDepartmentName;
		private DevExpress.XtraGrid.Columns.GridColumn colIdentityNumber;
		private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
		private DevExpress.XtraGrid.Columns.GridColumn colSalary;
		private DevExpress.XtraGrid.Columns.GridColumn colStartingDate;
		private DevExpress.XtraGrid.Columns.GridColumn colOffDayEndDate;
		private DevExpress.XtraGrid.Columns.GridColumn colEndingDate;
		private DevExpress.XtraGrid.Columns.GridColumn colReasonOfLeaving;
		private DevExpress.XtraGrid.Columns.GridColumn colEdit;
		private DevExpress.XtraGrid.Columns.GridColumn colEmployeeQuit;
		private DevExpress.XtraGrid.Columns.GridColumn colDelete;
		private DevExpress.XtraGrid.Columns.GridColumn colReHired;
	}
}