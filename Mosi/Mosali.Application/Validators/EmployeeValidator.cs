using FluentValidation;
using Survey.Application.ViewModels;
using System;

namespace Survey.Application.Validators
{
    public class EmployeeValidator:AbstractValidator<EmployeeViewModel>
    {
        public EmployeeValidator()
        {
            RuleFor(employee => employee.FirstName).NotNull().WithMessage("Le nom  est obligatoire");
        }
    }
}
