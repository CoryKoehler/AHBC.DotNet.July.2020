using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace July27thCollectionExamples
{
    class Program
    {
        private static bool UserContinueSelection { get; set; } = true;
        #region List uncomment to run and comment out dicitonary region
        //static void Main(string[] args)
        //{
        //    //var stringList = new List<string>() { "Jason", "Better Jason" };
        //    //stringList.Add("Cory");
        //    //stringList.RemoveAt(2);
        //    //var cory = stringList.ElementAt(2);
        //    //var result = stringList.Last(entry => entry.Contains("Jason"));

        //    var stringList = new List<string>();

        //    Console.WriteLine("Hello input some string!");

        //    while(UserContinueSelection == true)
        //    {
        //        var userInput = Console.ReadLine();
        //        var userInput2 = Console.ReadLine();
        //        stringList.AddRange(new List<string> { userInput, userInput2 });


        //        foreach (var item in stringList)
        //        {
        //            Console.WriteLine(item);
        //        }


        //        UserContinue();
        //    }

        //}
        #endregion

        #region Dictionary comment out to run list main method
        //static void Main()
        //{

        //    //var dictionaryForUserInput = new Dictionary<int, string>() { { 0, "Sandy" }, { 1, "Bernard" } };
        //    //dictionaryForUserInput.Remove(0);
        //    //dictionaryForUserInput.Add(0, "Shari");
        //    //dictionaryForUserInput.TryGetValue(1, out var bernard);
        //    //var bernardKey = dictionaryForUserInput.First(entry => entry.Value.Contains("Bernard")).Key;
        //    //foreach (var entry in dictionaryForUserInput)
        //    //{
        //    //    if(entry.Value.Contains("Bernard"))
        //    //    {
        //    //        var bernardKeyInLoop = entry.Key;
        //    //    }
        //    //}
        //    //Console.WriteLine($"We found {bernard}");

        //    while (UserContinueSelection == true)
        //    {
        //        var dictionaryOfUserInput = new Dictionary<int, string>();
        //        Console.WriteLine("Hello input some string!");
        //        var userInput = Console.ReadLine();
        //        Console.WriteLine("input another string!");
        //        var userInput2 = Console.ReadLine();

        //        var listOfUserInputs = new List<string>();
        //        listOfUserInputs.AddRange(new List<string> { userInput, userInput2 });

        //        foreach (var item in listOfUserInputs)
        //        {
        //            dictionaryOfUserInput.Add(listOfUserInputs.FindIndex(entry => entry.Contains(item)), item);
        //        }

        //        UserContinue();
        //    }
        //}

        #endregion 

        #region Enumerable comment out to run list main method
        static void Main()
        {
            var enuerableOfStrings = Enumerable.Empty<string>();

            while (UserContinueSelection == true)
            {
                Console.WriteLine("Input some string!");
                var userInput = Console.ReadLine();
                enuerableOfStrings.Append(userInput);

                UserContinue();
            }
        }
        #endregion

        private static void UserContinue()
        {
            Console.WriteLine("Do you desire to continue?");
            var userDesire = Console.ReadLine();

            if (userDesire.Contains("Y", StringComparison.InvariantCultureIgnoreCase))
            {
                UserContinueSelection = true;
            }
            else
            {
                UserContinueSelection = false;
            }
        }
    }
}
