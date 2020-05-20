using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolacja_lagranga
{
    class Program
    {

        public static void Main(String[] args)
        {
            Console.WriteLine("Number of points:");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] xData = new double[n];
            double[] yData = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x " + i + ": ");
                xData[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("y " + i + ": ");
                yData[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Szukany y: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Value of f {x} is :" +GetY(xData, yData, x));
            Console.ReadKey();
        }

        static double GetY(double[] xData, double[] yData, double x)
        {
            double result = 0;
            for (int i = 0; i < xData.Length; i++)
            {
                result += L(xData, x, i) * yData[i];
            }
            return result;
        }

        static double L(double[] xData, double x, int i)
        {
            double a = 1;
            double b = 1;
            for (int j = 0; j < xData.Length; j++)
            {
                if (j == i) continue;
                a *= x - xData[j];
                b *= xData[i] - xData[j];
            }
            return a / b;
        }
    }
}
