using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float aF = 1000;
            float bF = 0.0001f;
            float chislF = (float)((float)Math.Pow(aF - bF, 2) - ((float)Math.Pow(aF, 2) - 2 * aF * bF));
            float znamF = (float)Math.Pow(bF, 2);
            float resF = chislF / znamF;
            Console.WriteLine($"Результат с точностью до float: {resF}");

            double aD = 1000;
            double bD = 0.0001f;
            double chislD = (double)((double)Math.Pow(aD - bD, 2) - ((double)Math.Pow(aD, 2) - 2 * aD * bD));
            double znamD = (double)Math.Pow(bD, 2);
            double resD = chislD / znamD;
            Console.WriteLine($"Результат с точностью до double: {resD}");
        }
    }
}
