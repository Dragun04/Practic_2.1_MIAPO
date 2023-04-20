using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    public class DivisionFuncion
    {
        public static void Divisin()
        {
            double a = 0;
            double c = 0;
            
            Console.WriteLine("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Результат деления {a} на {c} равняется: {a / c}");
        }
    }
}