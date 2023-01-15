using Evaluacion.Domain.Entities.Gastos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.Services.Interfaces.Gastos
{
    public interface IConceptoService
    {
        Task<List<Procedimiento>> ExecuteProcedureConcept(string folio);
    }
}