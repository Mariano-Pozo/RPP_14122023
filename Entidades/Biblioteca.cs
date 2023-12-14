using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entidades
{
    public class Biblioteca
    {
        private List<Libro> libros;
        private string nombre;

        public List<Libro> Libros { get { return libros; } }

        private Biblioteca(string nombre) { }

        public string DetallarBiblioteca(Biblioteca biblioteca)
        {

        }

        public static explicit operator Biblioteca(string nombre)
        {
            // Lógica para convertir el string a un objeto Biblioteca
            return new Biblioteca(nombre);
        }
        public static bool operator ==(Biblioteca biblioteca, Libro libro)
        {

        }
        public static bool operator !=(Biblioteca biblioteca, Libro libro)
        {

        }
        public static Biblioteca operator +(Biblioteca biblioteca, Libro libro)
        {

        }
        public static Biblioteca operator -(Biblioteca biblioteca, Libro libro)
        {

        }
    }
}
