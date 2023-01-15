using Evaluacion.Data.Context;
using Evaluacion.Data.Implements.Gastos;
using Evaluacion.Data.Interfaces.Common;
using Evaluacion.Data.Interfaces.Gastos;

namespace Evaluacion.Data.Implements.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EvaluacionContext _context;
        private readonly IConceptoRepository _conceptoRepository;

        public UnitOfWork(
            EvaluacionContext context
            )
        {
            _context = context;
        }

        public IConceptoRepository ConceptoRepository => _conceptoRepository ?? new ConceptoRepository(_context);

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }       
    }
}