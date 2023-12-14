using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LibroDeHistorietas :Libro
    {
        private bool ilustracionesColoridas;

        protected new string AdicionarInformacion()
        {
            string informacionBase = base.AdicionarInformacion();
            string tipoEdicion = ilustracionesColoridas ? "Edicion Rayo Cromatico" : "Edicion Maestro MonoCromo";
            return string.Format("{0}\nTipo de edición: {1}", informacionBase, tipoEdicion);
        }
        public override void Clasificar()
        {
            clasificacion = EClasificacion.Todos; // Por defecto, todas las historietas tendrán clasificación Todos
        }
        public LibroDeHistorietas(string nombre, bool ilustracionesColoridas) : base(nombre,true)
        {
            this.ilustracionesColoridas = ilustracionesColoridas;
        }
    }
}
