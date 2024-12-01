namespace EmployeeUI
{
	partial class XtraOffDayUpdate
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraOffDayUpdate));
			dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			btnClose = new DevExpress.XtraEditors.SimpleButton();
			btnSave = new DevExpress.XtraEditors.SimpleButton();
			txtOffStartDate = new DevExpress.XtraEditors.DateEdit();
			txtEmployeeName = new DevExpress.XtraEditors.TextEdit();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)dataLayoutControl1).BeginInit();
			dataLayoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)txtOffStartDate.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtOffStartDate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtEmployeeName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)Root).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
			SuspendLayout();
			// 
			// dataLayoutControl1
			// 
			dataLayoutControl1.Controls.Add(btnClose);
			dataLayoutControl1.Controls.Add(btnSave);
			dataLayoutControl1.Controls.Add(txtOffStartDate);
			dataLayoutControl1.Controls.Add(txtEmployeeName);
			dataLayoutControl1.Dock = DockStyle.Fill;
			dataLayoutControl1.Location = new Point(0, 0);
			dataLayoutControl1.Name = "dataLayoutControl1";
			dataLayoutControl1.Root = Root;
			dataLayoutControl1.Size = new Size(463, 182);
			dataLayoutControl1.TabIndex = 0;
			dataLayoutControl1.Text = "dataLayoutControl1";
			// 
			// btnClose
			// 
			btnClose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnClose.ImageOptions.SvgImage");
			btnClose.Location = new Point(12, 100);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(439, 36);
			btnClose.StyleController = dataLayoutControl1;
			btnClose.TabIndex = 7;
			btnClose.Text = "Kapat";
			btnClose.Click += btnClose_Click;
			// 
			// btnSave
			// 
			btnSave.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSave.ImageOptions.SvgImage");
			btnSave.Location = new Point(12, 60);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(439, 36);
			btnSave.StyleController = dataLayoutControl1;
			btnSave.TabIndex = 6;
			btnSave.Text = "Kaydet";
			btnSave.Click += btnSave_Click;
			// 
			// txtOffStartDate
			// 
			txtOffStartDate.EditValue = null;
			txtOffStartDate.Location = new Point(83, 36);
			txtOffStartDate.Name = "txtOffStartDate";
			txtOffStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			txtOffStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			txtOffStartDate.Size = new Size(368, 20);
			txtOffStartDate.StyleController = dataLayoutControl1;
			txtOffStartDate.TabIndex = 5;
			// 
			// txtEmployeeName
			// 
			txtEmployeeName.Location = new Point(83, 12);
			txtEmployeeName.Name = "txtEmployeeName";
			txtEmployeeName.Size = new Size(368, 20);
			txtEmployeeName.StyleController = dataLayoutControl1;
			txtEmployeeName.TabIndex = 4;
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4 });
			Root.Name = "Root";
			Root.Size = new Size(463, 182);
			Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.Control = txtEmployeeName;
			layoutControlItem1.Location = new Point(0, 0);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new Size(443, 24);
			layoutControlItem1.Text = "Personel Adı";
			layoutControlItem1.TextSize = new Size(59, 13);
			// 
			// emptySpaceItem1
			// 
			emptySpaceItem1.AllowHotTrack = false;
			emptySpaceItem1.Location = new Point(0, 128);
			emptySpaceItem1.Name = "emptySpaceItem1";
			emptySpaceItem1.Size = new Size(443, 34);
			emptySpaceItem1.TextSize = new Size(0, 0);
			// 
			// layoutControlItem2
			// 
			layoutControlItem2.Control = txtOffStartDate;
			layoutControlItem2.Location = new Point(0, 24);
			layoutControlItem2.Name = "layoutControlItem2";
			layoutControlItem2.Size = new Size(443, 24);
			layoutControlItem2.Text = "İzin Tarihi";
			layoutControlItem2.TextSize = new Size(59, 13);
			// 
			// layoutControlItem3
			// 
			layoutControlItem3.Control = btnSave;
			layoutControlItem3.Location = new Point(0, 48);
			layoutControlItem3.Name = "layoutControlItem3";
			layoutControlItem3.Size = new Size(443, 40);
			layoutControlItem3.TextSize = new Size(0, 0);
			layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			layoutControlItem4.Control = btnClose;
			layoutControlItem4.Location = new Point(0, 88);
			layoutControlItem4.Name = "layoutControlItem4";
			layoutControlItem4.Size = new Size(443, 40);
			layoutControlItem4.TextSize = new Size(0, 0);
			layoutControlItem4.TextVisible = false;
			// 
			// XtraOffDayUpdate
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(463, 182);
			Controls.Add(dataLayoutControl1);
			Name = "XtraOffDayUpdate";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Personel izin Güncelleme Formu";
			Load += XtraOffDayUpdate_Load;
			((System.ComponentModel.ISupportInitialize)dataLayoutControl1).EndInit();
			dataLayoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)txtOffStartDate.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtOffStartDate.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtEmployeeName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.SimpleButton btnClose;
		private DevExpress.XtraEditors.SimpleButton btnSave;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		public DevExpress.XtraEditors.DateEdit txtOffStartDate;
		public DevExpress.XtraEditors.TextEdit txtEmployeeName;
	}
}