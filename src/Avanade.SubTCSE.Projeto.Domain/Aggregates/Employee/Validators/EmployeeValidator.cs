using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Validators;
using FluentValidation;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Validators
{
    public class EmployeeValidator : AbstractValidator<Entities.Employee>
    {
        public EmployeeValidator()
        {
            RuleSet("new", () =>
            {
                RuleFor(e => e.FirstName)
                .NotEmpty()
                .WithMessage("{PropertyName} cannot be empty");

                RuleFor(e => e.Surname)
                .NotEmpty()
                .WithMessage("{PropertyName} cannot be empty");

                RuleFor(e => e.EmployeeRole)
                .SetValidator(new EmployeeRoleValidator());
            });
        }
    }
}
