    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _07SumArrays
    {
        class SumArrays
        {
            static void Main(string[] args)
            {
                //Console.WriteLine(4%3);
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                string[] str1Arr = str1.Split().ToArray();
                string[] str2Arr = str2.Split().ToArray();
                int[] arr1 = new int[str1Arr.Length];
                int[] arr2 = new int[str2Arr.Length];
                for (int i = 0; i < arr1.Length; i++)
                {
                    arr1[i] = int.Parse(str1Arr[i]);
                }
                for (int i = 0; i < arr2.Length; i++)
                {
                    arr2[i] = int.Parse(str2Arr[i]);
                }
                if (arr1.Length == arr2.Length)
                {
                    int[] arr3 = new int[arr1.Length];
                    for (int i = 0; i < arr1.Length; i++)
                    {
                        arr3[i]= arr1[i] + arr2[i];
                    }
                    Console.WriteLine(string.Join(" ", arr3));
                }
                else if (arr1.Length > arr2.Length)
                {
                    int[] arr3 = new int[arr1.Length];
                    for (int i = 0; i < arr1.Length; i++)
                    {
                        arr3[i] = arr2[i % arr2.Length] + arr1[i];                   
                    }
                    Console.WriteLine(string.Join(" ", arr3));
                }
                else if (arr1.Length < arr2.Length)
                {
                    int[] arr3 = new int[arr2.Length];
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        arr3[i] = arr1[i % arr1.Length] + arr2[i];                    
                    }
                    Console.WriteLine(string.Join(" ", arr3));
                }
            }
        }
    }
