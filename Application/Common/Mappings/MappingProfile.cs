

using Application.UseCases.Tareas.Commands.CreateTarea;
using Application.UseCases.Tareas.Queries.GetTareaPorId;
using AutoMapper;

namespace Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<CreateTareaCommandModel, CreateTareaCommand>();
            //this.CreateMap<GetTareaPorIdQueryDto, GetTareaPorIdQuery>();
        }
    }
}
