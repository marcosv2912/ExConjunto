using System;
using System.Collections.Generic;

namespace ExConjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int numA = int.Parse(Console.ReadLine());
            HashSet<int> A = new HashSet<int>(numA);

            Console.WriteLine("Digite os codigos dos alunos do curso A: ");
            for (int i = 0; i < numA; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso B possui quantos alunos? ");
            int numB = int.Parse(Console.ReadLine());
            HashSet<int> B = new HashSet<int>();

            Console.WriteLine("Digite os codigos dos alunos do curso B: ");
            for (int i = 0; i < numB; i++)
            {
                B.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso C possui quantos alunos? ");
            int numC = int.Parse(Console.ReadLine());
            for (int i = 0; i < numC; i++)
            {
                C.Add(int.Parse(Console.ReadLine()));
            }

            A.UnionWith(B);
            A.UnionWith(C);

            int x = 0;
            foreach (int obj in A)
            {
                x++;
            }
            Console.WriteLine("Total de alunos: "+x);

        }
    }
}
