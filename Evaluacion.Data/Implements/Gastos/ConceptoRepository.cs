using Evaluacion.Data.Context;
using Evaluacion.Data.Interfaces.Gastos;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Evaluacion.Domain.Entities.Gastos;

namespace Evaluacion.Data.Implements.Gastos
{
    public class ConceptoRepository : IConceptoRepository
    {
        private readonly EvaluacionContext _context;
        protected readonly DbSet<Concepts> _entities;


        public ConceptoRepository(
            EvaluacionContext context
            )
        {
            _context = context;
            _entities = context.Set<Concepts>();
        }

        public async Task<List<Procedimiento>> ExecuteProcedureConcept(string folio)
        {
            var param = new object[] {
                        new SqlParameter() {
                            ParameterName = "@Folio",
                            SqlDbType =  System.Data.SqlDbType.NVarChar,
                            Size = 255,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = folio
                        }};

            var procedimiento = _context.Procedimiento.FromSqlRaw("EXEC PROCEDURE_CONCEPTO @Folio", param).ToList();

            return procedimiento;
        }

        public IEnumerable<Concepts> GetAll()
        {
            return _entities.AsEnumerable();

        }

        public async Task<Concepts> GetById(Guid id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task Add(Concepts eventoScaneo)
        {
            await _entities.AddAsync(eventoScaneo);
        }

        public void Update(Concepts eventoScaneo)
        {
            _context.Update(eventoScaneo);
        }

        public async Task Delete(Guid id)
        {
            Concepts t = await GetById(id);
            _context.Remove(t);
        }
    }
}