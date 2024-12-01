using Business.Abstract;
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
	public class OffDayManager : IOffDayService
	{
		private readonly IOffDayDal _offDayDal;
		

		public OffDayManager(IOffDayDal offDayDal)
		{
			_offDayDal = offDayDal;
			
		}

		public bool Add(int id, string dateString1, string dateString2)
		{
			DateTime date1 = Convert.ToDateTime(dateString1);
			DateTime date2 = Convert.ToDateTime(dateString2);
			if (date1 > date2)
			{
				MessageBox.Show("İzin Başlangıç Barihi Bitiş Tarihinden Büyük Olamaz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;
			}

			while (date1 <= date2)
			{
				var result = _offDayDal.GetList().Where(o => o.EmployeeId == id).ToList();
				int count = result.Where(r => r.Date == date1).Count();
				if (count > 0)
				{
					MessageBox.Show("Personel Bu Tarihler Arasında Zaten İzinli", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
				date1 = date1.AddDays(1);
			}

			date1 = Convert.ToDateTime(dateString1);
			while (date1 <= date2)
			{
				OffDay offDay = new OffDay()
				{
					EmployeeId = id,
					Date = date1,
				};

				_offDayDal.Add(offDay);
				date1 = date1.AddDays(1);
			}

			MessageBox.Show("Personel İzin Kaydı Başarıyla Gerçekleşti","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
			return true;
		}

		public bool Delete(OffDay offDay)
		{
			var employee = _offDayDal.GetEmployee(offDay.EmployeeId);
            if (employee.Status != "İşten Ayrıldı")
            {
				_offDayDal.Delete(offDay);
				MessageBox.Show("Personel İzni Başarıyla Silindi", "Başarılı",MessageBoxButtons.OK ,MessageBoxIcon.Information);
				return true;
			}
			MessageBox.Show("İşten Ayrılan Personelin İzin Kaydı Silinemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return false;

		}

		public OffDay Get(int id)
		{
			return _offDayDal.Get(o => o.Id == id);	
		}

		public Employee GetEmployee(int employeeId)
		{
			return _offDayDal.GetEmployee(employeeId);
		}

		public OffDay GetEmployeeOfDayByDate(int employeeId, DateTime date)
		{
			return _offDayDal.Get(g => g.EmployeeId == employeeId && g.Date == date);
		}

		public List<OffDayDto> GetEmployeeOffDays()
		{
			return _offDayDal.GetEmployeeOffDays();
		}

		public bool Update(OffDay offDay)
		{
			var result = _offDayDal.GetList().Where(o => o.EmployeeId == offDay.EmployeeId).ToList();
			int count = result.Where(r => r.Date == offDay.Date).Count();
			if (count > 0)
			{
				MessageBox.Show("Personel Bu Tarihler Arasında Zaten İzinli", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			_offDayDal.Update(offDay);
			MessageBox.Show("Personel İzin Tarihi Güncellenmiştir", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return true;
		}
	}
}
