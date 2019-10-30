using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            int soma_geral = 1;

            while (cont <= 15)
            {
                if (cont % 2 != 0)   // != 0 ser impar    // == 0 ser par
                {
                    soma_geral *= cont;
                    Console.WriteLine("A soma é ==> " + soma_geral);
                }
                cont++;
            }
            Console.WriteLine("A soma é ==> " + soma_geral);
            Console.ReadKey();
        }
    }
}
