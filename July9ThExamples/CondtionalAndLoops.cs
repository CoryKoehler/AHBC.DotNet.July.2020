using System;
using System.Collections.Generic;

namespace July9ThExamples
{
    public class ConditionalAndLoops
    {
        public void Examples()
        {
            //If statements with conditions with relational operations
            Console.WriteLine("How old are you  ?");
            var userInput = Console.ReadLine();

            Console.WriteLine("How tall are you ?");
            var userHeight = Console.ReadLine();

            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            bool success = int.TryParse(userInput, out int number);
            bool okay = int.TryParse(userHeight, out int height);

            if (number >= 21 || height >= 6 && userName == "Michael")
            {
                Console.WriteLine("Hey what drink will you have ?");
            }
            else
            {
                Console.WriteLine("Hey you are too young...get outta here...");
            }

            if (number >= 21)
            {
                Console.WriteLine("Hey what drink will you have ?");
            }
            else if (number == 20)
            {
                Console.WriteLine("Hey you are too young...get outta here...");
            }
            else if (number < 10 && number > 5)
            {
                Console.WriteLine("Hey you are a baby");
            }
            else
            {
                Console.WriteLine("I dont even know");
            }

            //Switch case with When clause
            switch (number)
            {
                case int num when number >= 21 && number < 30:
                    Console.WriteLine("Old enough");
                    break;
                case 15:
                    Console.WriteLine("Not Old enough");
                    break;
                case 10:
                    Console.WriteLine("Where is your mama");
                    break;
                default:
                    Console.WriteLine("I have no clue");
                    break;
            }

            //Ternary operator
            var oldIsEnough = number >= 21 ? $"You are old enough {userName}" : number > 10 ? $"You are not old enough {userName}" : "something";

            Console.WriteLine(oldIsEnough);


            //For loop 
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine($"Here is the value of ++i = {i}");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Here is the value of i++ = {i}");
            }


            var numbers = new List<int>
            {
                1, 2, 3, 4, 5
            };

            //For each 
            foreach (var num in numbers)
            {
                if (num == 2)
                {
                    Console.WriteLine("we found it");
                    break;
                }

                Console.WriteLine(number);
            }
        }

    }
}


