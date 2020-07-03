using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp
{
    /// <summary>
    /// This example demonstrates how to split the document to several one-page documents (by exact page numbers).
    /// </summary>
    public class SplitToSinglePages
    {
        public static void Run()
        {
            string filePath = Constants.SAMPLE_DOCX_10_PAGES;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), "document_{0}.{1}");

            SplitOptions splitOptions = new SplitOptions(filePathOut, new int[] { 3, 6, 8 });
            /* This options set should produce:
            * 
           Document name   |  Page numbers
           document_0     |     3
           document_1     |     6
           document_2     |     8
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