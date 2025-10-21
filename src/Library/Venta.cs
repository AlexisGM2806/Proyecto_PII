using System;
namespace Library
{
    public class Venta
    {
        public double Total { get; private set; }

        public DateTime Fecha { get; private set; }

        public Venta(double total, DateTime fecha)
        {
            Total = total;
            Fecha = fecha;
        }

        // + getTotales(String, String): Double
        public double getTotales(string criterio1, string criterio2)
        {
            return Total;
        }
    }
}