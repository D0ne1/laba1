using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число X");
            string inputX;
            bool IsXCorrect;
            string inputY;
            bool IsYCorrect;
            do
            {
                inputX = Console.ReadLine();
                IsXCorrect = double.TryParse(inputX, out double X);
                if (!IsXCorrect)
                {
                    Console.WriteLine("Пожалуйста, введите число");
                }
                else
                {
                    Console.WriteLine("Введите число Y");
                    do
                    {
                        inputY = Console.ReadLine();
                        IsYCorrect = double.TryParse(inputY, out double Y);
                        if (!IsYCorrect)
                        {
                            Console.WriteLine("Пожалуйста, введите число");
                        }
                        else
                        {
                            if (X >= -7 && X <= 0 && Y <= 0 && Y >= -2)
                            {
                                Console.WriteLine("Точка попадает в указанную область");
                            }
                            else Console.WriteLine("Точка не попадает в указанную область");
                        }
                    } while (!IsYCorrect);
                }
            } while (!IsXCorrect);
        }
    }
}
