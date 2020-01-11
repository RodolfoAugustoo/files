using System;
using System.IO;

namespace CourseFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\users\Adm\source\Files\Teste.txt";
            /*
             *try
             {
                 using (FileStream fs = new FileStream(sourcePath, FileMode.Open))
                 {
                     using (StreamReader sr = new StreamReader(fs))
                     {
                         while (!sr.EndOfStream)
                         {
                             Console.WriteLine(sr.ReadLine());
                         }
                     }
                 }
             }
             catch(IOException e)
             {
                 Console.WriteLine("An error occured: " + e.Message);
             }*/
            try
            {
                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured: " + e.Message);
            }
        }
    }
}
