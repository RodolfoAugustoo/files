using System;
using System.IO;
using System.Collections.Generic;

namespace CourseFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\users\Adm\source\Files";
            //string targetPath = @"c:\users\Adm\source\Files\Teste1.txt";

            try
            {
                IEnumerable<string> folders =  Directory.EnumerateDirectories(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach(string f in folders)
                {
                    Console.WriteLine(f);
                }

                Directory.CreateDirectory(sourcePath + "\\teste");               

                IEnumerable<string> files = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("\r\nFILES:");
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured: " + e.Message);
            }
        }
    }
}
