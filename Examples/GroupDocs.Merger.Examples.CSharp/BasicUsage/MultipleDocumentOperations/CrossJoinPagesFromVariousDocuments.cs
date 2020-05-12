using GroupDocs.Merger.Domain.Options;
using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to join specific pages from several source documents with different file types.
    /// </summary>
    public class CrossJoinPagesFromVariousDocuments
    {
        public static void Run()
        {
            string filePath = Constants.SAMPLE_PDF;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            JoinOptions joinOptions = new JoinOptions(1, 2);

            using (Merger merger = new Merger(filePath))
            {
                merger.Join(Constants.SAMPLE_DOCX, joinOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source documents was merged successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}
