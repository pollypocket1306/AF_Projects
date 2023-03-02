using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int startPos = 0, endPos = 0;
            long s = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    v[i] = int.Parse(Console.ReadLine());
            //}

            v = ReadFromFile(@"../../input.txt");

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] % 2 == 1)
                {
                    startPos = i;
                    break;
                }
            }

            for (int i = v.Length - 1; i >= 0; i--)
            {
                if (v[i] % 2 == 1)
                {
                    endPos = i;
                    break;
                }
            }

            for (int i = startPos; i <= endPos; i++)
            {
                s += v[i];
            }
            Console.WriteLine(s);
        }



        //IMPORTANT
        static int[] ReadFromFile(string path)
        {
            TextReader load = new StreamReader(path);
            int n = int.Parse(load.ReadLine());
            int[] v = new int[n];
            int k = 0;
            string buffer;
            while((buffer = load.ReadLine()) != null)
            {
                string[] b = buffer.Split(' ');
                for (int i = 0; i < b.Length; i++)
                {
                    v[k] = int.Parse(b[i]);
                    k++;
                }
            }
            return v;
        }
    }
}
