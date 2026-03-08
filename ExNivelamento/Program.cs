using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExNivelamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite");
            int N = int.Parse(Console.ReadLine());

            int c = 0;

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    c++;
                    Console.Write(c + " ");
                }

                Console.WriteLine();
            }
        }
    }
}