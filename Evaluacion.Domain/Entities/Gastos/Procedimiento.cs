using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.Domain.Entities.Gastos
{
    public class Procedimiento
    {
        public string Concepto { get; set; }

        public decimal Domingo { get; set; }

        public decimal Lunes { get; set; }
              
        public decimal Martes { get; set; }
              
        public decimal Miercoles { get; set; }
            
        public decimal Jueves { get; set; }
           
        public decimal Viernes { get; set; }
             
        public decimal Sabado { get; set; }
           
        public decimal Total { get; set; }
    }
}