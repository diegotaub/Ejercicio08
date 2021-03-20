using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una frase: ");
            if (Console.ReadLine().Contains("fin"))
            {
                Console.Write("La frase contiene la palabra 'fin'");
            }
            else
            {
                Console.Write("La frase no contiene la palabra 'fin'");
            }
            Console.ReadKey();
        }
    }
}
