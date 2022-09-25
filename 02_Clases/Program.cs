
using _02_Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        
        bool salir = false;
        int opcion = 0;
        Biblioteca b= new Biblioteca();


        while (!salir)
        {
            Console.WriteLine("¿Qué ejercicio quieres ejecutar?: \n" +

                "1. Manejar fechas. \n" +
                "2. Clase libros. \n" +
                "3. Alquiler puerto. \n" +
                "4. Salir.");
            opcion = Console.Read();
            switch (opcion)
            {
                case 1:
                    //manejarFechas();
                    break;
                case 2:
                    claseLibros(b);
                    break;
                case 3:
                    //alquilerPuerto();
                    break;
                case 4:
                    salir = true;
                    break;
            }


        }

    }

    private static void claseLibros(Biblioteca b)
    {
        b.insertarLibros();
        b.mostrarLibros();
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