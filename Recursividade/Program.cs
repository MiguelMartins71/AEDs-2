using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero = fat(5);
            Console.WriteLine("Fatorial de 5= "+numero);
     
            
        }

        public static int fat(int n)
        {
            int res;
            if(n < 1)
            {
                res = 1;
            }
            else
            {

               res = n * fat(n - 1);
            }
            return res;

            
        }

    }


    }
