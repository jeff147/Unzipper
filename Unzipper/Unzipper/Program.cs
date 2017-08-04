using System;
using System.IO;

namespace unzipper
{
    class Program
    {
        static void Main(string[] args)
        {
            string zipPath = @"C:\Users\Jeff\zipped.zip";  // Path of zipped file
            string unzipped = @"C:\Users\Jeff\unzipped";  // Path of unzipped file

            try
            {
                System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, unzipped); // Add references System.IO.Compression and System.IO.Compression.FileSystem
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e);
            }

            FileInfo[] unzipFiles = new DirectoryInfo(unzipped).GetFiles("*.*");  // Get all files
            Console.WriteLine("All Files:");
            Array.ForEach(unzipFiles, file => Console.WriteLine(file));

            string[] txtFileNames = System.IO.Directory.GetFiles(unzipped, "*.txt");  // Get all .txt files
            Console.WriteLine("Text Files:");
            Array.ForEach(txtFileNames, file => Console.WriteLine(file));
        }
    }
}