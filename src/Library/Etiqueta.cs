namespace Library
{
    public class Etiqueta
    {
        private string nombre;

        public Etiqueta(string nombre)
        {
            this.nombre = nombre;
        }

        public string ObtenerNombre()
        {
            return nombre;
        }
    }
}