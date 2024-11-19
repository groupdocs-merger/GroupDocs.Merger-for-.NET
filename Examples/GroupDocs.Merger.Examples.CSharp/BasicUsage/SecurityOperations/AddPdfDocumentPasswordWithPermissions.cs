using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to add password to PDF document with permissions.
    /// </summary>
    public class AddPdfDocumentPasswordWithPermissions
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: AddPdfDocumentPasswordWithPermissions");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_PDF;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            PdfSecurityOptions pdfSecurityOptions = new PdfSecurityOptions(Constants.SAMPLE_PASSWORD);
            pdfSecurityOptions.Permissions = PdfSecurityPermissions.DenyModification;

            using (Merger merger = new Merger(filePath))
            {
                merger.AddPassword(pdfSecurityOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source document password was added successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}