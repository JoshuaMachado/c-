using System;
using System.IO;
namespace NoteTakingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new text file.
            string path = @"C:\Users\Public\Documents\notes.txt";
            File.Create(path);
            // Write to the text file.
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Hello, world!");
            }
            // Read from the text file.
            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}
