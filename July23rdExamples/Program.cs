using System;

namespace July23rdExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            int[] arrayOne = new int[4];
            arrayOne[0] = 1;
            arrayOne[1] = 2;
            arrayOne[2] = 3;
            arrayOne[3] = 4;

            int[] arrayTwo = new int[] { 1, 2, 3, 4, 4, 5, 6 };

            char[] charArray = { 'D', 'E'};

            int[] arrayThree = arrayTwo;
            arrayThree[1] = 100;

            var nestedArrays = GetNestedArray();

            PrintNestedArrays(nestedArrays);

        }

        private static void PrintNestedArrays(int[][] nestedArrays)
        {
            for (int i = 0; i < nestedArrays.Length; i++)
            {
                Console.WriteLine($"OuterArrray{nestedArrays[i]}");

                for (int j = 0; j < nestedArrays[i].Length; j++)
                {
                    Console.WriteLine($"InnerArray :{nestedArrays[j][i]}");
                }
            }
        }

        private static int[][] GetNestedArray()
        {
            int[][] nestedArray = new[]
            {
                       //J 0,1,2,3,4
                new int[]{1,2,3,4,5},         //i 0
                new int[]{6,7,8,9 },           //1
                new int[]{10,11,12,13,14,15 }   //2
            };
            return nestedArray;
        }
    }
}
