using FluentValidation;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Validators
{
    public class EmployeeRoleValidator : AbstractValidator<Entities.EmployeeRole>
    {
        public EmployeeRoleValidator()
        {
            //RuleFor(e => e.RoleName).NotEmpty().NotNull();
            RuleSet("new", () => 
            {
                RuleFor(e => e.RoleName).NotEmpty()
                .WithMessage("{PropertyName} cannot be empty");
            });

            RuleSet("GetById", () => 
            {
                RuleFor(e => e.Id)
                .NotEmpty()
                .WithMessage("{PropertyName} cannot be empty");
            });
        }
    }
}
