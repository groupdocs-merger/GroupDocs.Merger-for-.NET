using GroupDocs.Merger.Domain.Options;
using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to join specific pages from several source documents.
    /// </summary>
    public class JoinPagesFromVariousDocuments
    {
        public static void Run()
        {
            string filePath = Constants.SAMPLE_DOCX_2;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            PageJoinOptions joinOptions = new PageJoinOptions(1, 2);

            using (Merger merger = new Merger(filePath))
            {
                merger.Join(Constants.SAMPLE_DOCX, joinOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source documents were merged successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}
