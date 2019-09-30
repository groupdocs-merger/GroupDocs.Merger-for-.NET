using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to extract document pages by specifying page numbers range.
    /// </summary>
    public class ExtractPagesByRange
    {
        public static void Run()
        {
            string filePath = Constants.SAMPLE_DOCX;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            ExtractOptions extractOptions = new ExtractOptions(1, 3, RangeMode.EvenPages); // Resultant document will contain page 2

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