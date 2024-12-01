namespace EmployeeUI
{
	partial class XtraOffDayAdd
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraOffDayAdd));
			layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			txtEmployee = new DevExpress.XtraEditors.SearchLookUpEdit();
			searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			btnClose = new DevExpress.XtraEditors.SimpleButton();
			btnSave = new DevExpress.XtraEditors.SimpleButton();
			txtEndDate = new DevExpress.XtraEditors.DateEdit();
			txtStartDate = new DevExpress.XtraEditors.DateEdit();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
			layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)txtEmployee.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtEndDate.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtEndDate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtStartDate.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtStartDate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)Root).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
			SuspendLayout();
			// 
			// layoutControl1
			// 
			layoutControl1.Controls.Add(txtEmployee);
			layoutControl1.Controls.Add(btnClose);
			layoutControl1.Controls.Add(btnSave);
			layoutControl1.Controls.Add(txtEndDate);
			layoutControl1.Controls.Add(txtStartDate);
			layoutControl1.Dock = DockStyle.Fill;
			layoutControl1.Location = new Point(0, 0);
			layoutControl1.Name = "layoutControl1";
			layoutControl1.Root = Root;
			layoutControl1.Size = new Size(586, 162);
			layoutControl1.TabIndex = 0;
			layoutControl1.Text = "layoutControl1";
			// 
			// txtEmployee
			// 
			txtEmployee.Location = new Point(117, 12);
			txtEmployee.Name = "txtEmployee";
			txtEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			txtEmployee.Properties.PopupView = searchLookUpEdit1View;
			txtEmployee.Size = new Size(457, 20);
			txtEmployee.StyleController = layoutControl1;
			txtEmployee.TabIndex = 8;
			txtEmployee.EditValueChanged += txtEmployee_EditValueChanged;
			// 
			// searchLookUpEdit1View
			// 
			searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			searchLookUpEdit1View.Name = "searchLookUpEdit1View";
			searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// btnClose
			// 
			btnClose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnClose.ImageOptions.SvgImage");
			btnClose.Location = new Point(12, 100);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(562, 36);
			btnClose.StyleController = layoutControl1;
			btnClose.TabIndex = 7;
			btnClose.Text = "Kapat";
			btnClose.Click += btnClose_Click;
			// 
			// btnSave
			// 
			btnSave.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSave.ImageOptions.SvgImage");
			btnSave.Location = new Point(12, 60);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(562, 36);
			btnSave.StyleController = layoutControl1;
			btnSave.TabIndex = 6;
			btnSave.Text = "Kaydet";
			btnSave.Click += btnSave_Click;
			// 
			// txtEndDate
			// 
			txtEndDate.EditValue = null;
			txtEndDate.Location = new Point(400, 36);
			txtEndDate.Name = "txtEndDate";
			txtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			txtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			txtEndDate.Size = new Size(174, 20);
			txtEndDate.StyleController = layoutControl1;
			txtEndDate.TabIndex = 5;
			// 
			// txtStartDate
			// 
			txtStartDate.EditValue = null;
			txtStartDate.Location = new Point(117, 36);
			txtStartDate.Name = "txtStartDate";
			txtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			txtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			txtStartDate.Size = new Size(174, 20);
			txtStartDate.StyleController = layoutControl1;
			txtStartDate.TabIndex = 4;
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem2 });
			Root.Name = "Root";
			Root.Size = new Size(586, 162);
			Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.Control = txtStartDate;
			layoutControlItem1.Location = new Point(0, 24);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new Size(283, 24);
			layoutControlItem1.Text = "İzin Başlangıç Tarihi";
			layoutControlItem1.TextSize = new Size(93, 13);
			// 
			// emptySpaceItem1
			// 
			emptySpaceItem1.AllowHotTrack = false;
			emptySpaceItem1.Location = new Point(0, 128);
			emptySpaceItem1.Name = "emptySpaceItem1";
			emptySpaceItem1.Size = new Size(566, 14);
			emptySpaceItem1.TextSize = new Size(0, 0);
			// 
			// layoutControlItem3
			// 
			layoutControlItem3.Control = btnSave;
			layoutControlItem3.Location = new Point(0, 48);
			layoutControlItem3.Name = "layoutControlItem3";
			layoutControlItem3.Size = new Size(566, 40);
			layoutControlItem3.TextSize = new Size(0, 0);
			layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			layoutControlItem4.Control = btnClose;
			layoutControlItem4.Location = new Point(0, 88);
			layoutControlItem4.Name = "layoutControlItem4";
			layoutControlItem4.Size = new Size(566, 40);
			layoutControlItem4.TextSize = new Size(0, 0);
			layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			layoutControlItem5.Control = txtEmployee;
			layoutControlItem5.Location = new Point(0, 0);
			layoutControlItem5.Name = "layoutControlItem5";
			layoutControlItem5.Size = new Size(566, 24);
			layoutControlItem5.Text = "Personel";
			layoutControlItem5.TextSize = new Size(93, 13);
			// 
			// layoutControlItem2
			// 
			layoutControlItem2.Control = txtEndDate;
			layoutControlItem2.Location = new Point(283, 24);
			layoutControlItem2.Name = "layoutControlItem2";
			layoutControlItem2.Size = new Size(283, 24);
			layoutControlItem2.Text = "İzin Bitiş Tarihi";
			layoutControlItem2.TextSize = new Size(93, 13);
			// 
			// XtraOffDayAdd
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(586, 162);
			Controls.Add(layoutControl1);
			Name = "XtraOffDayAdd";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Personel İzin Kayıt Formu";
			Load += XtraOffDayAdd_Load;
			((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
			layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)txtEmployee.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
			((System.ComponentModel.ISupportInitialize)txtEndDate.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtEndDate.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtStartDate.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtStartDate.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraEditors.SimpleButton btnClose;
		private DevExpress.XtraEditors.SimpleButton btnSave;
		private DevExpress.XtraEditors.DateEdit txtEndDate;
		private DevExpress.XtraEditors.DateEdit txtStartDate;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraEditors.SearchLookUpEdit txtEmployee;
		private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
	}
}