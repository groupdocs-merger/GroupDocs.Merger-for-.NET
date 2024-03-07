using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to extract document pages by specifying their numbers.
    /// </summary>
    public class ExtractPagesByNumbers
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: ExtractPagesByNumbers");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_DOCX;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            ExtractOptions extractOptions = new ExtractOptions(new int[] { 1, 4 }); // Resultant document will contain pages 1 and 4

            using (Merger merger = new Merger(filePath))
            {
                merger.ExtractPages(extractOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source document was extractmed successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}