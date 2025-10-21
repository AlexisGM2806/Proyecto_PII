using System;
using System.Collections.Generic;
using Library;
using Program.Tests;

namespace ProyectoCRM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Administrador admin = new Administrador(true, DateTime.Now);
            Vendedor vendedor = new Vendedor(true, DateTime.Now);

            Cliente cliente = new Cliente(
                "Juan", "Pérez", "099123456", "juan@example.com",
                "Cliente frecuente", "Masculino",
                new DateTime(1990, 5, 20), DateTime.Now.AddDays(-10)
            );
            cliente.asignarAVendedor(vendedor);
            Console.WriteLine("Vendedor asignado al cliente.");

            Etiqueta etiquetaVIP = new Etiqueta("VIP");
            cliente.agregarEtiqueta(etiquetaVIP);
            Console.WriteLine($"Etiqueta agregada: {etiquetaVIP.ObtenerNombre()}");

            bool inactivo = cliente.esInactivo("5");
            Console.WriteLine($"¿Cliente inactivo hace más de 5 días?: {inactivo}");

            Venta venta = new Venta(1200.50, DateTime.Now.AddDays(-2));
            RegistroVenta registro = new RegistroVenta(new List<Venta> { venta });

            var ventas = registro.getVentasEntre(DateTime.Now.AddDays(-10), DateTime.Now);
            Console.WriteLine($"Ventas registradas en los últimos 10 días: {ventas.Count}");

            Console.WriteLine("\n=== Ejecución Tests ===");
            TestClientes.Run();
            TestVentas.Run();
            TestRegistroVenta.Run();
            Console.WriteLine("=== Tests finalizados ===");
        }
    }
}