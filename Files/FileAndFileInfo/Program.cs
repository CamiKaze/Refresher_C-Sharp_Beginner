using System.IO;

namespace FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // File provides static methods.
            var path = @"C:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            // FileInfo provides instance methods
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
        }
    }
}
