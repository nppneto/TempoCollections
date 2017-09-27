using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Collections
{
    class TestaAdicionaNoFinal
    {
        static void Main()
        {
            List<int> list = new List<int>();

            long tempo = TestaAdicionaNoFinal.AdicionaNoFinal(list);
            Console.WriteLine("List Add: " + tempo + "ms");

            LinkedList<int> linkedList = new LinkedList<int>();

            tempo = TestaAdicionaNoFinal.AdicionaNoFinal(linkedList);
            Console.WriteLine("LinkedList Add: " + tempo + "ms");

            Console.ReadKey();

        }

        public static long AdicionaNoFinal(ICollection<int> lista)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            int size = 100000;

            for (int i = 0; i < size; i++)
            {
                lista.Add(i);
            }

            sw.Stop();

            return sw.ElapsedMilliseconds;
        }
    }
}
