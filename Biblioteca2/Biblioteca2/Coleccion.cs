using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2
{
    public class COLECCION
    {
        public static void listcollection()
        {
            List<object > lst =  new List<object>();

            //captura los elementos parqa almacenar 
            var rs = "s";
         while (rs == "s ")
            {
                Console.Write("Escriba el elemento a agregar a  la lista");
                var element = Console.ReadLine();

                lst.Add(element);

                Console.WriteLine("\nDesea agregar otro elemento s/n ");
                rs = Console.ReadLine();

            }
            Console.WriteLine("--------------Elementos en la lista-----------");
            for (int i = 0; i < lst.Count;  i++)
            {
                Console.WriteLine(" {0}: {1}", i ,lst[i]);
            }
        }
    }
}
