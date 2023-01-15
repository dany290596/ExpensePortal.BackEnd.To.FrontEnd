namespace Evaluacion.Models.Response.Gastos
{
    public class ProcedimientoDTO
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