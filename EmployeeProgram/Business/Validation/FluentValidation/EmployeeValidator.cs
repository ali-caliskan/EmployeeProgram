using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
	public class EmployeeValidator : AbstractValidator<Employee>
	{
        public EmployeeValidator()
        {
            RuleFor(r => r.Name).NotEmpty().WithMessage("Personel Adı Boş Geçilemez.");
            RuleFor(r => r.Name).MinimumLength(3).WithMessage("Personel Adı En Az 3 Karakter Olmalıdır.");

            RuleFor(r => r.LastName).NotEmpty().WithMessage("Personel Adı Boş Geçilemez.");
            RuleFor(r => r.LastName).MinimumLength(3).WithMessage("Personel Soyadı En Az 3 Karakter Olmalıdır.");

			// Personelin 18 yaşından küçük olamayacağını kontrol eden kural
			RuleFor(r => r.BirthDate)
				.NotEmpty().WithMessage("Doğum Tarihi Boş Geçilemez.")
				.Must(BeAtLeast18YearsOld).WithMessage("Personel En Az 18 Yaşında Olmalıdır.");

			RuleFor(r => r.Salary)
				.GreaterThan(0).WithMessage("Personel Ücreti Asgari Ücretten Büyük Olmalıdır.");

			RuleFor(r => r.DepartmenId).
				GreaterThan(0).WithMessage("Lütfen Departman Seçiniz.");

			RuleFor(r => r.IdentityNumber)
			   .NotEmpty().WithMessage("TC Kimlik Numarası Boş Bırakılamaz.")
			   .MinimumLength(11).WithMessage("TC Kimlik Numarası Tam Olarak 11 Karakterden Oluşmalıdır.")
			   .MaximumLength(11).WithMessage("TC Kimlik Numarası Tam Olarak 11 Karakterden Oluşmalıdır.");
		}

		private bool BeAtLeast18YearsOld(DateTime dateOfBirth)
		{
			var today = DateTime.Today;
			var age = today.Year - dateOfBirth.Year;

			// Eğer doğum günü bu yıl henüz geçmemişse yaşı bir eksilt
			if (dateOfBirth.Date > today.AddYears(-age)) age--;

			return age >= 18;
		}
	}
}
