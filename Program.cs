using System;

namespace SortByHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm run = new Algorithm();

            int[] testData = new int[] { -1, 150, 190, 170, -1, -1, 160, 180 };

            int[] result = run.SortByHeight(testData);

            Console.WriteLine("Result is as follows!");

            foreach (int num in result)
            {
                Console.Write(num + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Expected Output: [-1, 150, 160, 170, -1, -1, 180, 190]");
        }
    }

    class Algorithm
    {
        public int[] SortByHeight(int[] a)
        {
            // loop through array 1 time
            // during that loop, sort only values that are not -1 
            // use bubble sort to rearrange the non trees

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > -1)
                {
                    for (int j = 0; j < a.Length; j++)
                    {
                        if (a[j] > -1 && a[i] < a[j])
                        {
                            int k = a[i];
                            a[i] = a[j];
                            a[j] = k;
                        }
                    }
                }
            }
            return a;
        }
    }
}
