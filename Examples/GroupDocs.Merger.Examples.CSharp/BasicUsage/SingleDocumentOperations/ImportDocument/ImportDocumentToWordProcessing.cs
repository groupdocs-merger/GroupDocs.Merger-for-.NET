using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to add the OLE object to the Word processing document page.
    /// </summary>
    public class ImportDocumentToWordProcessing
    {
        public static void Run()
        {
            string filePath = Constants.SAMPLE_DOCX;
            string embeddedFilePath = Constants.SAMPLE_PDF;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            int pageNumber = 2;
            OleWordProcessingOptions oleWordsOptions = new OleWordProcessingOptions(embeddedFilePath, pageNumber);
            oleWordsOptions.Width = 300;
            oleWordsOptions.Height = 300;

            using (Merger merger = new Merger(filePath))
            {
                merger.ImportDocument(oleWordsOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Embedded object was added to the source document page successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}