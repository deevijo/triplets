using System;
using System.Collections.Generic;

namespace triplets
{
    class Program
    {
        static void Main(string[] args)
        {
            // problem statement :https://practice.geeksforgeeks.org/problems/count-the-triplets4615/1
            int[] arr = { 1,5,2,3 };
           // int[] arr = { 2,3,4 };
            int cnt =  countTriplet(arr);
            Console.WriteLine(cnt);
        }

        static int countTriplet(int[] arr)
        {
            int count = 0;
            int k = 0;
            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (hs.Contains(arr[i]))
                    count++;
                else
                    hs.Add(arr[i]);

                for (int j = i+1; j < arr.Length; j++)
                {
                    if (hs.Contains(arr[i]+ arr[j]))
                        count++;
                    else
                        hs.Add(arr[i] + arr[j]);
                }
            }

            return count;
        }
    }
}
