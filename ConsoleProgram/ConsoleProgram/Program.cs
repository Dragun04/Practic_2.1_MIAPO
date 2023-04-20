using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProgram;

namespace Practic_2_Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Введите число действия:" +
                "\n----------------" +
                "\n1. Hello" +
                "\n2. Деление" +
                "\n3. Умножение" +
                "\n4. Возведение в степень" +
                "\n----------------");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        HelloFunction.HelloDisplay();
                    }   
                    break;

                case 2:
                    {
                        DivisionFuncion.Divisin();
                    }
                    break;

                case 3:
                    {
                        MultiplicationFunction.Multiplication();
                    }
                    break;

                case 4:
                    {
                        ExponentiationFunction.Exponentiation();
                    }
                    break;

                default:
                {
                    Console.WriteLine("Действие отсутствует");
                }
                break;
            }
            
        }
    }
}