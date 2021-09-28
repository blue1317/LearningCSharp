using System;
using System.IO;

namespace UsingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Files
            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Decrypt(path);
            if (File.Exists(path))
            {
                //
            }

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }

            // Directories
            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentasl", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories =
                Directory.GetDirectories(@"c:\projects\CSharpFundamentasl", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

            // Path
            var newPath = @"C:\Users\Chris\Documents\Repos\LearningCSharp\HelloWorld\HelloWorld.sln";

            // Low lvl dont do it this way
            var dotIndex = newPath.IndexOf('.');
            var extension = newPath.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(newPath));
            Console.WriteLine("File Name: " + Path.GetFileName(newPath));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(newPath));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(newPath));
        }
    }
}
