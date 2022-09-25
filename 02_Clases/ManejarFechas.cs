using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    class ManejarFechas
    {
        DateTime fecha;
        bool valido;
        int opcion;
        int dia = 0;
        int mes = 0;
        int anio = 0;

        public void menu()
        {
            do
            {
                do
                {
                    Console.WriteLine("¿Qué quieres realizar?: \n" +

                        "1. Día Semana. \n" +
                        "2. Incrementar fecha. \n" +
                        "3. Diferencia fechas. \n" +
                        "4. Compara fechas. \n" +
                        "5. Mostrar Fecha formato largo. \n" +
                        "6. volver al menú principal.");

                    valido = int.TryParse(Console.ReadLine(), out opcion);
                    if (opcion >= 7) valido = false;
                    if (!valido) Console.WriteLine("Introduzca una opcion valida");
                } while (!valido); 
                Console.WriteLine("\n");

                
                switch (opcion)
                {
                    case 1:
                        fecha = introducirFecha();
                        diaSemana();
                        break;
                    case 2:
                        fecha = introducirFecha();
                        incrementarFecha();
                        break;
                    case 3:
                        fecha = introducirFecha();
                        diferenciaFechas();
                        break;
                    case 4:
                        fecha = introducirFecha();
                        comparaFechas();
                        break;
                    case 5:
                        fecha = introducirFecha();
                        mostrarFormatoLargo();
                        break;
                    case 6:
                        Console.WriteLine("Volviendo al menú principal!");
                        break;
                }
            } while (opcion != 6);





        }

        public DateTime introducirFecha()
        {
            do
            {
                Console.WriteLine("Introduzca el dia: ");
                valido = int.TryParse(Console.ReadLine(), out dia);
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dia > 31 || dia <= 0)
                    {
                        valido = false;
                    }
                }
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dia >= 31 || dia <= 0)
                    {
                        valido = false;
                    }
                }
                else
                {
                    if (dia > 28 || dia <= 0)
                    {
                        valido = false;
                    }
                }
                if (!valido) Console.WriteLine("Introduzca el dia otra vez");
            } while (!valido);

            do
            {
                Console.WriteLine("Introduzca el mes");
                valido = int.TryParse(Console.ReadLine(), out mes);
                if (mes > 12) valido = false;
                if (!valido) Console.WriteLine("Introduzca el mes otra vez");
            } while (!valido);

            do
            {
                Console.WriteLine("Introduzca el año");
                valido = int.TryParse(Console.ReadLine(), out anio);
                if (!valido) Console.WriteLine("Introduzca el año otra vez");
            } while (!valido);

            DateTime fecha = new DateTime(anio, mes, dia);

            return fecha;
        }

        public void diaSemana()
        { 
            Console.WriteLine("El dia de la semana es: " + fecha.ToString("dddd", new CultureInfo("es-ES")));
        }

        public void incrementarFecha()
        {
            int numDias;
            do
            {
                Console.WriteLine("Introduzca los dias que desea aumentar");
                valido = int.TryParse(Console.ReadLine(), out numDias);
                if (!valido) Console.WriteLine("Introduzca los dias que desea aumentar otra vez");
            } while (!valido);
            fecha = fecha.AddDays(numDias);
            Console.WriteLine("La nueva fecha es :" + fecha.ToString());
        }

        public void comparaFechas()
        {
            Console.WriteLine("Introduzca ahora la 2a fecha.");
            DateTime fecha1 = introducirFecha();
            int resultado = (DateTime.Compare(fecha, fecha1));
            if (resultado < 0)
            {
                Console.WriteLine("La mayor es: " + fecha1.ToString("d", CultureInfo.CreateSpecificCulture("en-NZ")));
            }
            else if (resultado > 0)
            {
                Console.WriteLine("La mayor es: " + fecha.ToString("d", CultureInfo.CreateSpecificCulture("en-NZ")));
            }
            else
            {
                Console.WriteLine("Las dos fechas son iguales...");
            }
        }

        public void diferenciaFechas()
        {
            int numeroDias;
            do
            {
                Console.WriteLine("Introduzca los dias que desea restar");
                valido = int.TryParse(Console.ReadLine(), out numeroDias);
                if (!valido) Console.WriteLine("Introduzca los dias que desea restar otra vez");
            } while (!valido);
            fecha = fecha.AddDays(-numeroDias);
            Console.WriteLine("La nueva fecha es :" + fecha.ToString());
        }


        public void mostrarFormatoLargo()
        {
            Console.WriteLine(fecha.ToString("D"), CultureInfo.CreateSpecificCulture("es-ES"));
        }



        
    }
}
