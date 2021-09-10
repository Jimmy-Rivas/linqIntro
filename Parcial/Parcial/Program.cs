using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int numero = 0;
                int adivinar = 0;
                int i = 0;
                int oportunidades = 3;
                Random rnd = new Random();
                char resp = '\0';

                Console.WriteLine("!!!!!!!!BIENVENIDO ADIVINA UN NÚMERO SECRETO ENTRE 0 y 10.!!!!!!!!");
                
                Console.WriteLine("=====TIENES 3 OPORTUNIDADES======");
                Console.WriteLine();
                do
                {
                    adivinar = (int)(rnd.Next(0, 10));
                    i = 0;
                    do
                    {
                        Console.Write("\n Número: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                        if (numero < adivinar)

                            Console.WriteLine("           !SUGERENCIA!:=Introduce un número mas grande.=");
                        else if (numero > adivinar)

                            Console.WriteLine("          !SUGERENCIA!:=Introduce un número mas pequeño.=");
                        else if (numero == adivinar)
                            Console.WriteLine("GENIAL ADIVINASTE,NO SERAS NOSTRADAMUS!!?? !!!!. Has Ganado");
                        i++;
                    }
                    while ((numero != adivinar) && (i < oportunidades));

                    if (numero != adivinar)
                        Console.WriteLine("BUUU NO ADIVINASTE. El número secreto era el " + adivinar);

                    Console.Write("\n¿QUIERES VOLVER A JUGAR? (si/no): ");
                    resp = (char)Console.Read();
                    Console.ReadLine(); 
                }
                while (resp == 's');
            
        }

        
    }
    
}
