using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LibroDeMisterio : Libro
    {
        private static readonly Random random = new Random();
        public override void Clasificar()
        {
            int randomNumber = random.Next(0, 2);

            if (randomNumber == 0)
            {
                clasificacion = EClasificacion.Adolecentes;
            }
            else
            {
                clasificacion = EClasificacion.Adultos;
            }
        }
        public LibroDeMisterio(string nombre, bool edicionEspecial): base(nombre,edicionEspecial) { }
    }
}
