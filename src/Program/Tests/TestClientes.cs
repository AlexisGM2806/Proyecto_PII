using System;
using System.Collections.Generic;
using Library;

namespace Program.Tests
{
    public static class TestClientes
    {
        public static void Run()
        {
            Console.WriteLine("== TestClientes ==");

            Cliente cliente = new Cliente(
                "Juan", 
                "Pérez", 
                "099123456", 
                "juan@correo.com", 
                "Cliente regular", 
                "Masculino", 
                DateTime.Now.AddYears(-30), 
                DateTime.Now.AddDays(-10)
            );

            bool inactivo = cliente.esInactivo("5");
            Console.WriteLine(inactivo 
                ? "Cliente correctamente marcado como inactivo (más de 5 días sin interacción)." 
                : "Error: debería ser inactivo.");

            Etiqueta etiqueta = new Etiqueta("VIP");
            cliente.agregarEtiqueta(etiqueta);
            Console.WriteLine("agregarEtiqueta ejecutado sin errores.");

            // Usamos el constructor con parámetros
            Vendedor vendedor = new Vendedor(true, DateTime.Now);
            cliente.asignarAVendedor(vendedor);
            Console.WriteLine("asignarAVendedor ejecutado sin errores.");

            Console.WriteLine();
        }
    }
}