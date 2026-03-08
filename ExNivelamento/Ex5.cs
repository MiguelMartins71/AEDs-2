using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExNivelamento
{
    internal class Ex5
    {

        static void Main()
        {

            int anterior = int.MinValue;
            int seqAtual = 0;
            int maiorSeq = 0;

            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == -1)
                    break;

                if (num > anterior)
                {
                    seqAtual++;
                }
                else
                {
                    seqAtual = 1;
                }

                if (seqAtual > maiorSeq)
                {
                    maiorSeq = seqAtual;
                }

                anterior = num;
            }

            Console.WriteLine("Maior sequência crescente: " + maiorSeq);
        }
    }
}