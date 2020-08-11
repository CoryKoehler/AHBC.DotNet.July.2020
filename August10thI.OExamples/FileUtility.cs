using System;
using System.Collections.Generic;
using System.IO;

namespace August10thI.OExamples
{
    public class FileUtility
    {
        public static void CreateFile(string fileName)
        {
            string filePath = @"C:\Darion\Desktop";
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }
        }

        public static void ModifyFile(string filename, bool canAppend, List<string> linesOfinput = null)
        {
            using (StreamWriter writer = new StreamWriter(filename, canAppend))
            {
                if(linesOfinput == null)
                {
                    writer.WriteLine("This is a new string");
                }
                else
                {
                    foreach (var line in linesOfinput)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }

        public static void ReadFromfile(string fileName)
        {
            using(StreamReader reader = new StreamReader(fileName))
            {
                //This is the old way of doing a read
                //while (true)
                //{
                //    var line = reader.ReadLine();
                //    if (line == null)
                //    {
                //        break;
                //    }
                //    Console.WriteLine(line);
                //}

                //
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
        }

        public static void DeleteFile(string fileName)
        {
            File.Delete(fileName);
        }
    }
}
