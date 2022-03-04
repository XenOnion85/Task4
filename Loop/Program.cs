using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());

            //Console.Write("\nwline: \t \t");
            //int i = 1;
            //while (i <= n)
            //{
            //    Console.Write(" " + i);
            //    i += 2;
            //}
            //Console.Write("\ndo wline: \t \t");
            //i = 1;
            //do
            //{
            //    Console.Write(" " + i);
            //    i += 2;
            //}
            //while (i <= n);
            //Console.Write("\nfor: \t \t");
            //for (i = 1; i <= n; i += 2)
            //{
            //    Console.Write(" " + i);
            //}

            //Console.WriteLine("Введите начальное значение: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите конечное значение: ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("-------------------");
            //Console.WriteLine("|   x   | sin(x)  |");
            //Console.WriteLine("-------------------");
            //double x = x1;
            //do
            //{
            //    x = Math.Round(x, 2);
            //    double y = Math.Round(Math.Sin(x), 2);
            //    Console.WriteLine("| {0:0.00}  |  {1:1.00}  |", x, y);
            //    x = x + 0.01;

            //}
            //while (x <= x2);
            //Console.WriteLine("-------------------");

            //Console.WriteLine("Введите a:");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите b:");
            //int b = int.Parse(Console.ReadLine());
            //int temp = a;
            //while (temp != b)
            //{
            //    a = temp;
            //    if (a < b)
            //    {
            //         temp = a;
            //         a = b;
            //         b = temp;
            //    }
            //    temp = a - b;
            //    a = b;
            //}
            //Console.WriteLine("Наименьший общий делитель: ", temp);

            int[] myArray = { 100, 1, 32, 3, 14, 25, 6, 17, 8, 99 };
            Console.Write("Заданный массив: ");
            for (int i = 0; i <= 9; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine("");
            Console.Write("Элементы нового массива: ");
            for (int i = 0; i <= 9; i++)
            {
                if (myArray[i] % 2 == 0) myArray[i] = 0;
                Console.Write(myArray[i] + " ");
            }
        }
    }
}
