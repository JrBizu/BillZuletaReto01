

using FluentValidation;

namespace Application.UseCases.Tareas.Commands.CreateTarea
{
    public class CreateTareaCommandValidator : AbstractValidator<CreateTareaCommand>
    {
        public CreateTareaCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("No tiene ID");

            RuleFor(x => x.Titulo)
                .NotEmpty()
                .WithMessage("Debe tener un Título");

            RuleFor(x => x.Descripcion)
                .NotEmpty()
                .NotNull()
                .WithMessage("Debe ingresar una Descripción");

            RuleFor(x => x.Estado)
                .NotEmpty()
                .WithMessage("Debe ingresar un Estado (Activo/Inactivo)");
        }
    }
}
