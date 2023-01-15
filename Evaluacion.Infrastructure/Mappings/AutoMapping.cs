using AutoMapper;
using Evaluacion.Domain.Entities.Gastos;

namespace Evaluacion.Infrastructure.Mappings
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            ConfigureMappings();
        }

        private void ConfigureMappings()
        {
            var config = new MapperConfiguration(cfg =>
            {
                CreateMap<Procedimiento, Models.Response.Gastos.ProcedimientoDTO>().ReverseMap();
            });
        }
    }
}