using System;

namespace AssesmentOneReview
{
    class Program
    {
        static void Main(string[] args)
        {
            var something = IsTheSame(6,8);
            var somethingElse = Subtract(6,8);
            var somethingnew = FindBuildingType(20);
            Console.WriteLine(something);
            Console.WriteLine(somethingElse);
            Console.WriteLine(somethingnew);
     
        }

           
        
        static bool IsTheSame(int numberOne, int numberTwo)
        {
            return numberOne == numberTwo;
        }

        static double Subtract(double num1, double num2)
        {
            return num2 - num1;
        }

        static string FindBuildingType(int num1)
        {
            if (num1 >= 4 && num1 <= 10)
            {

                return $"This is an office building {num1}";
            }
            else if (num1 > 50)
            {
                return " This is a Super skyscraper";

            }
            else if (num1 >= 11 && num1 <= 49)
            {
                return "This is a skyscraper!";
            }
            else if (num1 <= 3 && num1 >=0)
            {
                return "This is a house";
            }
            else if (num1 < 0)
            {
                return "Underground Bunker!";
            }
            return "Somthing";

        }
    }
}
