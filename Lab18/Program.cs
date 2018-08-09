using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{

    class Program
    {

        static int[,] Frequency(int[] arr)
        {

            int min = arr[0];
            int max = arr[0];
            int count = 0;

            foreach (int x in arr)
            {
                if (min > x)
                {
                    min = x;
                }
                if (max < x)
                {
                    max = x;
                }
            }
            for (int i = 0; min + i <= max; i++)
            {
                if (min + i == max)
                {
                    count = i;
                }
            }
            count++;
            int[,] output = new int[count, 2];
            for (int i = 0; i < count; i++)
            {
                output[i, 0] = min + i;
                output[i, 1] = 0;
            }
            foreach (int x in arr)
            {
                int index = x - min;
                output[index, 1]++;
            }

            return output;

        }

        static void Main(string[] args)
        {

            int[] a = {1,2,3,2,2,4,5,5,7,8,4,4,1,0,10 };
            int[,] b = Frequency(a);
            int length = b.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{b[i,0]}: {b[i,1]}");
            }

        }

    }

}
