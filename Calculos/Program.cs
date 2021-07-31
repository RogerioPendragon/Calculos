using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de z: ");
            double z = Convert.ToDouble(Console.ReadLine());
            double result = (x + y + z + (5 * 77) + 8 - (10 * (8 / 3)));
            Console.WriteLine("O resultado da expresssão: x + y + d + 5 * 77 + 8 -10 *( 8/3) é: " + result);
            Console.ReadLine();
        }
    }
}
