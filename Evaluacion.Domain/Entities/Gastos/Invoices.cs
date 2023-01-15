using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.Domain.Entities.Gastos
{
    public class Invoices
    {
        public int Id { get; set; }

        public int TravelsId { get; set; }

        public string Uuid { get; set; }

        public decimal Total { get; set; }

        public string Valid_Admin { get; set; }

        public virtual Travels Travels { get; set; } = null!;
    }
}