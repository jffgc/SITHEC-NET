using FluentValidation;

namespace SITHEC.Application.Dtos.Human.Validators
{
    public class UpdateHumanDtoValidators : AbstractValidator<UpdateHumanDto>
    {
        public UpdateHumanDtoValidators()
        {
            RuleFor(p => p.Id)
                .NotNull().WithMessage("{PropertyName} es requerido");

            RuleFor(p => p.Name)
               .NotNull().WithMessage("El campo Nombre(s) no puede estar vacío")
               .NotEmpty().WithMessage("El campo Nombre(s) no puede ser nulo")
               .MaximumLength(35).WithMessage("El campo nombre(s) no puede ser mayor de 35 caracteres");

            RuleFor(p => p.Gender)
                .NotNull().WithMessage("El campo sexo no puede ser nulo");

            RuleFor(p => p.Age)
                .NotNull().WithMessage("El campo edad no puede ser nulo");

            RuleFor(p => p.Size)
                .NotNull().WithMessage("El campo altura no puede ser nulo");

            RuleFor(p => p.Weight)
                .NotNull().WithMessage("El campo peso no puede ser nulo");
        }
    }
}
