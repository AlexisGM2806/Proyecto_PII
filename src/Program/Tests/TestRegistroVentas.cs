using System;
using System.Collections.Generic;
using Library;

namespace Program.Tests
{
    public static class TestRegistroVenta
    {
        public static void Run()
        {
            Console.WriteLine("== TestRegistroVenta ==");

            List<Venta> listaVentas = new List<Venta>();
            RegistroVenta registro = new RegistroVenta(listaVentas);

            Venta v1 = new Venta(1000, DateTime.Now.AddDays(-10));
            Venta v2 = new Venta(2000, DateTime.Now.AddDays(-5));
            Venta v3 = new Venta(3000, DateTime.Now);

            listaVentas.Add(v1);
            listaVentas.Add(v2);
            listaVentas.Add(v3);

            DateTime desde = DateTime.Now.AddDays(-7);
            DateTime hasta = DateTime.Now;
            List<Venta> resultado = registro.getVentasEntre(desde, hasta);

            if (resultado.Count == 2)
                Console.WriteLine("✅ getVentasEntre filtra correctamente por fechas.");
            else
                Console.WriteLine($"❌ Error: se esperaban 2 ventas y se obtuvieron {resultado.Count}.");

            Console.WriteLine();
        }
    }
}