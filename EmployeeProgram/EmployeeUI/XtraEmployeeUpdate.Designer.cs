namespace EmployeeUI
{
	partial class XtraEmployeeUpdate
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraEmployeeUpdate));
			layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			txtIdentityNumber = new DevExpress.XtraEditors.TextEdit();
			barManager1 = new DevExpress.XtraBars.BarManager(components);
			bar2 = new DevExpress.XtraBars.Bar();
			btnUpdate = new DevExpress.XtraBars.BarButtonItem();
			btnbarclose = new DevExpress.XtraBars.BarButtonItem();
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			txtDepartment = new DevExpress.XtraEditors.ComboBoxEdit();
			txtStartingDate = new DevExpress.XtraEditors.DateEdit();
			txtSalary = new DevExpress.XtraEditors.TextEdit();
			txtBirthDate = new DevExpress.XtraEditors.DateEdit();
			txtLastName = new DevExpress.XtraEditors.TextEdit();
			txtName = new DevExpress.XtraEditors.TextEdit();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtIdentityNumber.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataLayoutControl1).BeginInit();
			dataLayoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)txtDepartment.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtStartingDate.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtStartingDate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtSalary.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtBirthDate.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtBirthDate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtLastName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)Root).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
			SuspendLayout();
			// 
			// layoutControlItem7
			// 
			layoutControlItem7.Control = txtIdentityNumber;
			layoutControlItem7.Location = new Point(0, 144);
			layoutControlItem7.Name = "layoutControlItem7";
			layoutControlItem7.Size = new Size(562, 24);
			layoutControlItem7.Text = "TC Kimlik Numarası";
			layoutControlItem7.TextSize = new Size(88, 13);
			// 
			// txtIdentityNumber
			// 
			txtIdentityNumber.EditValue = "";
			txtIdentityNumber.Location = new Point(112, 156);
			txtIdentityNumber.MenuManager = barManager1;
			txtIdentityNumber.Name = "txtIdentityNumber";
			txtIdentityNumber.Properties.MaxLength = 11;
			txtIdentityNumber.Size = new Size(458, 20);
			txtIdentityNumber.StyleController = dataLayoutControl1;
			txtIdentityNumber.TabIndex = 10;
			// 
			// barManager1
			// 
			barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2 });
			barManager1.DockControls.Add(barDockControlTop);
			barManager1.DockControls.Add(barDockControlBottom);
			barManager1.DockControls.Add(barDockControlLeft);
			barManager1.DockControls.Add(barDockControlRight);
			barManager1.Form = this;
			barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnbarclose, btnUpdate });
			barManager1.MainMenu = bar2;
			barManager1.MaxItemId = 2;
			// 
			// bar2
			// 
			bar2.BarName = "Main menu";
			bar2.DockCol = 0;
			bar2.DockRow = 0;
			bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnUpdate), new DevExpress.XtraBars.LinkPersistInfo(btnbarclose) });
			bar2.OptionsBar.MultiLine = true;
			bar2.OptionsBar.UseWholeRow = true;
			bar2.Text = "Main menu";
			// 
			// btnUpdate
			// 
			btnUpdate.Caption = "Personel Güncelle";
			btnUpdate.Id = 1;
			btnUpdate.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnUpdate.ImageOptions.SvgImage");
			btnUpdate.Name = "btnUpdate";
			btnUpdate.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			btnUpdate.ItemClick += btnUpdate_ItemClick;
			// 
			// btnbarclose
			// 
			btnbarclose.Caption = "Kapat";
			btnbarclose.Id = 0;
			btnbarclose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnbarclose.ImageOptions.SvgImage");
			btnbarclose.Name = "btnbarclose";
			btnbarclose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			btnbarclose.ItemClick += btnbarclose_ItemClick;
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Dock = DockStyle.Top;
			barDockControlTop.Location = new Point(0, 0);
			barDockControlTop.Manager = barManager1;
			barDockControlTop.Size = new Size(582, 24);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = DockStyle.Bottom;
			barDockControlBottom.Location = new Point(0, 226);
			barDockControlBottom.Manager = barManager1;
			barDockControlBottom.Size = new Size(582, 0);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = DockStyle.Left;
			barDockControlLeft.Location = new Point(0, 24);
			barDockControlLeft.Manager = barManager1;
			barDockControlLeft.Size = new Size(0, 202);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = DockStyle.Right;
			barDockControlRight.Location = new Point(582, 24);
			barDockControlRight.Manager = barManager1;
			barDockControlRight.Size = new Size(0, 202);
			// 
			// dataLayoutControl1
			// 
			dataLayoutControl1.Controls.Add(txtIdentityNumber);
			dataLayoutControl1.Controls.Add(txtDepartment);
			dataLayoutControl1.Controls.Add(txtStartingDate);
			dataLayoutControl1.Controls.Add(txtSalary);
			dataLayoutControl1.Controls.Add(txtBirthDate);
			dataLayoutControl1.Controls.Add(txtLastName);
			dataLayoutControl1.Controls.Add(txtName);
			dataLayoutControl1.Dock = DockStyle.Fill;
			dataLayoutControl1.Location = new Point(0, 24);
			dataLayoutControl1.Margin = new Padding(4, 3, 4, 3);
			dataLayoutControl1.Name = "dataLayoutControl1";
			dataLayoutControl1.Root = Root;
			dataLayoutControl1.Size = new Size(582, 202);
			dataLayoutControl1.TabIndex = 4;
			dataLayoutControl1.Text = "dataLayoutControl1";
			// 
			// txtDepartment
			// 
			txtDepartment.Location = new Point(112, 132);
			txtDepartment.MenuManager = barManager1;
			txtDepartment.Name = "txtDepartment";
			txtDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			txtDepartment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			txtDepartment.Size = new Size(458, 20);
			txtDepartment.StyleController = dataLayoutControl1;
			txtDepartment.TabIndex = 9;
			txtDepartment.SelectedIndexChanged += txtDepartment_SelectedIndexChanged;
			// 
			// txtStartingDate
			// 
			txtStartingDate.EditValue = null;
			txtStartingDate.Location = new Point(112, 108);
			txtStartingDate.MenuManager = barManager1;
			txtStartingDate.Name = "txtStartingDate";
			txtStartingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			txtStartingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			txtStartingDate.Size = new Size(458, 20);
			txtStartingDate.StyleController = dataLayoutControl1;
			txtStartingDate.TabIndex = 8;
			// 
			// txtSalary
			// 
			txtSalary.EditValue = "0";
			txtSalary.Location = new Point(112, 84);
			txtSalary.MenuManager = barManager1;
			txtSalary.Name = "txtSalary";
			txtSalary.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			txtSalary.Properties.MaskSettings.Set("mask", "n2");
			txtSalary.Properties.MaskSettings.Set("culture", "tr-TR");
			txtSalary.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.ZeroThenNull);
			txtSalary.Properties.MaskSettings.Set("valueType", typeof(decimal));
			txtSalary.Properties.UseMaskAsDisplayFormat = true;
			txtSalary.Size = new Size(458, 20);
			txtSalary.StyleController = dataLayoutControl1;
			txtSalary.TabIndex = 7;
			// 
			// txtBirthDate
			// 
			txtBirthDate.EditValue = null;
			txtBirthDate.Location = new Point(112, 60);
			txtBirthDate.MenuManager = barManager1;
			txtBirthDate.Name = "txtBirthDate";
			txtBirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			txtBirthDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			txtBirthDate.Size = new Size(458, 20);
			txtBirthDate.StyleController = dataLayoutControl1;
			txtBirthDate.TabIndex = 6;
			// 
			// txtLastName
			// 
			txtLastName.Location = new Point(112, 36);
			txtLastName.MenuManager = barManager1;
			txtLastName.Name = "txtLastName";
			txtLastName.Size = new Size(458, 20);
			txtLastName.StyleController = dataLayoutControl1;
			txtLastName.TabIndex = 5;
			// 
			// txtName
			// 
			txtName.Location = new Point(112, 12);
			txtName.MenuManager = barManager1;
			txtName.Name = "txtName";
			txtName.Size = new Size(458, 20);
			txtName.StyleController = dataLayoutControl1;
			txtName.TabIndex = 4;
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, layoutControlItem7 });
			Root.Name = "Root";
			Root.Size = new Size(582, 202);
			Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.Control = txtName;
			layoutControlItem1.Location = new Point(0, 0);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new Size(562, 24);
			layoutControlItem1.Text = "Personel Adı";
			layoutControlItem1.TextSize = new Size(88, 13);
			// 
			// emptySpaceItem1
			// 
			emptySpaceItem1.AllowHotTrack = false;
			emptySpaceItem1.Location = new Point(0, 168);
			emptySpaceItem1.Name = "emptySpaceItem1";
			emptySpaceItem1.Size = new Size(562, 14);
			emptySpaceItem1.TextSize = new Size(0, 0);
			// 
			// layoutControlItem2
			// 
			layoutControlItem2.Control = txtLastName;
			layoutControlItem2.Location = new Point(0, 24);
			layoutControlItem2.Name = "layoutControlItem2";
			layoutControlItem2.Size = new Size(562, 24);
			layoutControlItem2.Text = "Personel Soyadı";
			layoutControlItem2.TextSize = new Size(88, 13);
			// 
			// layoutControlItem3
			// 
			layoutControlItem3.Control = txtBirthDate;
			layoutControlItem3.Location = new Point(0, 48);
			layoutControlItem3.Name = "layoutControlItem3";
			layoutControlItem3.Size = new Size(562, 24);
			layoutControlItem3.Text = "Doğum Tarihi";
			layoutControlItem3.TextSize = new Size(88, 13);
			// 
			// layoutControlItem4
			// 
			layoutControlItem4.Control = txtSalary;
			layoutControlItem4.Location = new Point(0, 72);
			layoutControlItem4.Name = "layoutControlItem4";
			layoutControlItem4.Size = new Size(562, 24);
			layoutControlItem4.Text = "Maaş";
			layoutControlItem4.TextSize = new Size(88, 13);
			// 
			// layoutControlItem5
			// 
			layoutControlItem5.Control = txtStartingDate;
			layoutControlItem5.Location = new Point(0, 96);
			layoutControlItem5.Name = "layoutControlItem5";
			layoutControlItem5.Size = new Size(562, 24);
			layoutControlItem5.Text = "İşe Başlama Tarihi";
			layoutControlItem5.TextSize = new Size(88, 13);
			// 
			// layoutControlItem6
			// 
			layoutControlItem6.Control = txtDepartment;
			layoutControlItem6.Location = new Point(0, 120);
			layoutControlItem6.Name = "layoutControlItem6";
			layoutControlItem6.Size = new Size(562, 24);
			layoutControlItem6.Text = "Departman Adı";
			layoutControlItem6.TextSize = new Size(88, 13);
			// 
			// XtraEmployeeUpdate
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(582, 226);
			Controls.Add(dataLayoutControl1);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			IconOptions.LargeImage = (Image)resources.GetObject("XtraEmployeeUpdate.IconOptions.LargeImage");
			Name = "XtraEmployeeUpdate";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Personel Güncelleme Formu";
			Load += XtraEmployeeUpdate_Load;
			((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
			((System.ComponentModel.ISupportInitialize)txtIdentityNumber.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataLayoutControl1).EndInit();
			dataLayoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)txtDepartment.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtStartingDate.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtStartingDate.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtSalary.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtBirthDate.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtBirthDate.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtLastName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
		private DevExpress.XtraEditors.TextEdit txtIdentityNumber;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.BarButtonItem btnUpdate;
		private DevExpress.XtraBars.BarButtonItem btnbarclose;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraEditors.ComboBoxEdit txtDepartment;
		private DevExpress.XtraEditors.DateEdit txtStartingDate;
		private DevExpress.XtraEditors.TextEdit txtSalary;
		private DevExpress.XtraEditors.DateEdit txtBirthDate;
		private DevExpress.XtraEditors.TextEdit txtLastName;
		private DevExpress.XtraEditors.TextEdit txtName;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		public DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
	}
}