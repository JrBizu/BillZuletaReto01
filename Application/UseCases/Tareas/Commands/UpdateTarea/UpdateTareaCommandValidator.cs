

using FluentValidation;

namespace Application.UseCases.Tareas.Commands.UpdateTarea
{
    public class UpdateTareaCommandValidator : AbstractValidator<UpdateTareaCommand>
    {
        public UpdateTareaCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("ID es obligatorio");

            RuleFor(x => x.Titulo)
                .NotEmpty()
                .WithMessage("Título es obligatorio");

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
