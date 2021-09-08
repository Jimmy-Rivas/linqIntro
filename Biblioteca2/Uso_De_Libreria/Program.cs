using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca2;
namespace Uso_De_Libreria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("seleccione un elemento: ");
            Console.WriteLine("1 Crea una lista:");
            Console.WriteLine("2. Crea sortedlist:");
            var respose = Console.ReadLine();

            if (respose == "1" )
            {
                COLECCION.listcollection();
                Console.ReadKey();
            }
        }
    }
}
