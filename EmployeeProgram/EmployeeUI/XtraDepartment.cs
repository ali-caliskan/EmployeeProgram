using Business.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using DevExpress.XtraEditors;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeUI
{
	public partial class XtraDepartment : DevExpress.XtraEditors.XtraForm
	{
		private readonly IDepartmentService _departmentService;

		int _id;

		//ctor
		public XtraDepartment(IDepartmentService departmentService)
		{
			InitializeComponent();
			_departmentService = departmentService;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			if (btnClose.Text == "Vazgeç")
			{
				//txtDepartmentName.Text = "";
				Clear();
			}
			else
			{
				this.Close();
			}

		}

		private void XtraDepartment_Load(object sender, EventArgs e)
		{
			GetList();
		}

		//Çağırma
		void GetList()
		{
			var result = _departmentService.GetList();
			gC1.DataSource = result; // Verileri gridControl'e atar
		}

		//Silme method
		void Clear()
		{
			txtDepartmentName.Text = "";
			btnClose.Text = "Kapat";
			btnSave.Text = "Kaydet";
		}




		private void btnSave_Click(object sender, EventArgs e)
		{
			//Güncelle İşlemi
			if (btnSave.Text == "Güncelle")
			{
				var findDepartment = _departmentService.Get(_id);
				findDepartment.Name = txtDepartmentName.Text.ToLower();
				var result = _departmentService.Update(findDepartment);

				if (result)
				{
					GetList();
					Clear();

				}
			}
			else
			{
				//Kaydet İşlemi
				Department department = new Department
				{
					Name = txtDepartmentName.Text.ToLower(),
					Status = true
				};
				//business katmanına yollandı.
				var result = _departmentService.Add(department);
				if (result)
				{
					GetList();
					Clear();
				}
			}
		}

		//Departman Silme İşlemi!
		private void repositoryBtnDelete_Click(object sender, EventArgs e)
		{
			if (XtraMessageBox.Show($"{(gridView1.GetFocusedRow() as Department).Name} Departmanı Silmek İstiyor Musunuz"
				, "Hata", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				var department = (gridView1.GetFocusedRow() as Department);
				_departmentService.Delete(department);
				GetList();
			}
		}

		//Güncelle
		private void repositoryBtnEdit_Click(object sender, EventArgs e)
		{
			// Seçili satırdaki departman bilgisini alıyoruz
			var department = gridView1.GetFocusedRow() as Department;

			// Null kontrolü yapılır, eğer seçili satır yoksa işlem yapılmaz
			if (department == null)
			{
				XtraMessageBox.Show("Lütfen güncellemek istediğiniz bir departmanı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// ID ve İsim bilgileri alınıyor
			_id = department.Id;
			string name = department.Name;

			// Form alanları güncelleniyor
			txtDepartmentName.Text = name;

			// Butonun metni "Güncelle" olarak değiştiriliyor
			btnSave.Text = "Güncelle";

			// Butonun metni "Vazgeç" olarak değiştiriliyor
			btnClose.Text = "Vazgeç";
		}

		//Durum Butonu
		private void repositoryBtnStatusChange_Click(object sender, EventArgs e)
		{

			if (XtraMessageBox.Show($"{(gridView1.GetFocusedRow() as Department).Name} " +
				$"Departmanın Durumunu Değiştirmek İstiyor Musunuz ?"
				, "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				var department = (gridView1.GetFocusedRow() as Department);
				_departmentService.StatusChange(department);
				GetList();
			}
		}
	}
}