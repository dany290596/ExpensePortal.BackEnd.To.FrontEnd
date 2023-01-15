using Evaluacion.Data.Interfaces.Common;
using Evaluacion.Domain.Entities.Gastos;
using Evaluacion.Services.Interfaces.Gastos;

namespace Evaluacion.Services.Services.Gastos
{
    public class ConceptoService : IConceptoService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ConceptoService(
            IUnitOfWork unitOfWork
            )
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Procedimiento>> ExecuteProcedureConcept(string folio)
        {
            var lista = await _unitOfWork.ConceptoRepository.ExecuteProcedureConcept(folio);

            return lista;
        }

        public IEnumerable<Concepts> GetAll()
        {
            return _unitOfWork.ConceptoRepository.GetAll();
        }
    }
}