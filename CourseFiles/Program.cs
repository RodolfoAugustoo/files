using System;
using System.IO;

namespace CourseFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\users\Adm\source\Files\Teste.txt";
            //FileStream fs = null;

            //Dessa forma não é necessário criar manualmente o FileStream
            StreamReader sr = File.OpenText(sourcePath);
            try
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }                
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Error! " + e.Message);
            }
            finally
            {                
                if (sr != null) sr.Close();
            }
        }
    }
}
