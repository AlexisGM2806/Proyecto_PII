using System;
namespace Library
{
    public class Cotizacion
    {
        private string estado;

        private DateTime fechaEnvio;

        private double importeTotal;

        public Cotizacion(string estado, DateTime fechaEnvio, double importeTotal)
        {
            this.estado = estado;
            this.fechaEnvio = fechaEnvio;
            this.importeTotal = importeTotal;
        }
    }
}