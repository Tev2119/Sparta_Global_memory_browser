using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System.IO;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo currDir = new DirectoryInfo(".");

            DirectoryInfo tevsDir = new DirectoryInfo(@"C:\Users\Public\TevsDir");
            //attributes of Dir 
            Console.WriteLine(tevsDir.FullName);
            Console.WriteLine(tevsDir.Name);
            Console.WriteLine(tevsDir.Attributes);
            Console.WriteLine(tevsDir.CreationTime);

            //create a Dir
            //DirectoryInfo crtDir = new DirectoryInfo(@"C:\Users\Public\C#Data");
            ////Delete Dir
            ////Directory.Delete(@"C:\Users\Public\C#Data");
            //Console.WriteLine("here is Dir NAME: " + crtDir.FullName);
            //Console.WriteLine("Dir Creation Time : " + crtDir.CreationTime);

            //read& write files
            string[] urls =//making array of https for write to Dir
            {
                "http://www.google.com",
                "http://www.yahoo.com",
                "http://www.bing.com"
            };
            //textfile as a variable of type string && Write @ Dir location of above strings ++ type of file ie txt,etc
            string textFilePath = @"C:\Users\tech-w93a.LAPTOP-IR0H8TM3\Documents\testfile";
            Console.WriteLine("Text file creation : " + textFilePath);
            Console.WriteLine("txt is still here: " + textFilePath);
            //Writing into Dir (choosing the Location & file, followed by what your writing inn, this case [URLS])
            //File.WriteAllLines(textFilePath, urls);

            // LOOP Reading urls, stored in type<string> && VARIABLE NAME and then (what you are reading from textfile)
            foreach (string url in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"URLS : {url}");
            }












            Console.ReadLine();

        }
    }
}
