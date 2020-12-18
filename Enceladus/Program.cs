using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enceladus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                num[i] = rnd.Next(-40, 40);
                Console.Write(num[i] + " ");
            }
            Console.WriteLine("");
            int max = num[0], s = 0;
            for (int i = 0; i < 10; i++)
            {
                if (max < num[i])
                    max = i;
            }
            s = num[0];
            num[0] = num[max];
            num[max] = s;
            for (int i = 0; i < 10; i++)
                Console.Write(num[i] + " ");

            Console.ReadKey();
        }
    }
}
