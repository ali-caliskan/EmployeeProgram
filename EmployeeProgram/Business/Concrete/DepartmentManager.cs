using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bu kod, iş katmanında (Business Layer) kullanılan DepartmentManager sınıfını tanımlar.
//DepartmentManager, bir departmanla ilgili iş kurallarını ve iş mantığını yönetir.
//Bu sınıf, bir veri erişim katmanı nesnesine (IDepartmentDal) bağımlıdır
//ve bu sayede departman bilgilerini veri kaynağından çekebilir.
namespace Business.Concrete
{
    public class DepartmentManager : IDepartmentService
	{
		private readonly IDepartmentDal _departmentDal;


		//Constructor(Yapıcı Metod)
		//Bu, bağımlılık enjeksiyonu (Dependency Injection) ile çalışan bir yapıcı metottur.
		//IDepartmentDal türünde bir veri erişim nesnesi (departmentDal) dışarıdan alınır ve
		//sınıf içinde kullanılmak üzere _departmentDal alanına atanır.
		public DepartmentManager(IDepartmentDal departmentDal)
		{
			_departmentDal = departmentDal;
		}



		public bool Add(Department department)
		{
			bool validation = ValidationTool.Validate(new DepartmentValidator(), department);
			if(validation) 
			{
				_departmentDal.Add(department);
				MessageBox.Show("Departman Başarıyla Eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			return false;
		}





		public void Delete(Department department)
		{
			var result = _departmentDal.CheckDepartmentUses(department.Id);
			if(!result)
			{
				MessageBox.Show("Bu departmana bağlı personeller bulunduğundan silme işlemi gerçekleştirilememektedir."
					,"Silme İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			_departmentDal.Delete(department);
			
		}

		public int GetdepartmentId(string departmentName)
		{
			return _departmentDal.GetList().Where(d => d.Name == departmentName).Select(s => s.Id).FirstOrDefault();
		}

		public Department Get(int id)
		{
			return _departmentDal.Get(g => g.Id == id);
		}

		//(örneğin departman verileri filtrelenecek ya da ek kontroller yapılacaksa),
		//bu işlemler bu metot içinde yapılabilir.
		public List<Department> GetList()
		{
			return _departmentDal.GetList();
		}

		public bool Update(Department department)
		{

			bool validation = ValidationTool.Validate(new DepartmentValidator(), department);
			if (validation)
			{
				_departmentDal.Update(department);
				MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			return false;
		}

		public bool StatusChange(Department department)
		{
			_departmentDal.StatusChange(department);
			//MessageBox.Show("Durum Güncelleme işlemi başarıyla gerçekleşti.", "Başarılı",
			//MessageBoxButtons.OK, MessageBoxIcon.Information);
			return true;

		}

		public List<Department> GetListWithStatusTrue()
		{
			return _departmentDal.GetListWithStatusTrue();
		}

		public List<DepartmentDto> GetListEmployeeCount()
		{
			return _departmentDal.GetListEmployeeCount();
		}
	}
}
