using System;


namespace July16thExceptionsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine();
            try
            {
                //For executing logic that may break
                int userInputAsInt = int.Parse(userInput);
            }
            catch (Exception)
            {
                //For custom processing of the exception type that is being caught
                Console.WriteLine("Try running the program again and entering a number");
            }
            finally
            {
                //For after processing and logic you know won't error out
                Console.WriteLine("Good job you entered a number!!!");
            }
        }
    }
}
