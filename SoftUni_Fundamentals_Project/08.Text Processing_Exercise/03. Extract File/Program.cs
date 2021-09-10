using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pathParts = Console.ReadLine().Split('\\');

            string fileWithExtension = pathParts[pathParts.Length - 1];

            string[] fileParts = fileWithExtension.Split('.');

            string extension = fileParts[fileParts.Length - 1];

            string fileName = fileWithExtension.Replace($".{extension}", "");

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");

           //string fileName = fileWithExtension.Substring(0, extension);
           //string extension = fileWithExtension.Substring(extension + 1);
        }  
    }
}
