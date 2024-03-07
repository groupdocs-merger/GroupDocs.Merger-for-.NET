using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp
{
    /// <summary>
    /// This example demonstrates how to split the document to several multi-page documents by specified page ranges.
    /// </summary>
    public class SplitToMultiPageDocuments
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: SplitToMultiPageDocuments");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_DOCX_10_PAGES;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), "document_{0}.{1}");

            SplitOptions splitOptions = new SplitOptions(filePathOut, new int[] { 3, 6, 8 }, SplitMode.Interval);
            /* This options set should produce 
              Document name   |  Page numbers
               document_0     |     1, 2
               document_1     |     3, 4, 5
               document_2     |     6, 7
               document_3     |     8, 9, 10
            */

            using (Merger merger = new Merger(filePath))
            {
                merger.Split(splitOptions);
            }

            Console.WriteLine("Source document was splitted successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}