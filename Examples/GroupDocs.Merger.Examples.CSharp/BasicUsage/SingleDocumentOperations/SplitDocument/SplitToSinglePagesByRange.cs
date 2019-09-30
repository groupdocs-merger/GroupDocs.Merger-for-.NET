using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp
{
    /// <summary>
    /// This example demonstrates how to split the document to several one-page documents (by start/end page numbers).
    /// </summary>
    public class SplitToSinglePagesByRange
    {
        public static void Run()
        {
            string filePath = Constants.SAMPLE_DOCX_10_PAGES;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), "document_{0}.{1}");

            PageSplitOptions splitOptions = new PageSplitOptions(filePathOut, 3, 7);
            /* This options set should produce:
             * 
           Document name   |  Page numbers
            document_0     |     3
            document_1     |     4
            document_2     |     5
            document_3     |     6
            document_4     |     7
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