using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Longitud del vector: ");
            n = Int32.Parse(Console.ReadLine());
            int[] vector;
            vector = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                vector[i] = r.Next(-10, 20);
            }
            countingSort(vector);
            Console.WriteLine("Vector ordenado en forma ascendente");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("{0} ", vector[i]);
            }
            Console.ReadKey();
        }

        public static void countingSort(int[] data)
        {
            int min = 0;
            int max = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < min)
                {
                    min = data[i];
                }
                else if (data[i] > max)
                {
                    max = data[i];
                }
            }

            int[] count = new int[max - min + 1];
            int z = 0;

            for (int i = 0; i < count.Length; i++)
                count[i] = 0;

            for (int i = 0; i < data.Length; i++)
                count[data[i] - min]++;

            for (int i = min; i <= max; i++)
            {
                while (count[i - min]-- > 0)
                {
                    data[z] = i;
                    ++z;
                }
            }
        }
    }
}
