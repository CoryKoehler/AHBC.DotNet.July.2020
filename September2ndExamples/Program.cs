using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

namespace September2ndExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //How we could potentionally store zipcode and sales tax for lookup/reference
            var dictionaryExample = new Dictionary<int, decimal>() { { 48236, 0.06m }, { 48383, 0.07m } };
            //adding the same key causes an exception
            //dictionaryExample.Add(48236, 0.07m);
            var success = dictionaryExample.TryAdd(48236, 0.07m);
            if(!success)
            {
                Console.WriteLine("It's already in the dictionary!");
            }

            var retrieveSalesTaxSuccess = dictionaryExample.TryGetValue(48236, out decimal salesTax);
            if (retrieveSalesTaxSuccess)
            {
                Console.WriteLine($"The sales tax of 48236 is { salesTax}");
            }

            var userInput = Console.ReadLine();
            SpanishDictionary(userInput);
            var dictionaryExampleMore = new Dictionary<string, List<string>>();

            //var listExample = new List<int>() { 1, 2, 3 };

            var (successFromTuple, idkSomething, exception) = new ExampleService().RetreiveIdkSomething();
            if(!successFromTuple)
            {
                throw exception;
            }
        }

        public static void SpanishDictionary(string userInput)
        {
            var spanishDictionary = new Dictionary<string, string>()
            {
                {"hello", "hola"},
                {"food", "comida"},
                {"world", "mundo"},
                {"computer", "computadora"},
                {"exercise", "ejercicio"}
            };

            spanishDictionary.TryGetValue(userInput, out string translation);

            var keys = spanishDictionary.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine(key);
                spanishDictionary.TryGetValue(key, out string value);
                Console.WriteLine(value);
            }

            Console.WriteLine($"The spanish word for {userInput} is {translation}");
        }

        public static (bool success, int idkSomething, Exception exception) ReturnTuple()
        {
            (bool success, int idkSomething, Exception exception) returnValue = (true, 1, null);

            try
            {
                //do some logic
                return (true, 1, null);
            }
            catch (Exception ex)
            {
                returnValue.success = false;
                returnValue.exception = ex;
                
            }

            return returnValue;
            
        }
        
        public static Sept2ndReturnTypeAsInt ReturnTheReturnTypeAsInt()
        {
            return new Sept2ndReturnTypeAsInt(true, 1, null);
        } 
        
        public static Sept2ndReturnTypeAsString ReturnTheReturnTypeAsString()
        {
            return new Sept2ndReturnTypeAsString(true, "1", null);
        }
    }

    public class Sept2ndReturnTypeAsInt //: BaseReturnType
    {
        public bool Success { get; set; }
        public int IdkSomething { get; set; }
        public Exception Exception { get; set; }

        public Sept2ndReturnTypeAsInt(bool success, int idkSomething, Exception exception)
        {
            Success = success;
            IdkSomething = idkSomething;
            Exception = exception;
        }
    } 
    public class Sept2ndReturnTypeAsString //: BaseReturnType
    {
        public bool Success { get; set; }
        public string IdkSomething { get; set; }
        public Exception Exception { get; set; }

        public Sept2ndReturnTypeAsString(bool success, string idkSomething, Exception exception)
        {
            Success = success;
            IdkSomething = idkSomething;
            Exception = exception;
        }
    }

    public class ComplexClassExample
    {
        public (int databaseId, Guid guidId) Id;
    }

}
