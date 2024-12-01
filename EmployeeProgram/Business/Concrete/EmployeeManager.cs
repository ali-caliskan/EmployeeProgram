using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class EmployeeManager : IEmployeeService
	{
		private readonly IEmployeeDal _employeeDal;

		public EmployeeManager(IEmployeeDal employeeDal)
		{
			_employeeDal = employeeDal;
		}

		public bool Add(Employee employee)
		{

			bool validation = ValidationTool.Validate(new EmployeeValidator(), employee);
			if(validation)
			{
				var result = _employeeDal.CheckIdentityNumber(employee.IdentityNumber);
				if(!result)
				{
					MessageBox.Show("TC Kimlik Numarası Daha Önce Kullanılmış.","Hata",MessageBoxButtons.OK,
						MessageBoxIcon.Warning);
					return false;
				}

				var resultSalary = _employeeDal.GetParameter();
				if(resultSalary.NetMinimumWage >= employee.Salary)
				{
					MessageBox.Show("Personel Ücreti Asgari Ücretten Aşağı Olamaz.", "Hata", MessageBoxButtons.OK,
						MessageBoxIcon.Warning);
					return false;
				}

				_employeeDal.Add(employee);
				MessageBox.Show("Personel Başarıyla Eklendi","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return true;
			}
			return false;
		}

		public void Delete(Employee employee)
		{
			_employeeDal.Delete(employee);
		}

		public Employee Get(int id)
		{
			return _employeeDal.Get(e => e.Id == id);
		}

		public List<Employee> GetAll()
		{
			return _employeeDal.GetList();
		}

		public List<EmployeeDto> GetEmployeeList()
		{
			return _employeeDal.GetEmployeeList();
		}

		public List<OffDayEmployeeDto> GetEmployeeListByOffDay()
		{
			return _employeeDal.GetEmployeeListByOffDay();
		}

		public PayrollParameter GetPayrollParameter()
		{
			return _employeeDal.GetParameter();
		}

		public void QuitJob(Employee employee)
		{
			var result = _employeeDal.GetOffDayByEmployee(employee.Id, Convert.ToDateTime(employee.EndingDate));
			if (result != null)
			{
				MessageBox.Show("Çıkış Tarihi İzinli Gününe Denk Geliyor. İzinli Gününde Personel İşten Çıkartılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_employeeDal.Update(employee);
			MessageBox.Show("Personel Çıkış İşlemi Başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public void reHired(Employee employee)
		{
			_employeeDal.Update(employee);
			MessageBox.Show("Personel İşe Giriş İşlemi Başarılıyla Gerçekleşti.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public bool Update(Employee employee)
		{
			bool validation = ValidationTool.Validate(new EmployeeValidator(), employee);
			if (validation)
			{
				var findEmployee = _employeeDal.Get(i => i.Id == employee.Id);
				var result = true;
				if(findEmployee.IdentityNumber != employee.IdentityNumber)
				{
					result = _employeeDal.CheckIdentityNumber(employee.IdentityNumber);
					if (!result)
					{
						MessageBox.Show("TC Kimlik Numarası Daha Önce Kullanılmış.", "Hata", MessageBoxButtons.OK,
							MessageBoxIcon.Warning);
						return false;
					}

					var resultSalary = _employeeDal.GetParameter();
					if (resultSalary.NetMinimumWage >= employee.Salary)
					{
						MessageBox.Show("Personel Ücreti Asgari Ücretten Aşağı Olamaz.", "Hata", MessageBoxButtons.OK,
							MessageBoxIcon.Warning);
						return false;
					}
				}
				_employeeDal.Update(employee);
				MessageBox.Show("Personel Başarıyla Güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			return false;
		}

		public void UpdateList(Employee employee)
		{
			_employeeDal.Update(employee);
		}
	}
}
