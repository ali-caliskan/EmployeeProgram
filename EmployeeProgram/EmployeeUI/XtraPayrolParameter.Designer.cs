namespace EmployeeUI
{
	partial class XtraPayrolParameter
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraPayrolParameter));
			layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			txtParameter2 = new DevExpress.XtraEditors.TextEdit();
			barManager1 = new DevExpress.XtraBars.BarManager(components);
			bar2 = new DevExpress.XtraBars.Bar();
			btnUpdate = new DevExpress.XtraBars.BarButtonItem();
			btnClose = new DevExpress.XtraBars.BarButtonItem();
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			txtParameter1 = new DevExpress.XtraEditors.TextEdit();
			txtGrossMinimumWage = new DevExpress.XtraEditors.TextEdit();
			txtNetMinimumWage = new DevExpress.XtraEditors.TextEdit();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
			layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)txtParameter2.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtParameter1.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtGrossMinimumWage.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtNetMinimumWage.Properties).BeginInit();
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
			layoutControl1.Controls.Add(txtParameter2);
			layoutControl1.Controls.Add(txtParameter1);
			layoutControl1.Controls.Add(txtGrossMinimumWage);
			layoutControl1.Controls.Add(txtNetMinimumWage);
			layoutControl1.Dock = DockStyle.Fill;
			layoutControl1.Location = new Point(0, 24);
			layoutControl1.Name = "layoutControl1";
			layoutControl1.Root = Root;
			layoutControl1.Size = new Size(432, 164);
			layoutControl1.TabIndex = 0;
			layoutControl1.Text = "layoutControl1";
			// 
			// txtParameter2
			// 
			txtParameter2.Location = new Point(103, 84);
			txtParameter2.MenuManager = barManager1;
			txtParameter2.Name = "txtParameter2";
			txtParameter2.Size = new Size(317, 20);
			txtParameter2.StyleController = layoutControl1;
			txtParameter2.TabIndex = 4;
			// 
			// barManager1
			// 
			barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2 });
			barManager1.DockControls.Add(barDockControlTop);
			barManager1.DockControls.Add(barDockControlBottom);
			barManager1.DockControls.Add(barDockControlLeft);
			barManager1.DockControls.Add(barDockControlRight);
			barManager1.Form = this;
			barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnUpdate, btnClose });
			barManager1.MainMenu = bar2;
			barManager1.MaxItemId = 2;
			// 
			// bar2
			// 
			bar2.BarName = "Main menu";
			bar2.DockCol = 0;
			bar2.DockRow = 0;
			bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnUpdate), new DevExpress.XtraBars.LinkPersistInfo(btnClose) });
			bar2.OptionsBar.MultiLine = true;
			bar2.OptionsBar.UseWholeRow = true;
			bar2.Text = "Main menu";
			// 
			// btnUpdate
			// 
			btnUpdate.Caption = "Update";
			btnUpdate.Id = 0;
			btnUpdate.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnUpdate.ImageOptions.SvgImage");
			btnUpdate.Name = "btnUpdate";
			btnUpdate.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			btnUpdate.ItemClick += btnUpdate_ItemClick;
			// 
			// btnClose
			// 
			btnClose.Caption = "Kapat";
			btnClose.Id = 1;
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
			barDockControlTop.Size = new Size(432, 24);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = DockStyle.Bottom;
			barDockControlBottom.Location = new Point(0, 188);
			barDockControlBottom.Manager = barManager1;
			barDockControlBottom.Size = new Size(432, 0);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = DockStyle.Left;
			barDockControlLeft.Location = new Point(0, 24);
			barDockControlLeft.Manager = barManager1;
			barDockControlLeft.Size = new Size(0, 164);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = DockStyle.Right;
			barDockControlRight.Location = new Point(432, 24);
			barDockControlRight.Manager = barManager1;
			barDockControlRight.Size = new Size(0, 164);
			// 
			// txtParameter1
			// 
			txtParameter1.Location = new Point(103, 60);
			txtParameter1.MenuManager = barManager1;
			txtParameter1.Name = "txtParameter1";
			txtParameter1.Size = new Size(317, 20);
			txtParameter1.StyleController = layoutControl1;
			txtParameter1.TabIndex = 3;
			// 
			// txtGrossMinimumWage
			// 
			txtGrossMinimumWage.Location = new Point(103, 36);
			txtGrossMinimumWage.MenuManager = barManager1;
			txtGrossMinimumWage.Name = "txtGrossMinimumWage";
			txtGrossMinimumWage.Size = new Size(317, 20);
			txtGrossMinimumWage.StyleController = layoutControl1;
			txtGrossMinimumWage.TabIndex = 2;
			// 
			// txtNetMinimumWage
			// 
			txtNetMinimumWage.Location = new Point(103, 12);
			txtNetMinimumWage.MenuManager = barManager1;
			txtNetMinimumWage.Name = "txtNetMinimumWage";
			txtNetMinimumWage.Size = new Size(317, 20);
			txtNetMinimumWage.StyleController = layoutControl1;
			txtNetMinimumWage.TabIndex = 0;
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4 });
			Root.Name = "Root";
			Root.Size = new Size(432, 164);
			Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.Control = txtNetMinimumWage;
			layoutControlItem1.Location = new Point(0, 0);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new Size(412, 24);
			layoutControlItem1.Text = "Net Asgari Ücret";
			layoutControlItem1.TextSize = new Size(79, 13);
			// 
			// emptySpaceItem1
			// 
			emptySpaceItem1.AllowHotTrack = false;
			emptySpaceItem1.Location = new Point(0, 96);
			emptySpaceItem1.Name = "emptySpaceItem1";
			emptySpaceItem1.Size = new Size(412, 48);
			emptySpaceItem1.TextSize = new Size(0, 0);
			// 
			// layoutControlItem2
			// 
			layoutControlItem2.Control = txtGrossMinimumWage;
			layoutControlItem2.Location = new Point(0, 24);
			layoutControlItem2.Name = "layoutControlItem2";
			layoutControlItem2.Size = new Size(412, 24);
			layoutControlItem2.Text = "Brüt Ücret";
			layoutControlItem2.TextSize = new Size(79, 13);
			// 
			// layoutControlItem3
			// 
			layoutControlItem3.Control = txtParameter1;
			layoutControlItem3.Location = new Point(0, 48);
			layoutControlItem3.Name = "layoutControlItem3";
			layoutControlItem3.Size = new Size(412, 24);
			layoutControlItem3.Text = "Parametre 1";
			layoutControlItem3.TextSize = new Size(79, 13);
			// 
			// layoutControlItem4
			// 
			layoutControlItem4.Control = txtParameter2;
			layoutControlItem4.Location = new Point(0, 72);
			layoutControlItem4.Name = "layoutControlItem4";
			layoutControlItem4.Size = new Size(412, 24);
			layoutControlItem4.Text = "Parametre 2";
			layoutControlItem4.TextSize = new Size(79, 13);
			// 
			// XtraPayrolParameter
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(432, 188);
			Controls.Add(layoutControl1);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Name = "XtraPayrolParameter";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Bodro Parametreleri";
			Load += XtraPayrolParameter_Load;
			((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
			layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)txtParameter2.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)txtParameter1.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtGrossMinimumWage.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtNetMinimumWage.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.BarButtonItem btnUpdate;
		private DevExpress.XtraBars.BarButtonItem btnClose;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraEditors.TextEdit txtParameter2;
		private DevExpress.XtraEditors.TextEdit txtParameter1;
		private DevExpress.XtraEditors.TextEdit txtGrossMinimumWage;
		private DevExpress.XtraEditors.TextEdit txtNetMinimumWage;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
	}
}