﻿using System.IO;

namespace FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* It is more convenient to use static methods, but everytime you use them,
            the Operating System does some security checking, that can have an effect
            on performance. To avoid this, it's more effecient to create a FileInfo object
            and call the instance methods on the object */

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
