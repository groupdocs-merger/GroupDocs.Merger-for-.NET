using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to join documents.
    /// </summary>
    public class JoinMultipleDocuments
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: JoinMultipleDocuments");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_DOCX_2;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            using (Merger merger = new Merger(filePath))
            {
                merger.Join(Constants.SAMPLE_DOCX_3);
                merger.Join(Constants.SAMPLE_DOCX_4);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source documents were merged successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}
