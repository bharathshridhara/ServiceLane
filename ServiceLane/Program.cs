using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLane
{
    class Program
    {
        /// <summary>
        /// Solves the ServiceLane problem at <href>https://www.hackerrank.com/challenges/service-lane/problem</href>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int t = Convert.ToInt32(tokens_n[1]);
            string[] width_temp = Console.ReadLine().Split(' ');
            int[] width = Array.ConvertAll(width_temp, Int32.Parse);
            int[] results = new int[t];
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_i = Console.ReadLine().Split(' ');
                int i = Convert.ToInt32(tokens_i[0]);
                int j = Convert.ToInt32(tokens_i[1]);
                if (i < j)
                {
                    results[a0] = width.ToList().GetRange(i, j - i + 1).Min();
                }
                                
            }
            for(int i = 0; i < results.Length; i++)
                Console.WriteLine(results[i]);
            Console.ReadLine();
        }
    }
}
