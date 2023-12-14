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

        private Biblioteca(string nombre)
        {
            this.nombre = nombre;
            libros = new List<Libro>();
        }

        public static string DetallarBiblioteca(Biblioteca biblioteca)
        {
            StringBuilder detalles = new StringBuilder();
            detalles.AppendLine($"Nombre de la biblioteca: {biblioteca.nombre}");
            detalles.AppendLine("Listado de libros:");

            foreach (Libro libro in biblioteca.Libros)
            {
                detalles.AppendLine(libro.Detalle);
            }

            return detalles.ToString();
        }

        public static explicit operator Biblioteca(string nombre)
        {
            return new Biblioteca(nombre);
        }

        public static bool operator ==(Biblioteca biblioteca, Libro libro)
        {
            return biblioteca.Libros.Contains(libro);
        }

        public static bool operator !=(Biblioteca biblioteca, Libro libro)
        {
            return !(biblioteca == libro);
        }

        public static Biblioteca operator +(Biblioteca biblioteca, Libro libro)
        {
            if (!biblioteca.Libros.Contains(libro))
            {
                biblioteca.libros.Add(libro);
            }
            return biblioteca;
        }

        public static Biblioteca operator -(Biblioteca biblioteca, Libro libro)
        {
            biblioteca.libros.Remove(libro);
            return biblioteca;
        }
    }
}