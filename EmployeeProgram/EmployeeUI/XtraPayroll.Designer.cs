namespace EmployeeUI
{
	partial class XtraPayroll
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraPayroll));
			barManager1 = new DevExpress.XtraBars.BarManager(components);
			bar2 = new DevExpress.XtraBars.Bar();
			btnClose = new DevExpress.XtraBars.BarButtonItem();
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			txtYear = new DevExpress.XtraEditors.ComboBoxEdit();
			txtMounth = new DevExpress.XtraEditors.ComboBoxEdit();
			btnPayroll = new DevExpress.XtraEditors.SimpleButton();
			gc2 = new DevExpress.XtraGrid.GridControl();
			gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			gC1 = new DevExpress.XtraGrid.GridControl();
			gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
			layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)txtYear.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtMounth.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)gc2).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
			((System.ComponentModel.ISupportInitialize)gC1).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)Root).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
			SuspendLayout();
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
			barDockControlTop.Size = new Size(1031, 24);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = DockStyle.Bottom;
			barDockControlBottom.Location = new Point(0, 639);
			barDockControlBottom.Manager = barManager1;
			barDockControlBottom.Size = new Size(1031, 0);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = DockStyle.Left;
			barDockControlLeft.Location = new Point(0, 24);
			barDockControlLeft.Manager = barManager1;
			barDockControlLeft.Size = new Size(0, 615);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = DockStyle.Right;
			barDockControlRight.Location = new Point(1031, 24);
			barDockControlRight.Manager = barManager1;
			barDockControlRight.Size = new Size(0, 615);
			// 
			// layoutControl1
			// 
			layoutControl1.Controls.Add(txtYear);
			layoutControl1.Controls.Add(txtMounth);
			layoutControl1.Controls.Add(btnPayroll);
			layoutControl1.Controls.Add(gc2);
			layoutControl1.Controls.Add(gC1);
			layoutControl1.Dock = DockStyle.Fill;
			layoutControl1.Location = new Point(0, 24);
			layoutControl1.Name = "layoutControl1";
			layoutControl1.Root = Root;
			layoutControl1.Size = new Size(1031, 615);
			layoutControl1.TabIndex = 6;
			layoutControl1.Text = "layoutControl1";
			// 
			// txtYear
			// 
			txtYear.Location = new Point(37, 36);
			txtYear.MenuManager = barManager1;
			txtYear.Name = "txtYear";
			txtYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			txtYear.Properties.Items.AddRange(new object[] { "2024", "2025", "2026", "2027", "2028" });
			txtYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			txtYear.Size = new Size(248, 20);
			txtYear.StyleController = layoutControl1;
			txtYear.TabIndex = 10;
			// 
			// txtMounth
			// 
			txtMounth.Location = new Point(37, 12);
			txtMounth.MenuManager = barManager1;
			txtMounth.Name = "txtMounth";
			txtMounth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			txtMounth.Properties.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
			txtMounth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			txtMounth.Size = new Size(248, 20);
			txtMounth.StyleController = layoutControl1;
			txtMounth.TabIndex = 9;
			// 
			// btnPayroll
			// 
			btnPayroll.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnPayroll.ImageOptions.SvgImage");
			btnPayroll.Location = new Point(12, 60);
			btnPayroll.Name = "btnPayroll";
			btnPayroll.Size = new Size(273, 36);
			btnPayroll.StyleController = layoutControl1;
			btnPayroll.TabIndex = 8;
			btnPayroll.Text = "Bordro Hesapla";
			btnPayroll.Click += btnPayroll_Click;
			// 
			// gc2
			// 
			gc2.Location = new Point(289, 309);
			gc2.MainView = gridView2;
			gc2.MenuManager = barManager1;
			gc2.Name = "gc2";
			gc2.Size = new Size(730, 294);
			gc2.TabIndex = 5;
			gc2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
			// 
			// gridView2
			// 
			gridView2.GridControl = gc2;
			gridView2.Name = "gridView2";
			// 
			// gC1
			// 
			gC1.Location = new Point(289, 12);
			gC1.MainView = gridView1;
			gC1.MenuManager = barManager1;
			gC1.Name = "gC1";
			gC1.Size = new Size(730, 293);
			gC1.TabIndex = 4;
			gC1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
			// 
			// gridView1
			// 
			gridView1.GridControl = gC1;
			gridView1.Name = "gridView1";
			gridView1.OptionsBehavior.Editable = false;
			gridView1.Click += gridView1_Click;
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem5, layoutControlItem3, layoutControlItem4 });
			Root.Name = "Root";
			Root.Size = new Size(1031, 615);
			Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.Control = gC1;
			layoutControlItem1.Location = new Point(277, 0);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new Size(734, 297);
			layoutControlItem1.TextSize = new Size(0, 0);
			layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			layoutControlItem2.Control = gc2;
			layoutControlItem2.Location = new Point(277, 297);
			layoutControlItem2.Name = "layoutControlItem2";
			layoutControlItem2.Size = new Size(734, 298);
			layoutControlItem2.TextSize = new Size(0, 0);
			layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			layoutControlItem5.Control = btnPayroll;
			layoutControlItem5.Location = new Point(0, 48);
			layoutControlItem5.Name = "layoutControlItem5";
			layoutControlItem5.Size = new Size(277, 547);
			layoutControlItem5.TextSize = new Size(0, 0);
			layoutControlItem5.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			layoutControlItem3.Control = txtMounth;
			layoutControlItem3.Location = new Point(0, 0);
			layoutControlItem3.Name = "layoutControlItem3";
			layoutControlItem3.Size = new Size(277, 24);
			layoutControlItem3.Text = "Ay";
			layoutControlItem3.TextSize = new Size(13, 13);
			// 
			// layoutControlItem4
			// 
			layoutControlItem4.Control = txtYear;
			layoutControlItem4.Location = new Point(0, 24);
			layoutControlItem4.Name = "layoutControlItem4";
			layoutControlItem4.Size = new Size(277, 24);
			layoutControlItem4.Text = "Yıl";
			layoutControlItem4.TextSize = new Size(13, 13);
			// 
			// XtraPayroll
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1031, 639);
			Controls.Add(layoutControl1);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Name = "XtraPayroll";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Bordro";
			Load += XtraPayroll_Load;
			((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
			layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)txtYear.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtMounth.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)gc2).EndInit();
			((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
			((System.ComponentModel.ISupportInitialize)gC1).EndInit();
			((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem btnClose;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraGrid.GridControl gc2;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraGrid.GridControl gC1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraEditors.ComboBoxEdit txtYear;
		private DevExpress.XtraEditors.ComboBoxEdit txtMounth;
		private DevExpress.XtraEditors.SimpleButton btnPayroll;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
	}
}