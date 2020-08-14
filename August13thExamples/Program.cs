using System;
using System.Collections.Generic;
using System.Linq;

namespace August13thExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static string[] AddValues(string one, string two, string three)
        {
            List<string> list = new List<string>();
            list.Add(one);
            list.Add(two);
            list.Add(three);
            return list.ToArray();
        } 
        
        static string[] AddValuesNoList(string one, string two, string three)
        {
            string[] stringArray = new string[3];
            stringArray.SetValue(one, 1);
            stringArray.SetValue(two, 2);
            stringArray.SetValue(three, 3);
         
            return stringArray;
        }

        static int SumArray(int[] values)
        {
            return values.Sum();
        }
        
        static int SumArrayWithoutSumForLoop(int[] values)
        {
            var sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return sum;
        }
        static int SumArrayWithoutSumForEachLoop(int[] values)
        {
            var sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            return sum;
        }

        static List<int> RemoveNum(List<int> numbers, int number)
        {
            numbers.RemoveAll(entry => entry == number);
            return numbers;
        }

        static List<string> AddToList(string value)
        {
            var fruitList = new List<string>()
            {
                "grapes",
                "oranges",
                value
            };

            return fruitList;
        }

        static int TryMe(int numberOne, int numberTwo)
        {
            try
            {
                var result = numberOne / numberTwo;
                return result;
            }
            catch (Exception)
            {
                return 9;
            }
        }

    }
}
