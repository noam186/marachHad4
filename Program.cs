using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marachHad4
{
    internal class Program
    {

        static void Main()
        {
            Question1();
            Question2();
            Question3();
        }

        static void Question1()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            int[] originalArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                originalArray[i] = int.Parse(Console.ReadLine());
            }

            List<int> evenList = new List<int>();
            List<int> negativeList = new List<int>();

            foreach (int num in originalArray)
            {
                if (num % 2 == 0)
                {
                    evenList.Add(num);
                }
                if (num < 0)
                {
                    negativeList.Add(num);
                }
            }

            int[] evenArray = evenList.ToArray();
            int[] negativeArray = negativeList.ToArray();

            Console.WriteLine("Original: " + string.Join(", ", originalArray));
            Console.WriteLine("Even: " + string.Join(", ", evenArray));
            Console.WriteLine("Negative: " + string.Join(", ", negativeArray));
        }

        static void Question2()
        {
            Console.Write("Enter size of first array: ");
            int size1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[size1];
            for (int i = 0; i < size1; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter size of second array: ");
            int size2 = int.Parse(Console.ReadLine());
            int[] arr2 = new int[size2];
            for (int i = 0; i < size2; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr2[i] = int.Parse(Console.ReadLine());
            }

            List<int> commonList = new List<int>();
            foreach (int item in arr1)
            {
                if (Array.Exists(arr2, x => x == item) && !commonList.Contains(item))
                {
                    commonList.Add(item);
                }
            }

            int[] commonArray = commonList.ToArray();
            Console.WriteLine("Common elements: " + string.Join(", ", commonArray));
        }

        static void Question3()
        {
            Console.Write("Enter number of flowers: ");
            int n = int.Parse(Console.ReadLine());

            int[] flw = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter flower code {i + 1}: ");
                flw[i] = int.Parse(Console.ReadLine());
            }

            List<int> family1List = new List<int>();
            List<int> family2List = new List<int>();

            foreach (int code in flw)
            {
                int family = code / 100;
                if (family == 1)
                {
                    family1List.Add(code);
                }
                else if (family == 2)
                {
                    family2List.Add(code);
                }
            }

            flw = family1List.ToArray();
            int[] flw2 = family2List.ToArray();

            Console.WriteLine("FLW: " + string.Join(" ", flw));
            Console.WriteLine("FLW2: " + string.Join(" ", flw2));
        }
    }
}


