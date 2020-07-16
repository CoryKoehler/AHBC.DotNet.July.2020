using System;

namespace July15thStringExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenation
            Console.WriteLine("HI"+"I'M"+"TAYLORE");

            var somethingFunky = string.Concat("hi", "bye");
            Console.WriteLine(somethingFunky);

            Console.WriteLine($"Here is {somethingFunky}");

            //Split
            var sidSpeaks = "Sid,has a nice voice,great.";
            var sidSpeaksSplit = sidSpeaks.Split(',');

            //[sid, has a nice voice, great]
            // 0  , 1               , 2
            for (int i = 0; i < sidSpeaksSplit.Length; i++)
            {
               Console.WriteLine($"Index{i}:{sidSpeaksSplit[i]}");
            }

            // Whitespace example
            string whitespace = "       hello   world                ";
            Console.WriteLine(whitespace.Trim());

            //name = name.Replace(" ", "");
            Console.WriteLine(whitespace.Replace("  ", " "));

            //String
            var multiTeacher = "Kori my name Elizabeth";
            var FirstIndex = multiTeacher.IndexOf("Elizabeth");
            var SecondIndex = multiTeacher.ToLower().IndexOf("beth", StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(FirstIndex);
            Console.WriteLine(SecondIndex);

            //String Comparison
            var userInput = Console.ReadLine();
            if (userInput.Equals("KORI",StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("HEY IT DOES EQUAL!!");
            }
        }
    }
}
