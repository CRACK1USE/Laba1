using System;

namespace Laba_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            Console.WriteLine("Введите кол-во шаров:");
            n = Convert.ToInt32(Console.ReadLine());
            double r = 0;
            Console.WriteLine("Введите радиус:");
            r = Convert.ToDouble(Console.ReadLine());
            double V = 0;
            double sV;
            double R;
            for (int i = 0; i < n; i++)
            {
                R = r + 0.2 * i;
                V = V + 4 * Math.Pow(R, 3) * Math.PI / 3;
            }
            Console.WriteLine("Суммарный объём: " + V);
            sV = V / n;
            Console.WriteLine("Средний объём: " + sV);
            Console.ReadLine();
        }
    }
}