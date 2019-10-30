using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1, num;

            Console.WriteLine("Informe um número: ");
            num = int.Parse(Console.ReadLine());

            while (cont <= 10)
            {
                Console.WriteLine("{0} * {1} = {2}", num, cont, (num * cont));
                cont++;
            }

            Console.ReadKey();


        }
    }
}
