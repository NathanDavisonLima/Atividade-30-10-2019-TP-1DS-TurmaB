using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            double num, soma = 0, media;

            while (cont <= 10)
            {
                Console.WriteLine("Digite o {0} número: ", cont);
                num = double.Parse(Console.ReadLine());

                soma += num; // ==  soma = soma + num

                cont++;
            }

            media = soma / 10;

            Console.WriteLine("A soma dos números é de {0:N}", soma);
            Console.WriteLine("A média da soma dos números é de {0:N}", media);

            Console.ReadKey();




        }
    }
}
