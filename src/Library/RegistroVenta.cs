using System;
using System.Collections.Generic;
namespace Library
{
    public class RegistroVenta
    {
        private List<Venta> ventas;

        public RegistroVenta(List<Venta> ventas)
        {
            this.ventas = ventas ?? new List<Venta>();
        }

        public List<Venta> getVentasEntre(DateTime desde, DateTime hasta)
        {
            List<Venta> resultado = new List<Venta>();
            foreach (var v in ventas)
            {
                if (v.Fecha >= desde && v.Fecha <= hasta)
                {
                    resultado.Add(v);
                }
            }
            return resultado;
        }
    }
}