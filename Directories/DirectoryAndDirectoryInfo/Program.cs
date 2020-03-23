using System.IO;

namespace DirectoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* It is more convenient to use static methods, but everytime you use them,
            the Operating System does some security checking. This can have an effect
            the performance of your application. To avoid the performance issue, it is
            more effecient to create a DirectoryInfo object and call the instance methods
            on that object */
            Directory.CreateDirectory(@"c:\temp\folder1\asd");
            Directory.Delete(@"c:\temp\", true);

            var files = Directory.GetFiles(@"c:\Intel", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
                System.Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"c:\Intel", "*.*",
             SearchOption.AllDirectories);

            foreach (var directory in directories)
                System.Console.WriteLine(directory);

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
