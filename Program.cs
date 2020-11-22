using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olyver_DecimalBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            string bin = "";
            Console.Write("Introduce el número decimal:");
            n = int.Parse(Console.ReadLine());

            while (true)
            {
                if ((n % 2) != 0)
                    bin = "1" + bin;
                else
                    bin = "0" + bin;
                n /= 2;
                if (n <= 0)
                    break;
            }
            Console.WriteLine("El resultado en binario:" + bin);
            Console.ReadKey();
        }
    }
}
