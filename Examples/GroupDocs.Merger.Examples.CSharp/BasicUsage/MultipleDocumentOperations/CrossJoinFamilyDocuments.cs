using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to join documents with different file types.
    /// </summary>
    public class CrossJoinFamilyDocuments
    {
        public static void Run()
        {
            string filePath = Constants.SAMPLE_DOCX;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            using (Merger merger = new Merger(filePath))
            {
                merger.Join(Constants.SAMPLE_DOC);
                merger.Join(Constants.SAMPLE_DOCM);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source documents were merged successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}
