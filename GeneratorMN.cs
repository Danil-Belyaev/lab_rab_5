using System;
using System.IO;

namespace GeneratorMN
{

    class GeneratorMN
    {
        static void Main(string[] args)
        {
            int N;
            int M;
            String FileName;

            Console.Write("Введите высоту матрицы  0<=N<=25 > ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ширину матрицы  0<=M<=25 > ");
            M = Convert.ToInt32(Console.ReadLine());


            Console.Write("Введите имя выходного файла без расширения > ");
            FileName = Console.ReadLine();
            FileName += ".txt";

            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter(FileName);
            Console.SetOut(new_out);

            Console.WriteLine(N);
            Console.WriteLine(M);

            Random r = new Random();
            int y = 0;
            for (int i = 0; i < N; i++)
            {
                    for (int j = 0; j < M; j++)
                    {
                        y = r.Next(-1000, 1000);
                        Console.Write(y + " ");
                    }
                    Console.WriteLine();
            }


            Console.SetOut(save_out); new_out.Close();
            Console.WriteLine("Файл " + FileName + " cоздан!!");
            Console.ReadKey();
        }
    }

}
