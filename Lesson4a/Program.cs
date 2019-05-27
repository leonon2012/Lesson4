using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<< Task3 >>");
            Task3(10000);
            Console.WriteLine("<< Task4 >>");
            Task4();
        }

        // Совершенные числа
        static void Task3(int N)
        {
            int sum;

            // Цикл по всем числам до N
            for (int i = 1; i < N; i++)
            {
                // Начальное значение суммы делителей
                sum = 0;

                // Цикл по делителям
                for (int y = 1; y <= i / 2 + 1; y++)
                {
                    if (i % y == 0)
                        sum += y;
                }

                // Если суммы равны - искомое число
                if (sum == i)
                    Console.WriteLine(i);
            }
        }

        // Натуральные числа со свойствами
        static void Task4()
        {
            bool find;

            // Цикл по всем числам до 100
            for (int i = 1; i < 100; i++)
            {
                find = true;

                // Цикл по делителям
                for (int y = 1; y <= 4; y++)
                {
                    find &= i % (y + 2) == y;
                }

                if (find)
                    Console.WriteLine(i);
            }
        }
    }
}
