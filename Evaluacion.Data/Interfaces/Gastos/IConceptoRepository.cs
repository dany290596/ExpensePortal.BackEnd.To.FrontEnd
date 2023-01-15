using Evaluacion.Domain.Entities.Gastos;

namespace Evaluacion.Data.Interfaces.Gastos
{
    public interface IConceptoRepository
    {
        Task<List<Procedimiento>> ExecuteProcedureConcept(string folio);

        IEnumerable<Concepts> GetAll();

        Task<Concepts> GetById(Guid id);

        Task Add(Concepts concepts);

        void Update(Concepts concepts);

        Task Delete(Guid id);
    }
}