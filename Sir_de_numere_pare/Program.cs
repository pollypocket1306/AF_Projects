using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sir_de_numere_pare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lc = 0;
            int lmax = 0;
            int[] array = ArrayGetFile(@"..\..\input.txt");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    lc++;
                }
                else
                {
                    if (lc >= lmax)
                    {
                        lmax = lc;
                        lc = 0;
                    }
                }
            }
            if (lc > lmax)
            {
                lmax = lc;
            }
            Console.WriteLine(lmax);
        }

        static void 

        static int[] ArrayGetFile(string path)
        {
            TextReader load = new StreamReader(path);

            string[] buffer = load.ReadLine().Split(' ');
            int[] array = new int[buffer.Length];
            for (int i = 0; i < buffer.Length; i++)
            {
                array[i] = int.Parse(buffer[i]);
            }
            return array;
        }
    }
}
