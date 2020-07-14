using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace July13thExamples
{
    public class AccessorService
    {
        public AccessorService()
        {

        }

        public string SomeProperty { get; set; }

        public List<string> DoSomething()
        {
            var result = new List<string>();
            var ephemeral = PrependHiToString("Shari");
            result.Add(ephemeral);
            var fugazi = PrependHiToString("Shari", "Sid");
            result.Add(fugazi);
            return result;
        }

        private string PrependHiToString(string value)
        {
            return $"HI {value}";
        }

        private string PrependHiToString(string value, string valueTwo)
        {
            return $"Hi {value} and {valueTwo}";
        } 
        private string PrependHiToString(List<string> value)
        {
            return $"Hi {value}";
        }
    }
}
