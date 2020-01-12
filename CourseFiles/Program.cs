using System;
using System.IO;

namespace CourseFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\users\Adm\source\Files\Teste.txt";
            string targetPath = @"c:\users\Adm\source\Files\Teste1.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string s in lines)
                    {
                        sw.WriteLine(s.ToUpper());
                    }                    
                }
                Console.WriteLine(lines);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured: " + e.Message);
            }
        }
    }
}
