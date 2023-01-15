using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.Domain.Entities.Gastos
{
    public class Travels
    {
        public int Id { get; set; }

        public string Folio { get; set; }
    }
}