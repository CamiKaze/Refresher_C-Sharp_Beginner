using System.IO;

namespace FileAndFileInfoExercise
{
    class Program
    {
        private static string GetLongestWord(string content, string longestWord)
        {
            foreach (var word in content.Split(' '))
            {
                if (word.Length > longestWord.Length)
                    longestWord = word;
            }
            return longestWord;
        }
        
        private static string GetFileInformation(string content)
        {
            var path = @"C:\Users\camer\Projects\Core\Refresher_C-Sharp_Beginner\Files\FileAndFileInfoExercise\FileToRead.txt";
            return File.ReadAllText(path);
        }
        private static int NumberOfWords(int count, string content)
        {
            foreach (var word in content.Split(' '))
                count++;
            return count;
        }
        static void Main(string[] args)
        {
            /* Write a program that reads a text file and displays the number of words. */
            var count = 0;
            var content = string.Empty;
            content = GetFileInformation(content);
            count = NumberOfWords(count, content);
            System.Console.WriteLine(count);

            /* Write a program that reads a text file and displays the longest word in
            the file. */
            var longestWord = string.Empty;
            longestWord = GetLongestWord(content, longestWord);
            System.Console.WriteLine(longestWord);
        }
    }
}
