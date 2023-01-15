using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.Domain.Entities.Gastos
{

    public class Invoicedetail
    {
        public int? Id { get; set; } = null;

        public string Dia_Gasto { get; set; }

        public int? ConceptsId { get; set; } = null;

        public int? InvoicesId { get; set; } = null;

        public virtual Concepts? Concepts { get; set; } = null!;

        public virtual Invoices? Invoices { get; set; } = null!;
    }
}