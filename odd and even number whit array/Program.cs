using System;

namespace odd_and_even_number_whit_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int size;

            Console.Write("Enter the size of array  ");
            size = int.Parse(Console.ReadLine());
            Console.WriteLine("My array  {0} ",size);
            arr = new int[size];
            for (int i = 0; i <size; i++)
            {
                Console.Write("number ({0}) :",i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine("Even number {0} ", arr[i] + " ");
                }
            }
            
            Console.WriteLine("===================");
            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 != 0)

                {
                    Console.WriteLine("odd number {0} ", arr[i] + " ");
                }
            }
        }
    }
}
