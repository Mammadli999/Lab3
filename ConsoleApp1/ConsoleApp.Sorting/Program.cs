using System;

namespace ConsoleApp.Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[5] {1, 32, -12, 3, 83};
            Sorting(Arr);
        }

        static void Sorting(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
