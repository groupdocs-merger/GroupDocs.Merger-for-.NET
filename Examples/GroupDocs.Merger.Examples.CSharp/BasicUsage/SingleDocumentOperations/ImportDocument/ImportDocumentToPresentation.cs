using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to add the OLE object to the Presentation document page.
    /// </summary>
    public class ImportDocumentToPresentation
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: ImportDocumentToPresentation");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_PPTX;
            string embeddedFilePath = Constants.SAMPLE_PDF;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            int pageNumber = 2;
            OlePresentationOptions oleSlidesOptions = new OlePresentationOptions(embeddedFilePath, pageNumber);
            oleSlidesOptions.X = 10;
            oleSlidesOptions.Y = 10;

            using (Merger merger = new Merger(filePath))
            {
                merger.ImportDocument(oleSlidesOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Embedded object was added to the source document page successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}