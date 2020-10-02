using System;
using System.IO;

namespace МНОГОМЕРНЫЕ_МАССИВЫ
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
            
            // Инициализация и вывод исходной матрицы
            Console.WriteLine("   Исходная матрица: ");
            int[,] mas = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                String str_all = Console.ReadLine();
                string[] str_elem = str_all.Split(' ');
                for (int j = 0; j < M; j++)
                {
                    mas[i, j] = Convert.ToInt32(str_elem[j]);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Вывод среднего арифметического для каждой строки
            Console.WriteLine("Среднее арифметическое элементов в каждой строке матрицы: ");
            float sa_str = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    sa_str += mas[i, j];
                }
                Console.WriteLine(sa_str /= M);
                sa_str = 0;
            }
            Console.WriteLine();

            // Вывод среднего арифметического нечетных элементов для каждого столбца
            Console.WriteLine("Среднее арифметическое элементов в каждом столбце матрицы: ");
            float sa_stolb = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    sa_stolb += mas[j, i];
                }
                Console.Write("\t", sa_stolb /= N);
                sa_stolb = 0;
            }


            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}