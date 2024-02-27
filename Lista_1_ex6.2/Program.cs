using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex6._2
{
    internal class Program
    {
        //oi
        static void Main(string[] args)
        {
            double n;
            Console.WriteLine("digite um numero inteiro");
            n = double.Parse(Console.ReadLine());
            bool divisivel = false;
            if (n / 4 == (int)n / 4)
            {
                divisivel = true;
            }
            if (divisivel)
            {
                Console.WriteLine("numero valido");
            }
            else Console.WriteLine("numero invalido");
            Console.ReadKey();
        }
    }
}
