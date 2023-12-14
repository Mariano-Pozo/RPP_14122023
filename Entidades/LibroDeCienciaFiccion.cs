namespace Entidades
{
    public enum ENivelDificultad { Baja, Media, Alta }
    public class LibroDeCienciaFiccion : Libro
    {
        private ENivelDificultad nivelDificultad;

        protected new string AdicionarInformacion()
        {
            string informacionBase = base.AdicionarInformacion();
            string informacionNivel = string.Format("Nivel de dificultad: {0}", nivelDificultad);
            return string.Format("{0}\n{1}", informacionBase, informacionNivel);
        }

        public override void Clasificar()
        {
            switch (nivelDificultad)
            {
                case ENivelDificultad.Baja:
                    clasificacion = EClasificacion.Todos;
                    break;
                case ENivelDificultad.Media:
                    clasificacion = EClasificacion.Adolecentes;
                    break;
                case ENivelDificultad.Alta:
                    clasificacion = EClasificacion.Adultos;
                    break;
                default:
                    // Manejar el caso por defecto si es necesario
                    break;
            }
        }
        public LibroDeCienciaFiccion (string nombre, ENivelDificultad nivelDificultad) : base(nombre) 
        {
            this.nivelDificultad = nivelDificultad;
            
        }
    }
}