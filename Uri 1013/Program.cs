using System;

namespace Uri_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, v, m;



            Console.WriteLine();
            Console.Write("Digite 3 valores para saber qual é o maior : ");
            string[] vetor = Console.ReadLine().Split(' ');
            a = int.Parse(vetor[0]);
            b = int.Parse(vetor[1]);
            c = int.Parse(vetor[2]);

            v = (a + b + Math.Abs(a-b)) / 2;
            m = (v + c + Math.Abs(v - c)) / 2;

            Console.WriteLine();
            Console.WriteLine(m+" É o maior");
            Console.WriteLine();

        }
    }
}
