using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Collections
{
    class TestaContains
    {
        static void Main()
        {
            List<int> list = new List<int>();
            HashSet<int> hashSet = new HashSet<int>();

            long tempo = TestaContains.Contains(list);
            Console.WriteLine("List Add: " + tempo + "ms");

            tempo = TestaContains.HashContains(hashSet);
            Console.WriteLine("Hash Add: " + tempo + "ms");

            Console.ReadKey();
        }

        public static long Contains(ICollection<int> colecao)
        {
            int size = 100000;

            for (int i = 0; i < size; i++)
            {
                colecao.Add(i);
            }

            Stopwatch sw = new Stopwatch();

            sw.Start();

            for (int i = 0; i < size; i++)
            {
                colecao.Contains(i);
            }

            sw.Stop();

            return sw.ElapsedMilliseconds;
        }

        public static long HashContains(HashSet<int> hash)
        {
            int size = 100000;

            for (int i = 0; i < size; i++)
            {
                hash.Add(i);
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < size; i++)
            {
                hash.Contains(i);
            }

            sw.Stop();

            return sw.ElapsedMilliseconds;
        }
    }
}
