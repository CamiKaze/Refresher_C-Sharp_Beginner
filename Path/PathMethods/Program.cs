using System.IO;

namespace PathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Windows\apppatch\frxmain.sdb";
            System.Console.WriteLine("Extension: " + Path.GetExtension(path));
            System.Console.WriteLine("File Name: " + Path.GetFileName(path));
            System.Console.WriteLine("File Name without extension: " + Path.GetFileNameWithoutExtension(path));
            System.Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}
