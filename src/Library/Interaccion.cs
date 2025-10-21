using System;
namespace Library
{
    public abstract class Interaccion
    {
        public DateTime Fecha { get; set; }

        private string descripcion;

        private string notas;

        private bool respondida;

        private string direccion;

        protected Interaccion(DateTime fecha, string descripcion, string notas, bool respondida, string direccion)
        {
            Fecha = fecha;
            this.descripcion = descripcion;
            this.notas = notas;
            this.respondida = respondida;
            this.direccion = direccion;
        }

        public bool Respondida
        {
            get { return respondida; }
            set { respondida = value; }
        }

        public void agregarNota(string nota)
        {
            if (string.IsNullOrEmpty(nota))
                return;

            if (string.IsNullOrEmpty(notas))
                notas = nota;
            else
                notas += Environment.NewLine + nota;
        }
    }
}