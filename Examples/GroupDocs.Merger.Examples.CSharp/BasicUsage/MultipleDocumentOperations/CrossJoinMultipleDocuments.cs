using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to join documents with different file types.
    /// </summary>
    public class CrossJoinMultipleDocuments
    {
        public static void Run()
        {
            string filePath = Constants.SAMPLE_PDF;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            using (Merger merger = new Merger(filePath))
            {
                merger.Join(Constants.SAMPLE_DOCX);
                merger.Join(Constants.SAMPLE_XLSX);
                merger.Join(Constants.SAMPLE_PPTX);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source documents was merged successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}
