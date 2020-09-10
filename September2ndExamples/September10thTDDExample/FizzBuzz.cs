using System;
namespace September10thTDDExample
{
    public class FizzBuzz
    {
        public string Generate(int input)
        {
            return input % 5 == 0 ? "Buzz" : "Fizz";
        }
    }
}
