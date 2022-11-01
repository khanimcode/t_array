using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[]  arr =new int[6] { 2,1,7,8,9,10};
            int max = 0;
            int min = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
                else 
                {
                    min = arr[i];
                }

            }
            Console.WriteLine(max-min);

        }

    }
}
