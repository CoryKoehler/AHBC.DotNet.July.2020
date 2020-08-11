using System;
using System.Collections.Generic;
using System.IO;

namespace August10thI.OExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "DarionsFile";
            //Create
            FileUtility.CreateFile(fileName);
            //Inital Write
            FileUtility.ModifyFile(fileName, false);
            //Read
            FileUtility.ReadFromfile(fileName);
            var linesOfInput = new List<string>
            {
                "Darion Like Basketball",
                "Star wars is a gift to makind",
                "I named ,y son Anikan"
            };

            //Modify
            FileUtility.ModifyFile(fileName, true, linesOfInput);
            FileUtility.DeleteFile(fileName);
        }
    }
}
