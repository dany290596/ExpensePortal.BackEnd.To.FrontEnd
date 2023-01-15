using Evaluacion.Data.Interfaces.Gastos;

namespace Evaluacion.Data.Interfaces.Common
{
    public interface IUnitOfWork : IDisposable
    {
        IConceptoRepository ConceptoRepository { get; }

        void SaveChanges();

        Task SaveChangesAsync();       
    }
}