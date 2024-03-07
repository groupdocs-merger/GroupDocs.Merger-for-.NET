using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple BMP files into single file.
    /// For more details about merging image (.bmp) files please check this documentation article
    /// https://docs.groupdocs.com/merger/net/merge/images/
    /// https://docs.groupdocs.com/merger/net/getting-started/use-cases/how-to-merge-bmp-images-using-csharp/
    /// </summary>
    internal static class MergeBmp
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergeBmp");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.bmp");
            
            // Load the source BMP file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_BMP))
            {
                // Define image join options with vertical join mode
                var joinOptions = new GroupDocs.Merger.Domain.Options.ImageJoinOptions(GroupDocs.Merger.Domain.Options.ImageJoinMode.Vertical);
                // Add another BMP file to merge
                merger.Join(Constants.SAMPLE_BMP, joinOptions);
                // Merge BMP files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nBMP files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}