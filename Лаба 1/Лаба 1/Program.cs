using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            string inputN;
            bool IsNCorrect;
            string inputM;
            bool IsMCorrect;

            do
            {
                inputN = Console.ReadLine();
                IsNCorrect = double.TryParse(inputN, out double N);
                if (!IsNCorrect)
                {
                    Console.WriteLine("Пожалуйста, введите число");
                }
                else
                    Console.WriteLine("Введите число M");
                    do
                    {
                        inputM = Console.ReadLine();
                        IsMCorrect = double.TryParse(inputM, out double M);
                        if (!IsMCorrect)
                        {
                            Console.WriteLine("Пожалуйста, введите число");
                        }
                        else
                        {
                            Console.WriteLine("1) " + (++N * ++M));
                            Console.WriteLine("2) " + (M++ < N));
                            Console.WriteLine("3) " + (N++ > M));
                        }
                    } while (!IsMCorrect);

            } while (!IsNCorrect);

            Console.WriteLine();
            Console.WriteLine("Введите Х");
            string inputX;
            bool isXCorrect;
            do
            {
                inputX = Console.ReadLine();
                isXCorrect = double.TryParse(inputX, out double X);

                if (!isXCorrect)
                {
                    Console.WriteLine("Напишите число");
                }
                else

                if ((X * X * X - X) != 0)
                {
                    Console.WriteLine("4) " + (X + (1 / (X * X * X - X)) - 2));
                }
                else Console.WriteLine("Введите, пожалуйста, другое число, которое не даёт в знаменателе 0");
            } while (!isXCorrect);
        }
    }
}
