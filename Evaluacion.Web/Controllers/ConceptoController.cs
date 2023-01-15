using AutoMapper;
using Evaluacion.Services.Interfaces.Gastos;
using Evaluacion.Services.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Evaluacion.Web.Controllers
{
    public class ConceptoController : BaseController
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

        public IActionResult Index()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse<string>(false, "Error, la consulta no se ejecutó correctamente", 500, ""));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Detalle(Models.Request.Gastos.ProcedimientoDTO dTO)
        {
            try
            {
                var lista = await _conceptoService.ExecuteProcedureConcept(dTO.Folio);
                var listaDTO = _mapper.Map<List<Models.Response.Gastos.ProcedimientoDTO>>(lista);
                var response = new ApiResponse<List<Models.Response.Gastos.ProcedimientoDTO>>(true, "La consulta se ejecutó correctamente", 200, listaDTO);

                return View(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse<string>(false, "Error, la consulta no se ejecutó correctamente", 500, ""));
            }
        }
    }
}