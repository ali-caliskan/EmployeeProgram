using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	//*Bu kod parçası, bir Entity Framework (EF) kullanarak
	//veritabanından "Department" (Departman) bilgilerini almak için tasarlanmış bir veri erişim katmanı sınıfıdır.
	//Sınıf, IDepartmentDal adlı bir arayüzü (interface) uyguluyor
	//ve GetList() metodunu kullanarak tüm departmanları veritabanından liste olarak döndürüyor.*\\


	//IDepartmentDal Interface implement ediyoruz buraya.
	public class EFDepartmentDal : EfEntityRepositoryBase<Department,EmployeeDbContext>,
		IDepartmentDal
	{
		
		public bool CheckDepartmentUses(int departmentId)
		{
			using(var  context = new EmployeeDbContext())
			{
				var result = context.Employees.Where(e => e.DepartmenId == departmentId);
				return (result.Count() > 0 ? false:true);
			}
		}

		public List<Department> GetList()
		{
			//EmployeeDbContext nesnesi,
			//using bloğu içerisinde açılır ve kullanıldıktan sonra otomatik olarak bellekten temizlenir.
			using (var context = new EmployeeDbContext())
			{
				var result = from department in context.Departments
							 select new Department
							 {
								 Id = department.Id,
								 Name = department.Name.ToUpper(),
								 Status = department.Status
							 };
				return result.ToList();
			}
		}
		//Say
		public List<DepartmentDto> GetListEmployeeCount()
		{
			using(var context = new EmployeeDbContext())
			{
				var result = from department in context.Departments
							 select new DepartmentDto
							 {
								 Id = department.Id,
								 Name = department.Name.ToUpper(),
								 EmployeeCount = context.Employees.Where(e => e.DepartmenId == department.Id && e.Status != "İşten Ayrıldı").Count()
							 };
				return result.ToList();
			}
		}

		public List<Department> GetListWithStatusTrue()
		{
			using (var context = new EmployeeDbContext())
			{
				var result = from department in context.Departments
							 where department.Status == true
							 select new Department
							 {
								 Id = department.Id,
								 Name = department.Name.ToUpper(),
								 Status = department.Status
							 };
				return result.ToList();
			}
		}

		public void StatusChange(Department department)
		{
			using (var context = new EmployeeDbContext())
			{
				if (department.Status)
				{
					department.Status = false;
				}
				else
				{
					department.Status = true;
				}
				context.Departments.Update(department);
				context.SaveChanges();
			}
		}
	}
}
