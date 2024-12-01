using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static bool Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);

            var result = validator.Validate(context);

            if (!result.IsValid)
            {
                // Eğer doğrulama geçerli değilse, her bir hata mesajı kullanıcıya gösterilir
                foreach (var error in result.Errors)
                {
                    MessageBox.Show(error.ErrorMessage, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return false;
            }
            return true;

        }
    }
}
