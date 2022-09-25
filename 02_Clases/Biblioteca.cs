using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    internal class Biblioteca
    {
        Libro l;
        ArrayList libros = new ArrayList();
        String titulo, autor, estilo, editorial;

        public string pedirTeclado()
        {
            String texto;
            texto = Console.ReadLine();
            return texto;
        }

        public void insertarLibros()
        {
            Console.WriteLine("Introduce el titulo: ");
            titulo = pedirTeclado();
            Console.WriteLine("Autor: ");
            autor = pedirTeclado();
            Console.WriteLine("Estilo: ");
            estilo = pedirTeclado();
            Console.WriteLine("Editorial: ");
            editorial = pedirTeclado();
            l= new Libro(titulo,autor,estilo,editorial);
            libros.Add(l);
        }

        

        public void mostrarLibros()
        {
            for (int i = 0; i < libros.Count; i++)
            {
                Console.WriteLine(libros[i]);
            }
        }

        public void modificarLibro()
        {

        }

        public void eliminarLibro()
        {

        }
    }
}
