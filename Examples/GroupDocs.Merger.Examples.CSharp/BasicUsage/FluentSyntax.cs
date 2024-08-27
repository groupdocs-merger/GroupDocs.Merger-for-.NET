using System;
using System.IO;

using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to join documents with different file types.
    /// </summary>
    public class FluentSyntax
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: FluentSyntax");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_PNG;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            IImageJoinOptions imageJoinOptions = new ImageJoinOptions(ImageJoinMode.Vertical);

            using (Merger merger = new Merger(filePath))
            {
                merger
                    .Join(Constants.SAMPLE_BMP, imageJoinOptions)
                    .Join(Constants.SAMPLE_JPG, imageJoinOptions)
                    .Join(Constants.SAMPLE_GIF, imageJoinOptions)
                    .Save(filePathOut);
            }

            Console.WriteLine("Source documents were merged successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}
