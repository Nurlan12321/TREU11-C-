using System;

namespace TREU11
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0, B = 0, C = 0;
            nano:

            try
            {
                Console.WriteLine("Введите стороны треугольника (Целst числа)");
                A = Convert.ToInt32(Console.ReadLine());
                B = Convert.ToInt32(Console.ReadLine());
                C = Convert.ToInt32(Console.ReadLine());


                if (A <= 0 || B <= 0 || C <= 0) Console.WriteLine("Необходимо вводить положительные целые числа");
            }

            catch
            {
                Console.WriteLine("Необходимо вводить целые числа ");
                Console.ReadKey();
            }
            if ((A + B <= C) || (A + C <= B) || (B + C <= A))
            {
                Console.WriteLine("Треугольник не существует");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Треугольник существует");
                Console.ReadKey();
            }
            goto nano;
        }
    }
}