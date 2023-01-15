using AutoMapper;
using Evaluacion.Services.Interfaces.Gastos;
using Evaluacion.Services.Responses;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Evaluacion.Api.Controllers.Gastos
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Gastos")]
    public class ConceptoController : ControllerBase
    {
        private readonly IConceptoService _conceptoService;
        private readonly IMapper _mapper;

        public ConceptoController(
            IConceptoService conceptoService,
            IMapper mapper
            )
        {
            _conceptoService = conceptoService;
            _mapper = mapper;
        }

        [Route("ObtenerConceptos")]
        [HttpGet]
        public async Task<IActionResult> GetConcept([Required] string folio)
        {
            var lista = await _conceptoService.ExecuteProcedureConcept(folio);
            var listaDTO = _mapper.Map<List<Models.Response.Gastos.ProcedimientoDTO>>(lista);
            var response = new ApiResponse<List<Models.Response.Gastos.ProcedimientoDTO>>(true, "La consulta se ejecutó correctamente", 200, listaDTO);

            return StatusCode(200, response);
        }
    }
}