
using _02_Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        bool valido;
        Biblioteca b= new Biblioteca();


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
                    //manejarFechas();
                    break;
                case 2:
                    Console.WriteLine("Ha elegido clase libros.");
                    //claseLibros(b);
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



    /*public void manejarFechas(int opcion)
{
   bool salir = false;
   int anio, mes, dia;
   int num;
   DateTime fecha1 = new DateTime(2022, 07, 22);
   DateTime fecha2 = new DateTime(2022, 09, 21);
   while (!salir)
   {
       Console.WriteLine("Elige opción: " +
           "1. Que día de la semana es." +
           "2. Incrementar días y fecha corta." +
           "3. Alquiler puerto." +
           "4. Salir.");

       opcion = Console.Read();
       switch (opcion)
       {
           case 1:
               Console.WriteLine("El dia de la semana es: " + fecha1.DayOfWeek);
               break;
           case 2:
               Console.WriteLine("Cuantos días quieres incrementar?: ");
               num = Console.Read();
               Console.WriteLine("La nueva fecha es: " + fecha1.AddDays(num));
               break;
           case 3:
               Console.WriteLine("La nueva fecha es: " + Subtraction(fecha1, fecha2);
               break;
           case 4:
               salir = true;
               break;
       }
   }*/

    
    }