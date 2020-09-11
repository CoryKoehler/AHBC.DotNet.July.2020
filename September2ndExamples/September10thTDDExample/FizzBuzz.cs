using System;
namespace September10thTDDExample
{
    public class FizzBuzz
    {
        public string Generate(int input)
        {
            if(input % 5 == 0 && input % 3 == 0)
            {
                return "FizzBuzz";
            }
            else if(input % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return "Buzz";
            }
        }
    }
}
