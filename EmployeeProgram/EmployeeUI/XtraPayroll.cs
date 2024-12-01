using Business.Abstract;
using DevExpress.XtraEditors;
using Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using DevExpress.Spreadsheet;

namespace EmployeeUI
{
	public partial class XtraPayroll : DevExpress.XtraEditors.XtraForm
	{
		private readonly IPayrollService _payrollService;


		public XtraPayroll(IPayrollService payrollService)
		{
			InitializeComponent();
			_payrollService = payrollService;
		}

		private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Close();
		}

		private void btnPayroll_Click(object sender, EventArgs e)
		{
			_payrollService.Add(Convert.ToInt16(txtMounth.Text), Convert.ToInt16(txtYear.Text));
			
			
		}

		void ExportExcel(int mounth, int year)
		{
			Excel.Application excel = new Excel.Application();
			object Missing = Type.Missing;
			Excel.Workbook workbook = excel.Workbooks.Add(Missing);
			Excel.Worksheet worksheet = (Excel.Worksheet)excel.Sheets[1];

			excel.Visible = true;

		}


		private void XtraPayroll_Load(object sender, EventArgs e)
		{
			var result = _payrollService.GetPayrolList();
			gC1.DataSource = result;
		}

		private void gridView1_Click(object sender, EventArgs e)
		{
			try
			{
				var selectedRow = (gridView1.GetFocusedRow() as PayrollListDto);
				var result = _payrollService.GetPayrollListWithEmployee().Where(w => w.Mounth == selectedRow.Mounth && w.Year == selectedRow.Year);
				gc2.DataSource = result;
			}
			catch (Exception)
			{

				
			}
		}
	}
}