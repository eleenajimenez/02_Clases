
using _02_Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        bool valido;
        Biblioteca b= new Biblioteca();
        ManejarFechas mf = new ManejarFechas();


        do
        {
            do
            {
                Console.WriteLine("¿Qué ejercicio quieres ejecutar?: \n" +

                "1. Manejar fechas. \n" +
                "2. Clase libros. \n" +
                "3. Alquiler puerto. \n" +
                "4. Salir.");
                valido = int.TryParse(Console.ReadLine(), out opcion);
                if(opcion >= 5) valido = false;
                if (!valido) Console.WriteLine("Introduzca una opcion valida");
            }while(!valido);
            Console.WriteLine("\n");
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ha elegido manejar fechas.");
                    mf.menu();
                    break;
                case 2:
                    Console.WriteLine("Ha elegido clase libros.");
                    b.menu();
                    break;
                case 3:
                    Console.WriteLine("Ha elegido alquiler puerto.");
                    //alquilerPuerto();
                    break;
                case 4:
                    Console.WriteLine("Hasta pronto!");
                    break;
            }
        }while(opcion!=4);

    }

    
    }