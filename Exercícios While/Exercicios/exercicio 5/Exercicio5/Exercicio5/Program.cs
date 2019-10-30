using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 85;
            int soma_par = 0;

            while (cont <= 907)
            {
                if (cont % 2 == 0)
                {
                    Console.WriteLine(cont);
                    soma_par += cont;
                }
                cont++;
            }
            Console.WriteLine("Soma de par é: " + soma_par);
           
            Console.ReadKey();



        }
    }
}
