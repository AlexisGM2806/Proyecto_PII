using System;
using System.Collections.Generic;
namespace Library
{
    public class Vendedor : IUsuario
    {
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Vendedor(bool activo, DateTime fechaCreacion)
        {
            Activo = activo;
            FechaCreacion = fechaCreacion;
        }
        public List<Cliente> getClientesAsignados()
        {
            return new List<Cliente>();
        }
    }

}