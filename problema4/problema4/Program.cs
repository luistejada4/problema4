using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca otro numero: ");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = n1 - n2;

            if(resultado < 0)
            Console.WriteLine("({0})", resultado);
       
            else
            Console.WriteLine("{0}", resultado);

            Console.ReadKey();
        }
    }
}
