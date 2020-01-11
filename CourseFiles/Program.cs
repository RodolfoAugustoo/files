using System.IO;

namespace CourseFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\users\Adm\source\Files\Teste.txt";
            using (StreamWriter sw = File.AppendText(sourcePath))
            {
                sw.WriteLine("Have a nice day!");
                sw.WriteLine("Good afternoon");
                sw.WriteLine("Good night!");
            }
            try
            {
                if (File.Exists(@"c:\users\Adm\source\Files\Teste1.txt"))
                {
                    File.Delete(@"c:\users\Adm\source\Files\Teste1.txt");
                }

                else
                {
                    string targetPath = @"c:\users\Adm\source\Files\Teste1.txt";

                    FileInfo fileInfo = new FileInfo(sourcePath);
                    fileInfo.CopyTo(targetPath);

                    string[] lines = File.ReadAllLines(sourcePath);

                    foreach (string s in lines)
                    {
                        System.Console.WriteLine(s);
                    }
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Error! " + e.Message);
            }
        }
    }
}
