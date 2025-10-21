using System;
namespace Library
{
    public class Mensaje : Interaccion
    {
        private string medio;

        public Mensaje(DateTime fecha, string descripcion, string notas, bool respondida, string direccion, string medio)
            : base(fecha, descripcion, notas, respondida, direccion)
        {
            this.medio = medio;
        }
    }
}