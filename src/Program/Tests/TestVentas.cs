using System;
using Library;

namespace Program.Tests
{
    public static class TestVentas
    {
        public static void Run()
        {
            Console.WriteLine("== TestVentas ==");

            double total = 1500.50;
            DateTime fecha = DateTime.Now.AddDays(-3);
            Venta venta = new Venta(total, fecha);

            if (venta.Total == total && venta.Fecha == fecha)
                Console.WriteLine("✅ Constructor y propiedades funcionan correctamente.");
            else
                Console.WriteLine("❌ Error en la inicialización de Venta.");

            double resultado = venta.getTotales("criterio1", "criterio2");
            Console.WriteLine(resultado == total 
                ? "✅ getTotales devuelve el total correctamente." 
                : "❌ Error en getTotales.");

            Console.WriteLine();
        }
    }
}