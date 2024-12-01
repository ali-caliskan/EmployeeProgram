namespace EmployeeUI
{
	partial class XtraHome
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraHome));
			ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			btnEmployee = new DevExpress.XtraBars.BarButtonItem();
			btnClose = new DevExpress.XtraBars.BarButtonItem();
			btnDepartment = new DevExpress.XtraBars.BarButtonItem();
			btnEmployeeAdd = new DevExpress.XtraBars.BarButtonItem();
			btnOffDayAdd = new DevExpress.XtraBars.BarButtonItem();
			btnOffDayList = new DevExpress.XtraBars.BarButtonItem();
			btnPayrollParameter = new DevExpress.XtraBars.BarButtonItem();
			ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
			btnPayroll = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
			SuspendLayout();
			// 
			// ribbonControl1
			// 
			ribbonControl1.ExpandCollapseItem.Id = 0;
			ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, btnEmployee, btnClose, btnDepartment, btnEmployeeAdd, btnOffDayAdd, btnOffDayList, btnPayrollParameter, btnPayroll });
			ribbonControl1.Location = new Point(0, 0);
			ribbonControl1.MaxItemId = 9;
			ribbonControl1.Name = "ribbonControl1";
			ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
			ribbonControl1.Size = new Size(1033, 150);
			// 
			// btnEmployee
			// 
			btnEmployee.Caption = "Personel Listesi";
			btnEmployee.Id = 1;
			btnEmployee.ImageOptions.LargeImage = (Image)resources.GetObject("btnEmployee.ImageOptions.LargeImage");
			btnEmployee.Name = "btnEmployee";
			btnEmployee.ItemClick += btnEmployee_ItemClick;
			// 
			// btnClose
			// 
			btnClose.Caption = "Kapat";
			btnClose.Id = 2;
			btnClose.ImageOptions.LargeImage = (Image)resources.GetObject("btnClose.ImageOptions.LargeImage");
			btnClose.Name = "btnClose";
			btnClose.ItemClick += btnClose_ItemClick;
			// 
			// btnDepartment
			// 
			btnDepartment.Caption = "Personel Bölümleri";
			btnDepartment.Id = 3;
			btnDepartment.ImageOptions.LargeImage = (Image)resources.GetObject("btnDepartment.ImageOptions.LargeImage");
			btnDepartment.Name = "btnDepartment";
			btnDepartment.ItemClick += btnDepartment_ItemClick;
			// 
			// btnEmployeeAdd
			// 
			btnEmployeeAdd.Caption = "Personel Ekle";
			btnEmployeeAdd.Id = 4;
			btnEmployeeAdd.ImageOptions.LargeImage = (Image)resources.GetObject("btnEmployeeAdd.ImageOptions.LargeImage");
			btnEmployeeAdd.Name = "btnEmployeeAdd";
			btnEmployeeAdd.ItemClick += btnEmployeeAdd_ItemClick;
			// 
			// btnOffDayAdd
			// 
			btnOffDayAdd.Caption = "Personel İzin Girişi";
			btnOffDayAdd.Id = 5;
			btnOffDayAdd.ImageOptions.LargeImage = (Image)resources.GetObject("btnOffDayAdd.ImageOptions.LargeImage");
			btnOffDayAdd.Name = "btnOffDayAdd";
			btnOffDayAdd.ItemClick += btnOffDayAdd_ItemClick;
			// 
			// btnOffDayList
			// 
			btnOffDayList.Caption = "Personel İzin Listesi";
			btnOffDayList.Id = 6;
			btnOffDayList.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnOffDayList.ImageOptions.SvgImage");
			btnOffDayList.Name = "btnOffDayList";
			btnOffDayList.ItemClick += btnOffDayList_ItemClick;
			// 
			// btnPayrollParameter
			// 
			btnPayrollParameter.Caption = "Bodro Parametreleri";
			btnPayrollParameter.Id = 7;
			btnPayrollParameter.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnPayrollParameter.ImageOptions.SvgImage");
			btnPayrollParameter.Name = "btnPayrollParameter";
			btnPayrollParameter.ItemClick += btnPayrollParameter_ItemClick;
			// 
			// ribbonPage1
			// 
			ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3, ribbonPageGroup1, ribbonPageGroup4, ribbonPageGroup2 });
			ribbonPage1.Name = "ribbonPage1";
			ribbonPage1.Text = "Personel Takip";
			// 
			// ribbonPageGroup3
			// 
			ribbonPageGroup3.ItemLinks.Add(btnEmployee);
			ribbonPageGroup3.ItemLinks.Add(btnDepartment);
			ribbonPageGroup3.ItemLinks.Add(btnOffDayList);
			ribbonPageGroup3.ItemLinks.Add(btnPayroll);
			ribbonPageGroup3.Name = "ribbonPageGroup3";
			ribbonPageGroup3.Text = "Listeler";
			// 
			// ribbonPageGroup1
			// 
			ribbonPageGroup1.ItemLinks.Add(btnEmployeeAdd);
			ribbonPageGroup1.ItemLinks.Add(btnOffDayAdd);
			ribbonPageGroup1.Name = "ribbonPageGroup1";
			ribbonPageGroup1.Text = "Kayıt";
			// 
			// ribbonPageGroup4
			// 
			ribbonPageGroup4.ItemLinks.Add(btnPayrollParameter);
			ribbonPageGroup4.Name = "ribbonPageGroup4";
			ribbonPageGroup4.Text = "Parametreler";
			// 
			// ribbonPageGroup2
			// 
			ribbonPageGroup2.ItemLinks.Add(btnClose);
			ribbonPageGroup2.Name = "ribbonPageGroup2";
			ribbonPageGroup2.Text = "Kapat";
			// 
			// xtraTabbedMdiManager1
			// 
			xtraTabbedMdiManager1.MdiParent = this;
			// 
			// btnPayroll
			// 
			btnPayroll.Caption = "Bordro ";
			btnPayroll.Id = 8;
			btnPayroll.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
			btnPayroll.Name = "btnPayroll";
			btnPayroll.ItemClick += btnPayroll_ItemClick;
			// 
			// XtraHome
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1033, 625);
			Controls.Add(ribbonControl1);
			IsMdiContainer = true;
			Name = "XtraHome";
			Text = "Personel Takip Formu";
			WindowState = FormWindowState.Maximized;
			Load += XtraHome_Load;
			((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.BarButtonItem btnEmployee;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.BarButtonItem btnClose;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.BarButtonItem btnDepartment;
		private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
		private DevExpress.XtraBars.BarButtonItem btnEmployeeAdd;
		private DevExpress.XtraBars.BarButtonItem btnOffDayAdd;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
		private DevExpress.XtraBars.BarButtonItem btnOffDayList;
		private DevExpress.XtraBars.BarButtonItem btnPayrollParameter;
		private DevExpress.XtraBars.BarButtonItem btnPayroll;
	}
}