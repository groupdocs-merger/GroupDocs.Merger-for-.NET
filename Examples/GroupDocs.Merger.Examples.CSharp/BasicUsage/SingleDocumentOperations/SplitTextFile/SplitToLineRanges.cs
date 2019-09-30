using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to split the text file to the line interval text ones.
    /// </summary>
    public class SplitToLineRanges
    {
        public static void Run()
        {
            string filePath = Constants.SAMPLE_TXT;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), "text_{0}.{1}");

            TextSplitOptions splitOptions = new TextSplitOptions(filePathOut, TextSplitMode.Interval, new int[] { 3, 6 });

            using (Merger merger = new Merger(filePath))
            {
                merger.Split(splitOptions);
            }

            Console.WriteLine("Source document was splitted successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}