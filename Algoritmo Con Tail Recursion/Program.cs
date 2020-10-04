using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algoritmo_Con_Tail_Recursion
{
    public class RecursividadFactorial
    {
        int Factorial (int fact)
        {
            if (fact >0)
            {
                int valor = fact * Factorial(fact - 1);
                return valor;
            }
            else
                return 1;
        }
        
   
        static void Main(string[] args)
        {
            RecursividadFactorial re = new RecursividadFactorial();
            int f=re.Factorial(4);
            Console.WriteLine(f);
            Console.ReadKey();
        }

       /* public class Recursividad
         {

        void Imprimir(int x)
        {
            if (x > 0)
            {
                Imprimir(x - 1);
                Console.WriteLine(x);
            }
        }

        static void Main(string[] args)
        {
            Recursividad re = new Recursividad();
            re.Imprimir(5);
            Console.ReadKey();
        }
        */


    }
}
