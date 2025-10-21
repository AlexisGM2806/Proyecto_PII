using System;
namespace Library
{
    public class Llamada : Interaccion
    {
        private string duracion;

        public Llamada(DateTime fecha, string descripcion, string notas, bool respondida, string direccion, string duracion)
            : base(fecha, descripcion, notas, respondida, direccion)
        {
            this.duracion = duracion;
        }
    }
}