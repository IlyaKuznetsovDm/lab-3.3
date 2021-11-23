using System;

namespace lab_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Введите n:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите x:");
                double x = double.Parse(Console.ReadLine());
                double S = 0;
                for (int i = 1; i <= n; i++)
                {
                    long F = 1;
                    for (int j = 1; j < 2 * i - 1; j++) F *= j;
                    S += Math.Sin((2 * i - 1) * Math.Pow(x, 2 * i - 1)) / F;
                }
                Console.WriteLine("S={0:F2}", S);
            }
            catch (Exception)
            {
                Console.WriteLine("Введите корректно переменную");
            }
        }
    }
}


