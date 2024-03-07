using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to join images with different file types to PDF.
    /// </summary>
    public class CrossJoinImagesToPdf
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: CrossJoinImagesToPdf");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_PDF;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            using (Merger merger = new Merger(filePath))
            {
                merger.Join(Constants.SAMPLE_JPG);
                merger.Join(Constants.SAMPLE_SVG);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source documents were merged successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}
