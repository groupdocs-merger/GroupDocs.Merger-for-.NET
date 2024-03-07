using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to split the text file to one-line documents.
    /// </summary>
    public class SplitToSeparateLines
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: SplitToSeparateLines");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_TXT;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), "line_{0}.{1}");

            TextSplitOptions splitOptions = new TextSplitOptions(filePathOut, new int[] { 3, 6 });

            using (Merger merger = new Merger(filePath))
            {
                merger.Split(splitOptions);
            }

            Console.WriteLine("Source document was splitted successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}