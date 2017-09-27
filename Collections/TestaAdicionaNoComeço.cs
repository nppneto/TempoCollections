using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Collections
{
    class TestaAdicionaNoComeço
    {
        static void Main()
        {
            List<int> list = new List<int>();

            long tempo = TestaAdicionaNoComeço.AdicionaNoComecoList(list);
            Console.WriteLine("List Insert: " + tempo + "ms");

            LinkedList<int> linkedList = new LinkedList<int>();

            tempo = TestaAdicionaNoComeço.AdicionaNoComecoLinkedList(linkedList);
            Console.WriteLine("LinkedList AddFirst: " + tempo + "ms");

            Console.ReadKey();
        }

        public static long AdicionaNoComecoList(List<int> lista)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            int size = 100000;

            for (int i = 0; i < size; i++)
            {
                lista.Insert(0, 1);
            }

            sw.Stop();

            return sw.ElapsedMilliseconds;
        }

        public static long AdicionaNoComecoLinkedList(LinkedList<int> lista)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            int size = 100000;

            for (int i = 0; i < size; i++)
            {
                lista.AddFirst(i);
            }

            sw.Stop();

            return sw.ElapsedMilliseconds;
        }
    }
}
