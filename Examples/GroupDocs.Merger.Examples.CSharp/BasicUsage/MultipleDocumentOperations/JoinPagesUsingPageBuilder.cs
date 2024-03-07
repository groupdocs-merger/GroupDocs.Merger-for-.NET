using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    using GroupDocs.Merger.Domain.Builders;

    /// <summary>
    /// This example demonstrates how to join specific pages from several source documents using PageBuilder class.
    /// </summary>
    public class JoinPagesUsingPageBuilder
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: JoinPagesUsingPageBuilder");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_PDF;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            using (Merger merger = new Merger(filePath))
            {
                merger.Join(Constants.SAMPLE_PDF_2);

                PageBuilder pageBuilder = merger.CreatePageBuilder();

                pageBuilder.AddPage(pageBuilder.Documents[1].Pages[0]); // Add 1 page of the second document
                pageBuilder.AddPage(pageBuilder.Documents[0].Pages[1]); // Add 2 page of the first document
                pageBuilder.AddPage(pageBuilder.Documents[1].Pages[1]); // Add 2 page of the second document

                merger.ApplyPageBuilder(pageBuilder);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source documents were merged successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}
