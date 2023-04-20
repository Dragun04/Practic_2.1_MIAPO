using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    public class ExponentiationFunction
    {
        public static void Exponentiation()
        {
            double a = 0;
            double b = 0;
            double c = 1;

            Console.WriteLine("Введите число: ");
            a = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Введите степень: ");
            b = Convert.ToDouble(Console.ReadLine());

            for(int i = 0; i < b; i++)
            {
                c *= a;
            }

            Console.WriteLine($"Результат возведения числа {a} в степень {b} равняется: {c}");
        }
    }
}
