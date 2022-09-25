using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases.AlquilerPuerto
{
    class Puerto
    {
        public void funcionamiento()
        {
            Velero velero = new Velero(2, "1", 2020, 10);
            Alquiler alquiler = new Alquiler("Elena Jiménez", "05722540W", new DateTime(2022, 09, 1), new DateTime(2022, 09, 5), "posicion", velero);
            Console.WriteLine(alquiler);
            Console.WriteLine("Presione una tecla para continuar. ");
            Console.ReadKey();
            Console.WriteLine("\n\n");

            EmbDeportiva embDeportiva = new EmbDeportiva(100, "2", 1999, 12);
            Alquiler alquiler2 = new Alquiler("Elena Jiménez", "05722540W", new DateTime(2022, 09, 15), new DateTime(2022, 10, 2), "posicion", embDeportiva);
            Console.WriteLine(alquiler2);
            Console.WriteLine("Presione una tecla para continuar. ");
            Console.ReadKey();
            Console.WriteLine("\n\n");

            Yate yate = new Yate("3", 2005, 8, 75, 3);
            Alquiler alquiler3 = new Alquiler("Elena Jiménez", "05722540W", new DateTime(2022, 08, 12), new DateTime(2022, 9, 2), "posicion", yate);
            Console.WriteLine(alquiler3);
            Console.WriteLine("Presione una tecla para continuar. ");
            Console.ReadKey();
            Console.WriteLine("\n\n");
        }
    }
}
