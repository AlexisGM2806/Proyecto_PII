using System;
using System.Collections.Generic;
namespace Library
{
    public class Administrador : IUsuario
    {
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Administrador(bool activo, DateTime fechaCreacion)
        {
            Activo = activo;
            FechaCreacion = fechaCreacion;
        }
        
        public Usuario crearUsuario(string nombre, string apellido, string email)
        {
            return new Usuario(true, DateTime.Now);
        }
        
        public void suspenderUsuario(Usuario usuario)
        {
            if (usuario != null)
            {
                usuario.Activo = false;
            }
        }
        
        public void eliminarUsuario(Usuario usuario)
        {

        }
    }
}