using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to join documents with different file types.
    /// </summary>
    public class CrossJoinMultipleImages
    {
        public static void Run()
        {
            string filePath = Constants.SAMPLE_PNG;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            using (Merger merger = new Merger(filePath))
            {
                merger.Join(Constants.SAMPLE_BMP);
                merger.Join(Constants.SAMPLE_JPG);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source documents was merged successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}
