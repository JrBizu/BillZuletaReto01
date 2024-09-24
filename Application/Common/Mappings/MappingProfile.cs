

using Application.UseCases.Tareas.Commands.CreateTarea;
using Application.UseCases.Tareas.Commands.UpdateTarea;
using AutoMapper;

namespace Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<CreateTareaCommandModel, CreateTareaCommand>();
            this.CreateMap<UpdateTareaCommandModel, UpdateTareaCommand>();
        }
    }
}
