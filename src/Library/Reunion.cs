using System;
namespace Library
{
    public class Reunion : Interaccion
    {
        private string lugar;

        public Reunion(DateTime fecha, string descripcion, string notas, bool respondida, string direccion, string lugar)
            : base(fecha, descripcion, notas, respondida, direccion)
        {
            this.lugar = lugar;
        }

        public bool esProxima()
        {
            return Fecha > DateTime.Now;
        }
    }
}