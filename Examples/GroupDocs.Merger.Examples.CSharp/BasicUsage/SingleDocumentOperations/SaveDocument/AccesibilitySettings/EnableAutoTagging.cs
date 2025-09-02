using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to save document pages.
    /// </summary>
    public class EnableAutoTagging
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: EnableAutoTagging");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_PDF_BOOKMARKS;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            PdfSaveOptions pdfSaveOptions = new PdfSaveOptions();
            pdfSaveOptions.AccesibilitySettings.EnableAutoTagging = true;

            using (Merger merger = new Merger(filePath))
            {
                merger.Save(filePathOut, pdfSaveOptions);
            }

            Console.WriteLine("Source document pages were saved successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}