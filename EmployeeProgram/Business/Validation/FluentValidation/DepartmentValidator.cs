using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
	public class DepartmentValidator : AbstractValidator<Department>
	{
        public DepartmentValidator()
        {
			// Departman adı boş olamaz
			RuleFor(r => r.Name)
				.NotEmpty()
				.WithMessage("Departman adı boş olamaz.");

			// Departman adı en az 3 karakter olmalı
			RuleFor(r => r.Name)
				.MinimumLength(3)
				.WithMessage("Departman adı en az 3 karakter olmalıdır.");

			// Departman adı en fazla 30 karakter olmalı
			RuleFor(r => r.Name)
				.MaximumLength(30)
				.WithMessage("Departman adı en fazla 30 karakter olmalıdır.");


			// Departman adı sadece harflerden oluşmalı (Türkçe karakterler dahil)
			RuleFor(r => r.Name)
				.Matches(@"^[a-zA-ZçÇğĞıİöÖşŞüÜ\s]+$")
				.WithMessage("Departman adı sadece harflerden oluşmalıdır.");

		}
    }
}
