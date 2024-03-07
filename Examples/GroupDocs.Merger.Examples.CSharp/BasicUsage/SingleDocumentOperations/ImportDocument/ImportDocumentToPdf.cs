using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to add attachment to the Pdf document.
    /// </summary>
    public class ImportDocumentToPdf
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: ImportDocumentToPdf");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_PDF_2;
            string embeddedFilePath = Constants.SAMPLE_PPTX;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            PdfAttachmentOptions olePdfOptions = new PdfAttachmentOptions(embeddedFilePath);

            using (Merger merger = new Merger(filePath))
            {
                merger.ImportDocument(olePdfOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Embedded object was added to the source document successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}