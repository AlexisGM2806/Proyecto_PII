using System;
namespace Library
{
    public class Usuario : IUsuario
    {
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Usuario(bool activo, DateTime fechaCreacion)
        {
            Activo = activo;
            FechaCreacion = fechaCreacion;
        }
    }
}