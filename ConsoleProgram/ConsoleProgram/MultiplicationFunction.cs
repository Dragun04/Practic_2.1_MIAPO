using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    public class MultiplicationFunction
    {
        public static void Multiplication()
        {
            double a = 0;
            double b = 0;

            Console.WriteLine("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Результат умножения {a} на {b} равняется: {a * b}");
        }
    }
}
