using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    class Biblioteca
    {
        Libro l;
        ArrayList libros = new ArrayList();
        bool valido;
        int opcion;
        String titulo, autor, estilo, editorial;

        public void menu()
        {
            do
            {
                do
                {
                    Console.WriteLine("¿Qué quieres realizar?: \n" +

                    "1. Insertar libro. \n" +
                    "2. Ver listado de libros. \n" +
                    "3. Modificar libro. \n" +
                    "4. Eliminar libro. \n" +
                    "5. volver al menú principal.");

                    valido = int.TryParse(Console.ReadLine(), out opcion);
                    if (opcion >= 6) valido = false;
                    if (!valido) Console.WriteLine("Introduzca una opcion valida");
                } while (!valido);
                Console.WriteLine("\n");
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ha elegido añadir libro.");
                        insertarLibros();
                        break;
                    case 2:
                        Console.WriteLine("Ha elegido ver el listado de libros.");
                        mostrarLibros();
                        break;
                    case 3:
                        Console.WriteLine("Ha elegido modificar un libro.");
                        modificarLibro();
                        break;
                    case 4:
                        Console.WriteLine("Ha elegido eliminar un libro.");
                        eliminarLibro();
                        break;
                    case 5:
                        Console.WriteLine("Volviendo al menú principal!");
                        break;
                }
            } while (opcion != 5);
        }



        public string pedirTeclado()
        {
            String texto;
            texto = Console.ReadLine();
            return texto;
        }

        public Libro insertarLibros()
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
            return l;
        }

        

        public void mostrarLibros()
        {
            Console.WriteLine("Libros en la biblioteca: ");
            for (int i = 0; i < libros.Count; i++)
            {
                Console.WriteLine(i + ": " + libros[i]);
            }
        }

        public void modificarLibro()
        {
            Console.WriteLine("Elige el libro que quieres modificar: ");
            mostrarLibros();
            int numero;
            do
            {
                valido= int.TryParse(Console.ReadLine(), out numero);
                if (numero > libros.Count - 1) valido = false;
                if (!valido) Console.WriteLine("");
            }while (!valido);
            Libro l1= insertarLibros();
            libros[numero] = l1;
            

        }

        public void eliminarLibro()
        {
            mostrarLibros();
            Console.WriteLine("Elige el libro que quieres eliminar:" );
            int numero;
            valido= int.TryParse(Console.ReadLine(), out numero);
            for(int i = 0; i < libros.Count; i++)
            {
                if (i == numero)
                {
                    libros.RemoveAt(numero);
                    Console.WriteLine("Libro eliminado con exito.");
                }
                
            }

        }
    }
}
