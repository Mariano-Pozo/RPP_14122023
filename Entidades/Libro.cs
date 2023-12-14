using System.Text;

namespace Entidades
{
    public enum EClasificacion { Todos, Adolecentes, Adultos }
    public abstract class Libro
    {
        protected EClasificacion clasificacion;
        private bool edicionEspecial;
        private string nombre;

        public string Detalle 
        {
            get
            {
                return AdicionarInformacion();
            }
        }
        public string Tipo
        {
            get
            {
                return this.GetType().Name;
            }
        }


        protected string AdicionarInformacion()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Nombre: {nombre}");
            informacion.AppendLine($"Tipo: {Tipo}");
            informacion.AppendLine($"Clasificación: {clasificacion}");
            informacion.AppendLine($"Edición especial: {(edicionEspecial ? "Sí" : "No")}");

            return informacion.ToString();

        }
        public abstract void Clasificar();

        protected Libro(string nombre) 
        {
            this.nombre = nombre;
        }
        protected Libro(string nombre, bool edicionEspecial) 
        {
            this.nombre = nombre;
            this.edicionEspecial = edicionEspecial;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, Tipo: {Tipo}";
        }

        public static bool operator ==(Libro libro1, Libro libro2)
        {
            if (object.ReferenceEquals(libro1, libro2))
            {
                return true;
            }

            if (libro1 is null || libro2 is null)
            {
                return false;
            }

            return libro1.GetType() == libro2.GetType()
                && libro1.nombre == libro2.nombre
                && libro1.clasificacion == libro2.clasificacion
                && libro1.edicionEspecial == true
                && libro2.edicionEspecial == true;
        }

        public static bool operator !=(Libro libro1, Libro libro2)
        {
            return !(libro1 == libro2);
        }
    }
}
